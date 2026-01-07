using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Struct.ValueObjects;

namespace WareHouse.Interfaces.Payment
{
    public interface IPaymentMethod
    {
        string Name { get; }
        bool Pay(Money enteredAmount, Money totalAmount);
    }
}
