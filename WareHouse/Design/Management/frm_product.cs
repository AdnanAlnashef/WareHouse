using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Classes;
using WareHouse.Design.Confirm;
using WareHouse.Helpers;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Helpers.UI;
using WareHouse.Helpers.Validation;
using WareHouse.Infrastructure.Session;
using WareHouse.Interfaces.IRepository;
using WareHouse.Models;

namespace WareHouse.Design
{
    public partial class frm_product : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private Product _product;

        public frm_product(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            admenstrative_menu frm = new admenstrative_menu(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void frm_product_Load(object sender, EventArgs e)
        {
            
            var products = _unitOfWork.product.GetAll();
            var categories = _unitOfWork.category.GetAll();
            DataGridViewHelper.LoadData<Product>(dgv_product, products, true);
            DataGridViewHelper.ConfigureHeader(dgv_product);
            ComboBoxHelper.LoadComboBox<Category>(cmb_category_list, categories);
        }

        private void btn_add_product_Click(object sender, EventArgs e)
        {
            bool cheack = true;
            var products = _unitOfWork.product.GetAll();
            if (ToolsBoxHelper.CheackTheEmpty(txt_product_name, txt_purchase_price, txt_quantity, txt_selling_price) == true)
            {
                if (!InputValidator.IsValidName(txt_product_name.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Name is not correct");
                }
                foreach (var usr in products)
                {
                    if (usr.ProductName == txt_product_name.Text)
                    {
                        MessageBox.Show("The name is exists");
                        cheack = false;
                        break;
                    }
                }
                if (InputValidator.IsValidQuantity(txt_quantity.Text))
                {
                    if (int.Parse(txt_quantity.Text) <= 0)
                    {
                        MessageBox.Show("The quantity can not is zero or less");
                        cheack = false;
                    }
                }
                if (!InputValidator.IsValidQuantity(txt_quantity.Text))
                {
                    MessageBox.Show("The Quantity is not currect");
                    cheack = false;
                }
                if (InputValidator.IsValidPrice(txt_purchase_price.Text) && InputValidator.IsValidPrice(txt_selling_price.Text))
                {
                    if (double.Parse(txt_purchase_price.Text) >= double.Parse(txt_selling_price.Text))
                    {
                        MessageBox.Show("The purchase price not can >= selling price");
                        cheack = false;
                    }
                }
                if (!InputValidator.IsValidPrice(txt_purchase_price.Text))
                {
                    MessageBox.Show("The purchase price is not currect");
                    cheack = false;
                }
                if (!InputValidator.IsValidPrice(txt_selling_price.Text))
                {
                    MessageBox.Show("The selling price is not currect");
                    cheack = false;
                }

                if (cheack == true)
                {
                    decimal total = decimal.Parse(txt_purchase_price.Text) * int.Parse(txt_quantity.Text);
                    var category = cmb_category_list.SelectedItem as Category;
                    var categoryId = category.Id;
                    Product product = new Product(txt_product_name.Text, double.Parse(txt_purchase_price.Text), double.Parse(txt_selling_price.Text), int.Parse(txt_quantity.Text), categoryId);
                    if(BuyValidation.IsValidBuy(total))
                    {
                        _unitOfWork.product.Add(product);
                        ToolsBoxHelper.ClearTextBoxes(txt_product_id, txt_product_name, txt_purchase_price, txt_quantity, txt_selling_price);
                        var products1 = _unitOfWork.product.GetAll();
                        DataGridViewHelper.LoadData<Product>(dgv_product, products1, true);
                        DataGridViewHelper.ConfigureHeader(dgv_product);
                        WareHouseWallet.Withdraw(total);
                    }
                    else
                    {
                        MessageBox.Show("The Warehouse wallet not enough");
                    }
                }
            }
            else
            {
                MessageBox.Show("An empty field is requird");
            }
        }

        private void dgv_product_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _product = DataGridViewHelper.GetSelectedItem<Product>(dgv_product);
            LoadProductToTextBox(_product);
            btn_add_product.Enabled = false;
        }

        private void LoadProductToTextBox(Product prod)
        {
            txt_product_id.Text = prod.Id.ToString();
            txt_product_name.Text = prod.ProductName;
            txt_purchase_price.Text = prod.PurchasePrice.ToString();
            txt_selling_price.Text = prod.SellingPrice.ToString();
            txt_quantity.Text = prod.Quantity.ToString();
            cmb_category_list.SelectedValue = prod.IdCategory;
        }

        private void btn_edit_product_Click(object sender, EventArgs e)
        {
            bool cheack = true;
            int next = 0;
            var products = _unitOfWork.product.GetAll();
            if (_product == null)
            {
                MessageBox.Show("Select a product first !!");
            }
            else if (ToolsBoxHelper.CheackTheEmpty(txt_product_name, txt_purchase_price, txt_quantity, txt_selling_price) == true)
            {
                foreach (var prod in products)
                {
                    if (prod.ProductName == txt_product_name.Text)
                    {
                        next++;
                        if (next == 2)
                        {
                            MessageBox.Show("The name is exists");
                            cheack = false;
                            break;
                        }
                    }
                }
                if (int.Parse(txt_purchase_price.Text) == int.Parse(txt_selling_price.Text))
                {
                    MessageBox.Show("The purchase price not can >= selling price");
                    cheack = false;
                }
                if (!InputValidator.IsValidName(txt_product_name.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Name is not correct");
                }
                if (!InputValidator.IsValidPrice(txt_purchase_price.Text))
                {
                    cheack = false;
                    MessageBox.Show("The purchase price is not currect");
                }
                if (!InputValidator.IsValidPrice(txt_selling_price.Text))
                {
                    cheack = false;
                    MessageBox.Show("The selling price is not currect");
                }

                if (cheack == true)
                {
                    int quantity = int.Parse(txt_quantity.Text) - _product.Quantity;
                    decimal total = decimal.Parse(txt_purchase_price.Text) * quantity;
                    _product.ProductName = txt_product_name.Text;
                    _product.PurchasePrice = int.Parse(txt_purchase_price.Text);
                    _product.SellingPrice = int.Parse(txt_selling_price.Text);
                    _product.Quantity = int.Parse(txt_quantity.Text);
                    var category = cmb_category_list.SelectedItem as Category;
                    _product.IdCategory = category.Id;
                    if (BuyValidation.IsValidBuy(total))
                    {
                        _unitOfWork.product.Update(_product);
                        ToolsBoxHelper.ClearTextBoxes(txt_product_id, txt_product_name, txt_purchase_price, txt_quantity, txt_selling_price);
                        var products1 = _unitOfWork.product.GetAll();
                        DataGridViewHelper.LoadData<Product>(dgv_product, products1, true);
                        DataGridViewHelper.ConfigureHeader(dgv_product);
                        btn_add_product.Enabled = true;
                        _product = null;
                        WareHouseWallet.Withdraw(total);
                    }
                    else
                    {
                        MessageBox.Show("The Warehouse wallet not enough");
                    }
                }
            }
            else
            {
                MessageBox.Show("An empty field is required");
            }
        }

        private void btn_delete_product_Click(object sender, EventArgs e)
        {
            if (_product == null)
                MessageBox.Show("Select a product firset");

            else
            {
                frm_confirm frm = new frm_confirm();
                frm.ShowDialog();
                if (frm.cheack == true)
                {
                    _unitOfWork.product.Delete(_product.Id);
                }
                ToolsBoxHelper.ClearTextBoxes(txt_product_id, txt_product_name, txt_purchase_price, txt_quantity, txt_selling_price);
                var products = _unitOfWork.product.GetAll();
                DataGridViewHelper.LoadData<Product>(dgv_product, products, true);
                DataGridViewHelper.ConfigureHeader(dgv_product);
                btn_add_product.Enabled = true;
                _product = null;
            }
        }
    }
}
