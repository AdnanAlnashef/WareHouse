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
using WareHouse.Helpers.ToolsBox;
using WareHouse.Helpers.UI;
using WareHouse.Helpers.Validation;
using WareHouse.Interfaces.IRepository;
using WareHouse.Models;

namespace WareHouse.Design
{
    public partial class frm_account : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private User _userSelected;

        public frm_account(IUnitOfWork unitOfWork)
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

        private void btn_add_Click(object sender, EventArgs e)
        {
            bool cheack = true;
            var users = _unitOfWork.user.GetAll();
            if (ToolsBoxHelper.CheackTheEmpty(txt_name, txt_password, txt_phoneNumber, txt_tradetional_number) == true)
            {
                if (!InputValidator.IsValidName(txt_name.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Name is not correct");
                }
                foreach (var usr in users)
                {
                    if (usr.Name == txt_name.Text)
                    {
                        MessageBox.Show("The name is exists");
                        cheack = false;
                        break;
                    }
                }
                foreach (var usr in users)
                {
                    if (usr.TradetionalNumber == txt_tradetional_number.Text)
                    {
                        MessageBox.Show("The name is exists");
                        cheack = false;
                        break;
                    }
                }
                if (!InputValidator.IsValidPhone(txt_phoneNumber.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Phone is not correct");
                }
                if (!InputValidator.IsValidTradetionalNumber(txt_tradetional_number.Text))
                {
                    cheack = false;
                    MessageBox.Show("The TradetionalNumber is not correct");
                }

                if (cheack == true)
                {
                    User usr = new User(txt_name.Text, txt_password.Text, txt_tradetional_number.Text, txt_phoneNumber.Text);
                    _unitOfWork.user.Add(usr);
                    ToolsBoxHelper.ClearTextBoxes(txt_id, txt_name, txt_password, txt_phoneNumber, txt_tradetional_number);
                    var users1 = _unitOfWork.user.GetAll();
                    DataGridViewHelper.LoadData<User>(dgv_accounts, users1,true);
                    DataGridViewHelper.ConfigureHeader(dgv_accounts);
                }
            }
            else
            {
                MessageBox.Show("An empty field is requird");
            }
        }

        private void frm_account_Load(object sender, EventArgs e)
        {
            var users = _unitOfWork.user.GetAll();
            DataGridViewHelper.LoadData<User>(dgv_accounts, users, true);
            DataGridViewHelper.ConfigureHeader(dgv_accounts);
        }

        private void dgv_accounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _userSelected = DataGridViewHelper.GetSelectedItem<User>(dgv_accounts);
            LoadUserToTextBox(_userSelected);
            btn_add.Enabled = false;
        }
        private void LoadUserToTextBox(User user)
        {
            txt_id.Text = user.Id.ToString();
            txt_name.Text = user.Name;
            txt_password.Text = user.Password;
            txt_phoneNumber.Text = user.PhoneNumber;
            txt_tradetional_number.Text = user.TradetionalNumber;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            bool cheack = true;
            int next = 0;
            var users1 = _unitOfWork.user.GetAll();
            if (_userSelected == null)
            {
                MessageBox.Show("Select user first !!!");
            }
            else if(ToolsBoxHelper.CheackTheEmpty(txt_name, txt_password, txt_phoneNumber, txt_tradetional_number) == true)
            {
                foreach (var usr in users1)
                {
                    if (usr.Name == txt_name.Text)
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
                next = 0;
                foreach (var usr in users1)
                {
                    if (usr.TradetionalNumber == txt_tradetional_number.Text)
                    {
                        next++;
                        if (next == 2)
                        {
                            MessageBox.Show("The tradetional is exists");
                            cheack = false;
                            break;
                        }
                    }
                }
                if (!InputValidator.IsValidName(txt_name.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Name is not correct");
                }
                if (!InputValidator.IsValidPhone(txt_phoneNumber.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Phone is not correct");
                }
                if (!InputValidator.IsValidTradetionalNumber(txt_tradetional_number.Text))
                {
                    cheack = false;
                    MessageBox.Show("The TradetionalNumber is not correct");
                }

                if (cheack == true)
                {
                    _userSelected.Name = txt_name.Text;
                    _userSelected.Password = txt_password.Text;
                    _userSelected.PhoneNumber = txt_phoneNumber.Text;
                    _userSelected.TradetionalNumber = txt_tradetional_number.Text;
                    _unitOfWork.user.Update(_userSelected);
                    ToolsBoxHelper.ClearTextBoxes(txt_id, txt_name, txt_password, txt_phoneNumber, txt_tradetional_number);
                    var users = _unitOfWork.user.GetAll();
                    DataGridViewHelper.LoadData<User>(dgv_accounts, users, true);
                    DataGridViewHelper.ConfigureHeader(dgv_accounts);
                    btn_add.Enabled = true;
                    _userSelected = null;
                }
            }
            else
            {
                MessageBox.Show("An empty field is required");
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_userSelected == null)
                MessageBox.Show("Select a user firset");

            else
            {
                frm_confirm frm = new frm_confirm();
                frm.ShowDialog();
                if(frm.cheack == true)
                {
                    _unitOfWork.user.Delete(_userSelected.Id);
                }
                ToolsBoxHelper.ClearTextBoxes(txt_id, txt_name, txt_password, txt_phoneNumber, txt_tradetional_number);
                var users = _unitOfWork.user.GetAll();
                DataGridViewHelper.LoadData<User>(dgv_accounts, users, true);
                DataGridViewHelper.ConfigureHeader(dgv_accounts);
                btn_add.Enabled = true;
                _userSelected = null;
            }
        }
    }
}
