using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Classes;
using WareHouse.Confing;

namespace WareHouse.Infrastructure.Storage
{
    public class ProductRepository : JsonRepository<Product>
    {
        public ProductRepository() : base(PathConfing.ProductFile)
        {
        }
    }
}
