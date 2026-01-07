using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Design.Confirm;
using WareHouse.Exceptions;
using WareHouse.Helpers.Validation;
using WareHouse.Infrastructure.Session;
using WareHouse.Interfaces.IRepository;
using WareHouse.Models;

namespace WareHouse.Design.Management
{
    public partial class frm_wallet_management : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frm_wallet_management(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_wallet_management_Load(object sender, EventArgs e)
        {
            txt_balance.Text = WareHouseWallet.Balance.ToString();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            admenstrative_menu frm = new admenstrative_menu(_unitOfWork);
            frm.Show();
            this.Close();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (!InputValidator.IsValidPrice(txt_amount.Text))
            {
                MessageBox.Show("The amount is not currect");
            }
            else
            {
                try
                {
                    WareHouseWallet.Add(decimal.Parse(txt_amount.Text));
                    txt_amount.Clear();
                    txt_balance.Text = WareHouseWallet.Balance.ToString();
                }
                catch (NegativeAmmountException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    txt_amount.Clear();
                }
            }
        }

        private void btn_withdraw_Click(object sender, EventArgs e)
        {
            if (!InputValidator.IsValidPrice(txt_amount.Text))
            {
                MessageBox.Show("The amount is not currect");
            }
            else
            {
                WareHouseWallet.Withdraw(decimal.Parse(txt_amount.Text));
                txt_amount.Clear();
                txt_balance.Text = WareHouseWallet.Balance.ToString();
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            frm_confirm frm = new frm_confirm();
            frm.ShowDialog();
            if (frm.cheack == true)
            {
                WareHouseWallet.Reset();
                txt_balance.Text = WareHouseWallet.Balance.ToString();
            }
            txt_amount.Clear();
        }
    }
}
