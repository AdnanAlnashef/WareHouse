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
using WareHouse.Helpers.UI;
using WareHouse.Interfaces.IRepository;
using WareHouse.Models;

namespace WareHouse.Design
{
    public partial class frm_bill : Form
    {
        private readonly Bill _bill;
        
        public frm_bill(Bill bill)
        {
            InitializeComponent();
            _bill = bill;
        }

        private void frm_bill_Load(object sender, EventArgs e)
        {
            DateTime Date = _bill.DateTime.Date;
            string Time = _bill.DateTime.TimeOfDay.ToString(@"hh\:mm");
            lbl_time.Text = Time;
            lbl_date.Text = Date.ToString();
            lbl_total.Text += _bill.Total.ToString();
            DataGridViewHelper.LoadData<OrderItem>(dgv_bill, _bill.Items, true);
            dgv_bill.Columns["Id"].Visible = false;
            dgv_bill.Columns["ProductId"].Visible = false;
            DataGridViewHelper.ConfigureHeader(dgv_bill);
            label1.Text = _bill.Number.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
