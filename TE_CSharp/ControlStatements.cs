using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class ControlStatements
    {
        public static void Main()
        {
            ControlStatements cs = new ControlStatements();
            cs.LeapYearOrNot(2000);
            cs.month();
            While(4567);
            DoWhile(234);
            ForEach();
            ForExample(6);
        }
        public static void While(int number)
        {
            int num = number, i=0;
            while (number > 0)
            {
                i++;
                number=number/10;
            }
            Console.WriteLine("Using while:The number of digits in {0} is {1}",num,i);
        }
        public static void DoWhile(int number)
        {
            int num = number, i = 0;
            do
            {
                i++;
                number = number / 10;
            }while (number > 0);
            Console.WriteLine("Using Do-while:The number of digits in {0} is {1}", num, i);
            Console.WriteLine("----------------------------------------------------");
        }
        public static void ForEach()
        {
            string[] names = { "sam", "rob", "cal" };
            foreach (string n in names)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("----------------------------------------------------");
        }
        public static void ForExample(int num)
        {
            int i;
            Console.WriteLine("Tables");
            for (i = 1; i <=10; i++)
            {
                Console.WriteLine("{0}*{1}={2}",num,i,(num*i));
            }
            Console.WriteLine("----------------------------------------------------");
        }
        public void LeapYearOrNot(int year)
        {
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year + "\t is a leap year");
            }
            else
            {
                Console.WriteLine(year+"Not a leap year");
            }
            Console.WriteLine("----------------------------------------------------");
        }
        public void month()
        {
            int m;
            Console.WriteLine("Enter the month number");
            m=Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:Console.WriteLine("January");
                       break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:Console.WriteLine("Invalid");
                    break;
            }
            Console.WriteLine("----------------------------------------------------");
        }
    }
}