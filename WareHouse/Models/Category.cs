using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Classes
{
    public class Category
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }

        public Category() => Id = Guid.NewGuid();

        public Category(string name)
        {
            Id = Guid.NewGuid();
            CategoryName = name;
        }
    }
}
