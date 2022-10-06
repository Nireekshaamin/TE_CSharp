using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp;
   
    public class AgeException1 : ApplicationException
    {
        public AgeException1(string message) : base(message)
        {

        }
    }

    internal class CustomException
    {
        public static void Main()
        {
            int age;
            try
            {
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 22)
                {
                    throw (new AgeException1("Age is more than 22"));
                }
                else
                {
                    Console.WriteLine("Age is less or equal to 22");
                }
            }
            catch (AgeException1 e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
