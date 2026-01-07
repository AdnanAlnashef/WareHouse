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
using WareHouse.Design.Confirm;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Helpers.UI;
using WareHouse.Helpers.Validation;
using WareHouse.Interfaces.IRepository;
using WareHouse.Models;

namespace WareHouse.Design
{
    public partial class frm_category : Form
    {
        private readonly IUnitOfWork _unitOfWork;
        private Category _categorySelected;

        public frm_category(IUnitOfWork unitOfWork)
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

        private void btn_add_category_Click(object sender, EventArgs e)
        {
            bool cheack = true;
            var categories = _unitOfWork.category.GetAll();
            if (ToolsBoxHelper.CheackTheEmpty(txt_category_name) == true)
            {
                if (!InputValidator.IsValidName(txt_category_name.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Name is not correct");
                }
                foreach (var cat in categories)
                {
                    if (cat.CategoryName == txt_category_name.Text)
                    {
                        MessageBox.Show("The name is exists");
                        cheack = false;
                        break;
                    }
                }
                if (cheack == true)
                {
                    Category category = new Category(txt_category_name.Text);
                    _unitOfWork.category.Add(category);
                    ToolsBoxHelper.ClearTextBoxes(txt_category_name, txt_category_id);
                    var categories1 = _unitOfWork.category.GetAll();
                    DataGridViewHelper.LoadData<Category>(dgv_category, categories1, true);
                    DataGridViewHelper.ConfigureHeader(dgv_category);
                }
            }
            else
            {
                MessageBox.Show("An empty field is requird");
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            bool cheack = true;
            int next = 0;
            var categories = _unitOfWork.category.GetAll();
            if (_categorySelected == null)
            {
                MessageBox.Show("Select a category first !!!");
            }
            else if (ToolsBoxHelper.CheackTheEmpty(txt_category_name) == true)
            {
                foreach (var cat in categories)
                {
                    if (cat.CategoryName == txt_category_name.Text)
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
                if (!InputValidator.IsValidName(txt_category_name.Text))
                {
                    cheack = false;
                    MessageBox.Show("The Name is not correct");
                }

                if (cheack == true)
                {
                    _categorySelected.CategoryName = txt_category_name.Text;
                    _unitOfWork.category.Update(_categorySelected);
                    ToolsBoxHelper.ClearTextBoxes(txt_category_name, txt_category_id);
                    var categories1 = _unitOfWork.category.GetAll();
                    DataGridViewHelper.LoadData<Category>(dgv_category, categories1, true);
                    DataGridViewHelper.ConfigureHeader(dgv_category);
                    btn_add_category.Enabled = true;
                    _categorySelected = null;
                }
            }
            else
            {
                MessageBox.Show("An empty field is required");
            }
        }

        private void dgv_category_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _categorySelected = DataGridViewHelper.GetSelectedItem<Category>(dgv_category);
            LoadCategoryToTextBox(_categorySelected);
            btn_add_category.Enabled = false;
        }

        private void frm_category_Load(object sender, EventArgs e)
        {
            var categories = _unitOfWork.category.GetAll();
            DataGridViewHelper.LoadData<Category>(dgv_category, categories, true);
            DataGridViewHelper.ConfigureHeader(dgv_category);
        }

        private void LoadCategoryToTextBox(Category cat)
        {
            txt_category_id.Text = cat.Id.ToString();
            txt_category_name.Text = cat.CategoryName;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (_categorySelected == null)
                MessageBox.Show("Select a user firset");

            else
            {
                frm_confirm frm = new frm_confirm();
                frm.ShowDialog();
                if (frm.cheack == true)
                {
                    _unitOfWork.category.Delete(_categorySelected.Id);
                }
                ToolsBoxHelper.ClearTextBoxes(txt_category_id, txt_category_name);
                var categories = _unitOfWork.category.GetAll();
                DataGridViewHelper.LoadData<Category>(dgv_category, categories, true);
                DataGridViewHelper.ConfigureHeader(dgv_category);
                btn_add_category.Enabled = true;
                _categorySelected = null;
            }
        }
    }
}
