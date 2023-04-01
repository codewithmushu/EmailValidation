using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Email ID for validation :");

            Patterns patterns = new Patterns();

            string pin = Console.ReadLine();

            bool val = patterns.validatePinCode(pin);

            
            if (val)
            {
                Console.WriteLine("Pattern Matched");
            }
            else
            {
                Console.WriteLine("Pattern not Matched");
            }
        }
    }
}
