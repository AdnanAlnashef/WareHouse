using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse.Helpers.Validation
{
    public static class RegexPatterns
    {
        public const string Name = @"^[a-zA-Z0-9_]{3,20}$";
        public const string Phone = @"^09\d{8}$";
        public const string TradetionalNumber = @"^\d{11}$";
        public const string Price = @"^[0-9]+(\.[0-9]+)?$";
        public const string Quantity = @"^\d+$";
    }
}
