using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2;
using Guna.UI2.WinForms;

namespace WareHouse.Helpers.UI
{
    public static class ComboBoxHelper
    {
        public static void LoadComboBox<T>(Guna2ComboBox cmb, List<T> data)
        {
            cmb.DataSource = data;
            cmb.DisplayMember = "CategoryName";
            cmb.ValueMember = "Id";
        }
    }
}
