using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Interfaces.IRepository;

namespace WareHouse.Design
{
    public partial class frm_representative : Form
    {
        private readonly IUnitOfWork _unitOfWork;

        public frm_representative(IUnitOfWork unitOfWork)
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
    }
}
