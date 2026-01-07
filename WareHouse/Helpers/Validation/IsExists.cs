using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WareHouse.Classes;
using WareHouse.Helpers.ToolsBox;
using WareHouse.Models;

namespace WareHouse.Helpers.Validation
{
    public static class IsExists
    {
        public static bool OrderItem(string str)
        {
            foreach (var item in Order.Items)
            {
                if (item.Name == str)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CustomerName(string name, List<Bill> bills)
        {
            foreach (var item in bills)
            {
                if (item.Customer == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
