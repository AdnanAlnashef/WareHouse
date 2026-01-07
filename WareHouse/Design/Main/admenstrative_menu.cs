using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Design.Management;
using WareHouse.Interfaces.IRepository;

namespace WareHouse.Design
{
    public partial class admenstrative_menu : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public admenstrative_menu(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void btn_pos_Click(object sender, EventArgs e)
        {
            frm_pos frm = new frm_pos(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void btn_mgr_useraccount_Click(object sender, EventArgs e)
        {
            frm_account frm = new frm_account(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void btn_mgr_category_Click(object sender, EventArgs e)
        {
            frm_category frm = new frm_category(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void btn_mgr_product_Click(object sender, EventArgs e)
        {
            frm_product frm = new frm_product(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void btn_reports_Click(object sender, EventArgs e)
        {
            frm_inventory frm = new frm_inventory(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault();
            frm.Close();
        }

        private void btn_wallet_Click(object sender, EventArgs e)
        {
            frm_wallet_management frm = new frm_wallet_management(_unitOfWork);
            frm.Show();
            this.Close();
        }
    }
}
