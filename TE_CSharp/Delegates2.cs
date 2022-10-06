using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public delegate void BankDelegate2(string bankName, double interestRate);
  
    public class CalculateInterest1
    {
        int principle = 30000;
        int n = 2;

        public void Interest(string bankName, double interestRate)
        {
            Console.WriteLine("Bank name is:{0}\trate is:{1}\tInterest is{2}",bankName,interestRate,(principle * interestRate * n) / 100);
        }
        public void Interest1(string bankName, double interestRate)
        {
            Console.WriteLine("Bank name is:{0}\trate is:{1}\tInterest is{2}", bankName, interestRate, (principle * interestRate * n) / 100);
        }
        public void Interest2(string bankName, double interestRate)
        {
            Console.WriteLine("Bank name is:{0}\trate is:{1}\tInterest is{2}", bankName, interestRate, (principle * interestRate * n) / 100);
        }
        public void Interest3(string bankName, double interestRate)
        {
            Console.WriteLine("Bank name is:{0}\trate is:{1}\tInterest is{2}", bankName, interestRate, (principle * interestRate * n) / 100);
        }
        public void Interest4(string bankName, double interestRate)
        {
            Console.WriteLine("Bank name is:{0}\trate is:{1}\tInterest is{2}", bankName, interestRate, (principle * interestRate * n) / 100);
        }


    }

    internal class Delegates2
    {
        public static void Main()
        {

            CalculateInterest1 c = new CalculateInterest1();

            BankDelegate2 b = c.Interest;
            b("SBI", 2.7);
            b("HDFC", 3.3);
            b("Axis", 3.2);
            b("Kotak Mahindra bank", 3.5);
            b("ICICI", 3.3);
            b("HDFC", 3.1);
            b += c.Interest1;
            b += c.Interest2;
            b += c.Interest3;
            b += c.Interest4;

        }

    }
}
