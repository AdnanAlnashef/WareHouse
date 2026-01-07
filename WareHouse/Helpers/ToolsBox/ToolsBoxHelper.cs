using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2;
using Guna.UI2.WinForms;

namespace WareHouse.Helpers.ToolsBox
{
    public static class ToolsBoxHelper
    {
        public static void ClearTextBoxes(params Guna2TextBox[] textBoxes)
        {
            foreach (var textBox in textBoxes)
            {
                if (textBox != null)
                {
                    textBox.Clear();
                }
            }
        }

        public static bool CheackTheEmpty(params Guna2TextBox[] textBoxes)
        {
            bool cheack = true;
            foreach (var textBox in textBoxes)
            {
                if (textBox.Text == "")
                {
                    cheack = false;
                    break;
                }
            }
            return cheack;
        }
    }
}
