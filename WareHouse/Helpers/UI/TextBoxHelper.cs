using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guna.UI2.WinForms;
using WareHouse.Models;

namespace WareHouse.Helpers.UI
{
    public static class TextBoxHelper
    {
        public static void TotalAmount(Guna2TextBox textBox, List<OrderItem> items)
        {
            double amount = 0;
            foreach (var item in items)
            {
                amount += item.TotalPrice;
            }
            textBox.Text = amount.ToString();
        }
    }
}
