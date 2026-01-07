using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WareHouse.Helpers.Validation
{
    public static class InputValidator
    {
        public static bool IsValidName(string value) => Regex.IsMatch(value, RegexPatterns.Name);
        public static bool IsValidPhone(string value) => Regex.IsMatch(value, RegexPatterns.Phone);
        public static bool IsValidTradetionalNumber(string value) => Regex.IsMatch(value, RegexPatterns.TradetionalNumber);
        public static bool IsValidPrice(string value) => Regex.IsMatch(value, RegexPatterns.Price);
        public static bool IsValidQuantity(string value) => Regex.IsMatch(value, RegexPatterns.Quantity);
    }
}
