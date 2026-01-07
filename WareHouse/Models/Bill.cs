using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Models;

namespace WareHouse.Classes
{
    public class Bill
    {
        public Guid Id { get; set; }
        public int Number { get; set; }
        public string Customer { get; set; }
        public DateTime DateTime { get; set; }
        public double Total { get; set; }
        public Guid UserId { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public bool Status { get; set; }

        public Bill() => Id = Guid.NewGuid();

        public Bill(int number, string name,  DateTime dateTime, double total, Guid userId, List<OrderItem> items, bool status)
        {
            Id = Guid.NewGuid();
            Number = number;
            Customer = name;
            DateTime = dateTime;
            Items = items;
            Total = total;
            UserId = userId;
            Status = status;
        }
    }
}
