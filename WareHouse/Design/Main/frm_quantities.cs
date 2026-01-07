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

namespace WareHouse.Design.Main
{
    public partial class frm_quantities : Form
    {
        private readonly IUnitOfWork _uintOfWork;
        private Guid _categoryId;

        public frm_quantities(IUnitOfWork unitOfWork, Guid id)
        {
            InitializeComponent();
            _uintOfWork = unitOfWork;
            _categoryId = id;
        }

        private void frm_quantities_Load(object sender, EventArgs e)
        {
            var products = _uintOfWork.product.GetAll()
                .Where(p => p.IdCategory == _categoryId).ToList();
            DataGridViewHelper.LoadData<Product>(dgv_quntity, products, true);
            DataGridViewHelper.ConfigureHeader(dgv_quntity);
            DataGridView_Setting();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DataGridView_Setting()
        {
            dgv_quntity.Columns["Id"].Visible = false;
            dgv_quntity.Columns["PurchasePrice"].Visible = false;
            dgv_quntity.Columns["SellingPrice"].Visible = false;
            dgv_quntity.Columns["IdCategory"].Visible = false;
        }
    }
}
