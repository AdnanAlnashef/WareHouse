using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Exceptions
{
    public class NegativeAmmountException : Exception
    {
        public NegativeAmmountException() : base("The ammount cannot be negative or zero") { }
    }
}
