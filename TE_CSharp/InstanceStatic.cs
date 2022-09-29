using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class InstanceStatic
    {
        public static void Main()
        {
            Sum(10, 20);
            InstanceStatic ins = new InstanceStatic();
            ins.Product(5, 8);
            ins.SumOfDigits(456);
            Reverse(123);
            
        }
        public static void Sum(int a,int b)
        {
            int n1 = a;
            int n2 = b;
            int sum=n1 + n2;
            Console.WriteLine("The sum of the numbers is\t" + sum);
        }
        public static void Reverse(int num)
        {
            int rev = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine("The reverse of the number is\t"+rev);
        }
        public void SumOfDigits(int num)
        {
            int rev = 0, sum1 = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
                sum1 = sum1 + rem;
            }
            Console.WriteLine("The sum of the digits is\t"+sum1);
        }
        public void Product(int a, int b)
        {
            int n1 = a;
            int n2 = b;
            int pro = n1 * n2;
            Console.WriteLine("The product of the numbers is\t"+pro);
        }

    }
}
