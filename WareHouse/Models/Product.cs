using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Classes
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductName { get; set; }
        public double PurchasePrice { get; set; }
        public double SellingPrice { get; set; }
        public int Quantity { get; set; }
        public Guid IdCategory { get; set; }

        public Product() => Id = Guid.NewGuid();

        public Product(string name, double purchasePrice, double sellingPrice, int quantity, Guid idCategory)
        {
            Id = Guid.NewGuid();
            ProductName = name;
            PurchasePrice = purchasePrice;
            SellingPrice = sellingPrice;
            Quantity = quantity;
            IdCategory = idCategory;
        }
    }
}
