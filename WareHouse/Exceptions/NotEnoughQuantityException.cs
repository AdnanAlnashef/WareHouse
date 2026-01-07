using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Exceptions
{
    public class NotEnoughQuantityException : Exception
    {
        public NotEnoughQuantityException() : base("Not enough Quantity") { }
    }
}
