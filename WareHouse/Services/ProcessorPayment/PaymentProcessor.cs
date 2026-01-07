using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse.Interfaces.Payment;
using WareHouse.Struct.ValueObjects;

namespace WareHouse.Interfaces.ProcessorPayment
{
    public class PaymentProcessor
    {
        private readonly IPaymentMethod _paymentMethod;
        public PaymentProcessor(IPaymentMethod paymentMethod)
        {
            _paymentMethod = paymentMethod;
        }

        public bool Process(Money enteredAmount, Money totalAmount)
        {
            return _paymentMethod.Pay(enteredAmount, totalAmount);
        }
    }
}
