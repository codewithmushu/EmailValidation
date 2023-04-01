using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Patterns
    {
        public static string REGEX_PINCODE = "^\\w+@[a-zA-Z_]+?\\.[a-zA-Z]{2,3}$";

        public bool validatePinCode(string pinCode)
        {
            return Regex.IsMatch(pinCode, REGEX_PINCODE);
        }
    }
}
