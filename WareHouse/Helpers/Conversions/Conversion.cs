using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Classes;
using WareHouse.Models;

namespace WareHouse.Helpers.Conversions
{
    public static class Conversion
    {
        public static OrderItem ProductToOrderProduct(Product prod)
        {
            OrderItem orderItem = new OrderItem();
            orderItem.Name = prod.ProductName;
            orderItem.Quantity = 1;
            orderItem.Price = prod.SellingPrice;
            orderItem.ProductId = prod.Id;
            return orderItem;
        }
    }
}
