using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Classes;
using WareHouse.Confing;

namespace WareHouse.Infrastructure.Storage
{
    public class BillRepository : JsonRepository<Bill>
    {
        public BillRepository() : base(PathConfing.BillFile)
        {
        }
    }
}
