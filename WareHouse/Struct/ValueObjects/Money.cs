using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Struct.ValueObjects
{
    public readonly struct Money
    {
        public decimal Amount { get; }
        public Money(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Amount must be posititve");
            Amount = amount;
        }
        public override string ToString()
        {
            return Amount.ToString("0.00"); 
        }
    }
}
