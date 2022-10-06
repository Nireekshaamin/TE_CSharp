using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternalDemo
{
    internal class Allotment1
    {
        internal void Department()
        {
            string dep;
            Console.WriteLine("Know your department");
            Console.WriteLine("Enter your name");
            dep = Console.ReadLine();
            switch (dep)
            {
                case "Mick":
                    Console.WriteLine("Your department is IT");
                    break;
                case "Ben":
                    Console.WriteLine("Your department is Banking");
                    break;
                case "Cal":
                    Console.WriteLine("Your department is Healthcare");
                    break;
                case "Olive":
                    Console.WriteLine("Your department is Banking");
                    break;
                default:
                    Console.WriteLine("Employee doesn't exist");
                    break;

            }
        }
    }
}
