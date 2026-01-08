using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WareHouse.Classes;
using WareHouse.Design.Confirm;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Helpers.UI;
using WareHouse.Interfaces.IRepository;
using WareHouse.Models;
using WareHouse.ViewModels.Reports;

namespace WareHouse.Design
{
    public partial class frm_inventory : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private Bill _bill;

        public frm_inventory(IUnitOfWork unitOfWork)
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

        private void dgv_rports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var bills = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
            List<Bill> billsThisCustomer;
            frm_reports_properties frm = new frm_reports_properties(_unitOfWork);
            frm.ShowDialog();
            if (frm.cheack == true)
            {
                if (!string.IsNullOrWhiteSpace(frm.Name))
                {
                    if (frm.cheackWithDate == true)
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.Customer == frm.Name && b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
                    }
                    else
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.Customer == frm.Name && b.Status == false).ToList();
                    }
                }
                else
                {
                    if (frm.cheackWithDate == true)
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
                    }
                    else
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
                    }
                }
                frm_confirm frmConfirm = new frm_confirm();
                frmConfirm.ShowDialog();
                if (frmConfirm.cheack == true)
                {
                    if (billsThisCustomer.Count != 0)
                    {
                        foreach (var b in billsThisCustomer)
                        {
                            _unitOfWork.bill.Delete(b.Id);   
                        }
                    }
                    else MessageBox.Show("No bills for delete");
                }
            }
        }

        private void frm_inventory_Load(object sender, EventArgs e) { }

        private void btn_inventory_Click(object sender, EventArgs e)
        {
            var products = _unitOfWork.product.GetAll();
            StringBuilder report = new StringBuilder();
            report.AppendLine("Inventory Report");
            report.AppendLine("==============================");
            foreach (var product in products)
            {
                report.AppendLine($"Product: {product.ProductName}, Quantity: {product.Quantity}");
            }
            report.AppendLine("==============================");
            MessageBox.Show(report.ToString(), "Inventory Report");
        }

        private void btn_profit_Click(object sender, EventArgs e)
        {
            List<ProfitVM> profits = new List<ProfitVM>();
            List<Bill> billsThisCustomer;
            frm_reports_properties frm = new frm_reports_properties(_unitOfWork);
            frm.ShowDialog();

            if (frm.cheack == true)
            {
                if (!string.IsNullOrWhiteSpace(frm.Name))
                {
                    if (frm.cheackWithDate == true)
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.Customer == frm.Name && b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
                    }
                    else
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.Customer == frm.Name && b.Status == false).ToList();
                    }
                }
                else
                {
                    if (frm.cheackWithDate == true)
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
                    }
                    else
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
                    }
                }

                StringBuilder report = new StringBuilder();
                report.AppendLine("Profit Report");
                report.AppendLine("====================================");

                foreach (var b in billsThisCustomer)
                {
                    ProfitVM profit = new ProfitVM
                    {
                        TotalPurchsePrice = SumPurcahsePrice(b.Items),
                        TotalSellingPrice = SumSellingPrice(b.Items),
                        DateTime = b.DateTime
                    };
                    profits.Add(profit);
                    report.AppendLine($"Date: {b.DateTime.ToShortDateString()}, Purchase: {profit.TotalPurchsePrice}, Selling: {profit.TotalSellingPrice}, Profit: {profit.Profit}");
                }

                report.AppendLine("====================================");
                report.AppendLine($"Total Profit: {SumProfits(profits)}");
                MessageBox.Show(report.ToString(), "Profit Report");
            }
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            List<Bill> billsThisCustomer;
            frm_reports_properties frm = new frm_reports_properties(_unitOfWork);
            frm.ShowDialog();

            if (frm.cheack == true)
            {
                if (!string.IsNullOrWhiteSpace(frm.Name))
                {
                    if (frm.cheackWithDate == true)
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.Customer == frm.Name && b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
                    }
                    else
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.Customer == frm.Name && b.Status == false).ToList();
                    }
                    }
                else
                {
                    if (frm.cheackWithDate == true)
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll()
                            .Where(b => b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
                    }
                    else
                    {
                        billsThisCustomer = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
                    }
                }

                StringBuilder report = new StringBuilder();
                report.AppendLine("Bills Report");
                report.AppendLine("====================================");

                foreach (var bill in billsThisCustomer)
                {
                    report.AppendLine($"Customer: {bill.Customer}, Date: {bill.DateTime.ToShortDateString()}, Total: {bill.Total}");
                }

                report.AppendLine("====================================");
                report.AppendLine($"Total Sales: {SumBills(billsThisCustomer)}");
                MessageBox.Show(report.ToString(), "Sales Report");
            }
        }

        private decimal SumPurcahsePrice(List<OrderItem> items)
        {
            decimal sum = 0;
            foreach (var item in items)
            {
                var prod = _unitOfWork.product.GetById(item.ProductId);
                sum += Convert.ToDecimal(prod.PurchasePrice * item.Quantity);
            }
            return sum;
        }

        private decimal SumSellingPrice(List<OrderItem> items)
        {
            decimal sum = 0;
            foreach (var item in items)
            {
                sum += Convert.ToDecimal(item.TotalPrice);
            }
            return sum;
        }

        private decimal SumProfits(List<ProfitVM> items)
        {
            decimal total = 0;
            foreach (var item in items)
            {
                total += item.Profit;
            }
            return total;
        }

        private decimal SumBills(List<Bill> bills)
        {
            decimal sum = 0;
            foreach (var bill in bills)
            {
                sum += Convert.ToDecimal(bill.Total);
            }
            return sum;
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using WareHouse.Classes;
//using WareHouse.Design.Confirm;
//using WareHouse.Helpers.ToolsBox;
//using WareHouse.Helpers.UI;
//using WareHouse.Interfaces.IRepository;
//using WareHouse.Models;
//using WareHouse.ViewModels.Reports;

//namespace WareHouse.Design
//{
//    public partial class frm_inventory : Form
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private Bill _bill;

//        public frm_inventory(IUnitOfWork unitOfWork)
//        {
//            InitializeComponent();
//            _unitOfWork = unitOfWork;
//        }

//        private void btn_exit_Click(object sender, EventArgs e)
//        {
//            admenstrative_menu frm = new admenstrative_menu(_unitOfWork);
//            frm.Show();
//            this.Close();
//        }

//        private void frm_inventory_Load(object sender, EventArgs e)
//        {

//        }

//        private void btn_inventory_Click(object sender, EventArgs e)
//        {
//            List<InventoryVM> invetories = new List<InventoryVM>();
//            var products = _unitOfWork.product.GetAll();
//            foreach (var product in products)
//            {
//                InventoryVM inv = new InventoryVM();
//                inv.Name = product.ProductName;
//                inv.Quantity = product.Quantity;
//                invetories.Add(inv);
//            }
//            DataGridViewHelper.LoadData<InventoryVM>(dgv_rports, invetories, true);
//            DataGridViewHelper.ConfigureHeader(dgv_rports);
//            lbl_total.Text = null;
//        }

//        private void btn_profit_Click(object sender, EventArgs e)
//        {
//            List<ProfitVM> profits = new List<ProfitVM>();
//            var bills = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
//            List<Bill> billsThisCustomer;
//            frm_reports_properties frm = new frm_reports_properties(_unitOfWork);
//            frm.ShowDialog();
//            if (frm.cheack == true)
//            {
//                if (frm.Name != null)
//                {
//                    if (frm.cheackWithDate == true)
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.Customer == frm.Name && b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
//                    }
//                    else
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.Customer == frm.Name && b.Status == false).ToList();
//                    }
//                }
//                else
//                {
//                    if (frm.cheackWithDate == true)
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
//                    }
//                    else
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
//                    }
//                }
//                foreach (var b in billsThisCustomer)
//                {
//                    ProfitVM profit = new ProfitVM();
//                    profit.TotalPurchsePrice = SumPurcahsePrice(b.Items);
//                    profit.TotalSellingPrice = SumSellingPrice(b.Items);
//                    profit.DateTime = b.DateTime;
//                    profits.Add(profit);
//                }
//                DataGridViewHelper.LoadData<ProfitVM>(dgv_rports, profits, true);
//                DataGridViewHelper.ConfigureHeader(dgv_rports);
//                lbl_total.Text = "Total : "+SumProfits(profits);
//            }
//        }

//        private decimal SumPurcahsePrice(List<OrderItem> items)
//        {
//            decimal sum = 0;
//            foreach (var item in items)
//            {
//                var prod = _unitOfWork.product.GetById(item.ProductId);
//                sum += Convert.ToDecimal(prod.PurchasePrice * item.Quantity);
//            }
//            return sum;
//        }

//        private decimal SumSellingPrice(List<OrderItem> items)
//        {
//            decimal sum = 0;
//            foreach (var item in items)
//            {
//                sum += Convert.ToDecimal(item.TotalPrice);
//            }    
//            return sum;
//        }

//        private decimal SumProfits(List<ProfitVM> items)
//        {
//            decimal total = 0;
//            foreach(var item in items)
//            {
//                total += item.Profit;
//            }
//            return total;
//        }

//        private decimal SumBills(List<Bill> bills)
//        {
//            decimal sum = 0;
//            foreach (var bill in bills)
//            {
//                sum += Convert.ToDecimal(bill.Total);
//            }
//            return sum;
//        }

//        private void btn_sales_Click(object sender, EventArgs e)
//        {
//            var bills = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
//            List<Bill> billsThisCustomer;
//            frm_reports_properties frm = new frm_reports_properties(_unitOfWork);
//            frm.ShowDialog();
//            if (frm.cheack == true)
//            {
//                if (string.IsNullOrWhiteSpace(frm.Name))
//                {
//                    if (frm.cheackWithDate == true)
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.Customer == frm.Name && b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
//                    }
//                    else
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.Customer == frm.Name && b.Status == false).ToList();
//                    }
//                }
//                else
//                {
//                    if (frm.cheackWithDate == true)
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
//                    }
//                    else
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
//                    }
//                }
//                DataGridViewHelper.LoadData<Bill>(dgv_rports, billsThisCustomer, true);
//                dgv_rports.Columns["Id"].Visible = false;
//                dgv_rports.Columns["UserId"].Visible = false;
//                DataGridViewHelper.ConfigureHeader(dgv_rports);
//                lbl_total.Text = "Total : " + SumBills(billsThisCustomer);
//            }
//        }

//        private void dgv_rports_CellClick(object sender, DataGridViewCellEventArgs e)
//        {
//        }

//        private void btn_delete_Click(object sender, EventArgs e)
//        {
//            var bills = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
//            List<Bill> billsThisCustomer;
//            frm_reports_properties frm = new frm_reports_properties(_unitOfWork);
//            frm.ShowDialog();
//            if (frm.cheack == true)
//            {
//                if (string.IsNullOrWhiteSpace(frm.Name))
//                {
//                    if (frm.cheackWithDate == true)
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.Customer == frm.Name && b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
//                    }
//                    else
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.Customer == frm.Name && b.Status == false).ToList();
//                    }
//                }
//                else
//                {
//                    if (frm.cheackWithDate == true)
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll()
//                            .Where(b => b.DateTime >= frm.dateFrom && b.DateTime <= frm.dateTo && b.Status == false).ToList();
//                    }
//                    else
//                    {
//                        billsThisCustomer = _unitOfWork.bill.GetAll().Where(b => b.Status == false).ToList();
//                    }
//                }
//                frm_confirm frmConfirm = new frm_confirm();
//                frmConfirm.ShowDialog();
//                if (frmConfirm.cheack == true)
//                {
//                    foreach (var b in billsThisCustomer)
//                    {
//                        _unitOfWork.bill.Delete(b.Id);
//                        billsThisCustomer.Remove(b);
//                    }
//                    DataGridViewHelper.LoadData<Bill>(dgv_rports, billsThisCustomer, true);
//                    dgv_rports.Columns["Id"].Visible = false;
//                    dgv_rports.Columns["UserId"].Visible = false;
//                    DataGridViewHelper.ConfigureHeader(dgv_rports);
//                }
//            }
//        }
//    }
//}
