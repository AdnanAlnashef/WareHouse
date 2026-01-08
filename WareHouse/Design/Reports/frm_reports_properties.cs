using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Helpers.UI;
using WareHouse.Helpers.Validation;
using WareHouse.Interfaces.IRepository;

namespace WareHouse.Design
{
    public partial class frm_reports_properties : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        public string Name = null;
        public DateTime dateFrom;
        public DateTime dateTo;
        public bool cheack = true;
        public bool cheackWithDate = true;
        public frm_reports_properties(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void frm_reports_properties_Load(object sender, EventArgs e)
        {
            dt_from.Value = DateTime.Now;
            dt_to.Value = DateTime.Now;
            rbtn_with.Checked = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            var bills = _unitOfWork.bill.GetAll();
            if (!string.IsNullOrWhiteSpace(txt_name_customer.Text))
            {
                if (IsExists.CustomerName(txt_name_customer.Text, bills))
                {
                    Name = txt_name_customer.Text;
                }
                else MessageBox.Show("The name not exsits");
            }
            else
                Name = null;

            DateTime from = dt_from.Value;
            DateTime to = dt_to.Value;
            if (from >= to && cheackWithDate == true)
            {
                MessageBox.Show("The date of start must be less than end", "Error in Date",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                dateFrom = from;
                dateTo = to;
                this.Close();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cheack = false;
            this.Close();
        }

        private void rbtn_with_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_with.Checked == true)
            {
                cheackWithDate = true; 
                dt_from.Enabled = true;
                dt_to.Enabled = true;
            }
        }

        private void rbtn_notwith_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtn_notwith.Checked == true)
            {
                dt_from.Enabled = false;
                dt_to.Enabled = false;
                cheackWithDate = false;
            }
        }
    }
}
