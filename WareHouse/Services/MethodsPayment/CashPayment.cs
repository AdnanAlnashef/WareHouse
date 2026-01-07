using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WareHouse.Infrastructure.Session;
using WareHouse.Interfaces.Payment;
using WareHouse.Struct.ValueObjects;

namespace WareHouse.Services.MethodsPayment
{
    public sealed class CashPayment : IPaymentMethod
    {
        public string Name => "Cash";
        public bool Pay(Money enateredAmount, Money totalAmount)
        {
            if (enateredAmount.Amount < totalAmount.Amount)
                return false;
            WareHouseWallet.Add(totalAmount.Amount);
            return true;
        }
    }
}
