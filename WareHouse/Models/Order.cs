using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models
{
    public static class Order
    {
        public static List<OrderItem> Items { get; set; } = new List<OrderItem>();
    }
}
