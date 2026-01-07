using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Design;
using WareHouse.Helpers.Session;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Interfaces.IRepository;

namespace WareHouse
{
    public partial class log_in : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public log_in(IUnitOfWork unitOfWork)
        {
            InitializeComponent();
            _unitOfWork = unitOfWork;
        }

        private void log_in_Load(object sender, EventArgs e)
        {
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_entry_Click(object sender, EventArgs e)
        {
            var users = _unitOfWork.user.GetAll();
            bool cheack = false;
            if(ToolsBoxHelper.CheackTheEmpty(txt_password, txt_username) == false)
            {
                MessageBox.Show("User name or password is empty");
            }
            else
            {
                foreach (var usr in users)
                {
                    if (usr.Name == txt_username.Text)
                    {
                        cheack = true;
                        var user = _unitOfWork.user.GetById(usr.Id);
                        if (user.Password == txt_password.Text)
                        {
                            AppSession.Login(user);
                        }
                        else
                        {
                            MessageBox.Show("The password is not currect");
                        }
                        break;
                    }
                }
                if (cheack == false)
                {
                    MessageBox.Show("User name not is exists");
                }
            }
            if (AppSession.IsAuthenticated == true)
            {
                if (AppSession.CurrentUser.Name == "admin")
                {
                    ToolsBoxHelper.ClearTextBoxes(txt_password, txt_username);
                    admenstrative_menu frm = new admenstrative_menu(_unitOfWork);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    ToolsBoxHelper.ClearTextBoxes(txt_password, txt_username);
                    frm_pos frm = new frm_pos(_unitOfWork);
                    frm.Show();
                    this.Hide();
                }
            }
        }
    }
}
