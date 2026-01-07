using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.ViewModels.Reports
{
    public class ProfitVM
    {
        public DateTime DateTime { get; set; }
        public decimal TotalPurchsePrice { get; set; }
        public decimal TotalSellingPrice { get; set; }
        public decimal Profit => TotalSellingPrice - TotalPurchsePrice;
    }
}
