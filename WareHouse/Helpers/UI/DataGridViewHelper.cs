using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WareHouse.Helpers.UI
{
    public static class DataGridViewHelper
    {
        public static void LoadData<T>(DataGridView grid, List<T> data, bool readOnly)
        {
            grid.Columns.Clear();
            grid.RowHeadersVisible = true;
            grid.AutoGenerateColumns = true;
            grid.DataSource = null;
            grid.DataSource = data;
            if (readOnly)
                grid.ReadOnly = true;
        }

        public static void ConfigureHeader(DataGridView grid, int height = 40)
        {
            grid.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.EnableResizing;

            grid.ColumnHeadersHeight = height;
        }


        public static T GetSelectedItem<T>(DataGridView dgv) where T : class
        {
            if (dgv.CurrentRow == null)
                return null;

            return dgv.CurrentRow.DataBoundItem as T;
        }
    }
}
