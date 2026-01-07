using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse.Design.Confirm
{
    public partial class frm_confirm : Form
    {
        public bool cheack;
        public frm_confirm()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            cheack = true;
            this.Close();
        }

        private void btn_cancell_Click(object sender, EventArgs e)
        {
            cheack = false;
            this.Close();
        }
    }
}
