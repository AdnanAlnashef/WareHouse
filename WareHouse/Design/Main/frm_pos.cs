using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using WareHouse.Classes;
using WareHouse.Design.Main;
using WareHouse.Exceptions;
using WareHouse.Helpers.Conversions;
using WareHouse.Helpers.Session;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Helpers.UI;
using WareHouse.Helpers.Validation;
using WareHouse.Interfaces.IRepository;
using WareHouse.Interfaces.Payment;
using WareHouse.Interfaces.ProcessorPayment;
using WareHouse.Models;
using WareHouse.Services;
using WareHouse.Services.MethodsPayment;
using WareHouse.Struct.ValueObjects;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace WareHouse.Design
{
    public partial class frm_pos : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private List<Guid> _selectedBillIds = new List<Guid>();
        private PaymentProcessor _process;
        private Bill _bill;
        private OrderItem _orderItem;
        private BillNumbreService _billService;
        private Guid showQuantitiesId;
        private InventoryService inventoryService;

        public frm_pos(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }
        private void frm_pos_Load(object sender, EventArgs e)
        {
            var _userId = AppSession.CurrentUser.Id;
            if (AppSession.IsAuthenticated)
            {
                lbl_user.Text = $"The casheir : {AppSession.CurrentUser.Name}";
            }
            else
                lbl_user.Text = "admin";

            var categories = _unitOfWork.category.GetAll();
            var bills = _unitOfWork.bill.GetAll()
                .Where(b => b.UserId == _userId && b.Status == true).ToList();
            DynamicButtonFactory.CreateButtonsWithOverFlow(
                flp_btn_categories,
                categories,
                c => c.CategoryName,
                CategoryButton_Click,
                maxVisibleButtons: 8
                );
            timer_now.Start();
            _billService = new BillNumbreService(_unitOfWork);
            upd_invoice_number.Value = _billService.GetNextInvoiceNumber();
            DataGridViewHelper.LoadData<Bill>(dgv_bills, bills, true);
            dgv_bills_Setting();
            DataGridViewHelper.ConfigureHeader(dgv_bills);
        }

        private void dgv_bills_Setting()
        {
            dgv_bills.Columns["Id"].Visible = false;
            dgv_bills.Columns["Status"].Visible = false;
            dgv_bills.Columns["UserId"].Visible = false;
        }

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            var btn = sender as Guna2Button;
            var category = btn?.Tag as Category;
            showQuantitiesId = category.Id;
            if (category == null) return;
            var products = _unitOfWork.product.GetAll().
                Where(p => p.IdCategory == category.Id).ToList();
            LoadProducts(products);
        }

        private void LoadProducts(List<Product> products)
        {
            DynamicButtonFactory.CreateButtonsWithOverFlow(
                flb_btn_products,
                products,
                p => p.ProductName,
                ProductButton_Click,
                maxVisibleButtons: 32
                );
        }

        private void ProductButton_Click( object sender, EventArgs e)
        {
            bool cheack = true;
            var btn = sender as Guna2Button;
            var product = btn?.Tag as Product;
            if (product == null) return;
            var orderItem = Conversion.ProductToOrderProduct(product);
            if (!IsExists.OrderItem(orderItem.Name))
            {
                Order.Items.Add(orderItem);
            }
            else
            {
               var item = Order.Items.FirstOrDefault(o => o.Name == orderItem.Name);
                item.Quantity += 1;
            }
            DataGridViewHelper.LoadData<OrderItem>(dgv_order, Order.Items, false);
            DataGridViewHelper.ConfigureHeader(dgv_order);
            DataGridViewSetting();
            TextBoxHelper.TotalAmount(txt_total, Order.Items);
        }

        private void dgv_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _orderItem = DataGridViewHelper.GetSelectedItem<OrderItem>(dgv_order);
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_orderItem != null)
            {
                var removeItem = Order.Items.FirstOrDefault(rm => rm.Id ==  _orderItem.Id);
                Order.Items.Remove(removeItem);
                DataGridViewHelper.LoadData<OrderItem>(dgv_order, Order.Items, false);
                DataGridViewHelper.ConfigureHeader(dgv_order);
                DataGridViewSetting();
                TextBoxHelper.TotalAmount(txt_total, Order.Items);
                _orderItem = null;
            }
        }

        private void DataGridViewSetting()
        {
            dgv_order.Columns["Id"].Visible = false;
            dgv_order.Columns["ProductId"].Visible = false;
            dgv_order.Columns["Name"].ReadOnly = true;
            dgv_order.Columns["Price"].ReadOnly = true;
            dgv_order.Columns["TotalPrice"].ReadOnly = true;
            dgv_order.Columns[2].ReadOnly = false;
        }

        private void dgv_order_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex < 0) return;
            if (dgv_order.Columns[e.ColumnIndex].Name == "Quantity")
            {
                int qty = Convert.ToInt32(dgv_order.Rows[e.RowIndex].Cells["Quantity"].Value);
                if (qty <= 0)
                {
                    MessageBox.Show("The quantity must be positive");
                    return;
                }

                Order.Items[e.RowIndex].Quantity = qty;
                TextBoxHelper.TotalAmount(txt_total, Order.Items);
                DataGridViewHelper.LoadData<OrderItem>(dgv_order, Order.Items, false);
                DataGridViewHelper.ConfigureHeader(dgv_order);
                DataGridViewSetting();
            }
        }

        private void dgv_order_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dgv_order.IsCurrentCellDirty)
            {
                dgv_order.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dt_invoice_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer_now_Tick(object sender, EventArgs e)
        {
            dt_invoice.Value = DateTime.Now;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Order.Items.Clear();
            txt_customerName.ReadOnly = false;
            DataGridViewHelper.LoadData<OrderItem>(dgv_order, Order.Items, false);
            DataGridViewHelper.ConfigureHeader(dgv_order);
            DataGridViewSetting();
            TextBoxHelper.TotalAmount(txt_total,Order.Items);
            ToolsBoxHelper.ClearTextBoxes(txt_customerName, txt_enteredAmount, txt_note);
            _billService = new BillNumbreService(_unitOfWork);
            upd_invoice_number.Value = _billService.GetNextInvoiceNumber();
        }

        private void btn_show_quantity_Click(object sender, EventArgs e)
        {
            if (showQuantitiesId != null)
            {
                frm_quantities frm = new frm_quantities(_unitOfWork, showQuantitiesId);
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Select a category first");
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            bool cheackQuantity = true;
            bool cheack = true;
            inventoryService = new InventoryService(_unitOfWork);
            upd_invoice_number.Value = _billService.GetNextInvoiceNumber();
            int num = int.Parse(upd_invoice_number.Value.ToString());
            var userId = AppSession.CurrentUser.Id;
            if (ToolsBoxHelper.CheackTheEmpty(txt_customerName, txt_enteredAmount) == true)
            {
                if (!InputValidator.IsValidName(txt_customerName.Text))
                {
                    MessageBox.Show("The Customer name not currect");
                    cheack = false;
                }
                if (!InputValidator.IsValidPrice(txt_enteredAmount.Text))
                {
                    MessageBox.Show("The price is not currect");
                    cheack = false;
                }
            }
            else
            {
                MessageBox.Show("There is required field empty");
                cheack = false;
            }
            if (cheack == true)
            {
                try
                {
                    foreach (var item in Order.Items)
                    {
                        if (!inventoryService.DecreaseStock(item.ProductId, item.Quantity))
                            cheackQuantity = false;
                    }
                    Money entered = new Money(Convert.ToDecimal(txt_enteredAmount.Text));
                    Money total = new Money(Convert.ToDecimal(txt_total.Text));
                    CashPayment cash = new CashPayment();
                    _process = new PaymentProcessor(cash);
                    if (_process.Process(entered, total) && cheackQuantity == true)
                    {
                        var products = Order.Items;
                        Bill bill = new Bill(num, txt_customerName.Text, dt_invoice.Value, Convert.ToDouble(txt_total.Text), userId, products, true);
                        ToolsBoxHelper.ClearTextBoxes(txt_total, txt_enteredAmount, txt_customerName, txt_note);
                        dgv_order.DataSource = null;
                        _unitOfWork.bill.Add(bill);
                        frm_bill frm = new frm_bill(bill);
                        frm.ShowDialog();
                        Order.Items.Clear();
                        DataGridViewHelper.LoadData<Bill>(dgv_bills, _unitOfWork.bill.GetAll().Where(b => b.Status == true).ToList(), true);
                        dgv_bills_Setting();
                        DataGridViewHelper.ConfigureHeader(dgv_bills);
                    }
                    else if (cheackQuantity == true) MessageBox.Show("The amount entered by the user is insufficient");
                }
                catch (NegativeAmmountException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch(NotEnoughQuantityException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                catch(ArgumentException ex)
                {
                    MessageBox.Show(ex.ToString()); 
                }
                finally
                {
                }
            }
        }

        private void dgv_bills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _bill = DataGridViewHelper.GetSelectedItem<Bill>(dgv_bills);
            DataGridViewHelper.LoadData<OrderItem>(dgv_order, _bill.Items, true);
            dgv_order.Columns["Id"].Visible = false;
            dgv_order.Columns["ProductId"].Visible = false;
            DataGridViewHelper.ConfigureHeader(dgv_order);
            txt_customerName.Text = _bill.Customer;
            txt_customerName.ReadOnly = true;
            TextBoxHelper.TotalAmount(txt_total, _bill.Items);
        }

        private void cmb_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            string str = cmb_menu.SelectedItem.ToString();
            switch(str)
            {
                case "Log out":
                    AppSession.Logout();
                    log_in frm = Application.OpenForms.Cast<log_in>().FirstOrDefault();
                    frm.Show();
                    this.Close();
                    break;
                case "Adminstrative menu":
                    if (AppSession.CurrentUser.Name == "admin")
                    {
                        admenstrative_menu frm_admin = new admenstrative_menu(_unitOfWork);
                        frm_admin.Show();
                        this.Close();
                    }
                    else MessageBox.Show("You do not have permission to access this page");
                    break;
            }
        }

        private void btn_archive_Click(object sender, EventArgs e)
        {
            if (_selectedBillIds.Count != 0)
            {
                foreach (var id in _selectedBillIds)
                {
                    var bill = _unitOfWork.bill.GetById(id);
                    bill.Status = false;
                    _unitOfWork.bill.Update(bill);
                }
            }
            else if (_bill != null)
            {
                _bill.Status = false;
                _unitOfWork.bill.Update(_bill);
            }
            DataGridViewHelper.LoadData<Bill>(dgv_bills, _unitOfWork.bill.GetAll().Where(b => b.Status == true).ToList(), true);
            dgv_bills_Setting();
            DataGridViewHelper.ConfigureHeader(dgv_bills);
            dgv_order.DataSource = null;
            ToolsBoxHelper.ClearTextBoxes(txt_customerName, txt_enteredAmount, txt_note);
        }

        private void dgv_bills_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1 && e.ColumnIndex == -1)
            {
                _selectedBillIds.Clear();
                dgv_bills.SelectAll();
                foreach (DataGridViewRow row in dgv_bills.Rows)
                {
                    if (row.IsNewRow) continue;
                    var bill = row.DataBoundItem as Bill;
                    if (bill != null)
                    {
                        _selectedBillIds.Add(bill.Id);
                    }
                }
            }

            else
                _bill = DataGridViewHelper.GetSelectedItem<Bill>(dgv_bills);
        }
    }
}
