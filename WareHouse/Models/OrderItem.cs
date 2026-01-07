using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Models
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice => Price * Quantity;
        public Guid ProductId { get; set; }

        public OrderItem() => Id = Guid.NewGuid();

        public OrderItem(string name, double price, int quantity, Guid productId)
        {
            Id = Guid.NewGuid();
            Name = name;
            Price = price;
            Quantity = quantity;
            ProductId = productId;
        }
    }
}
