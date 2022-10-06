using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class RegExp
    {
        public static void Main()
        {
          
            mobile();

        }
        public static void mobile()
        {
            Console.WriteLine("mobile validation");
            Console.WriteLine("Enter the mobile number");
            string mobile = Console.ReadLine();
            var validate_mobile = Regex.IsMatch(mobile, @"^\(?([7-9]{1})\)?([0-9]{9})$");
            Console.WriteLine(validate_mobile);
        }

    }
}
