using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Infrastructure.Session;

namespace WareHouse.Helpers
{
    public static class BuyValidation
    {
        public static bool IsValidBuy(decimal amount)
        {
            return amount < WareHouseWallet.Balance;
        }
    }
}
