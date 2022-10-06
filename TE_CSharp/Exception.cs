using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Exception
    {
        public void MultipleCatch()
        {
            int[] a = { 2, 3, 4,5};
            int[] b = { 1, 0 ,3};
            string value = null;
            string[] arr1 = { "Welcome", "to", "CSharp" };

            try
            {
                object[] arr2 = arr1;
                arr2[0] = 8;
            }
            catch (ArrayTypeMismatchException e)
            {
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(e.Message);
                Console.WriteLine("Stack trace: " + e.StackTrace);
                Console.WriteLine("\n Message: " + e.Message);
                Console.WriteLine("\n TargetSite: " + e.TargetSite);
                Console.WriteLine("\n Data: " + e.Data);
            }

            for (int i = 0; i < a.Length; i++)
            {
                
                try
                {
                    Console.WriteLine(a[i] / b[i]);

                }
                
                catch (DivideByZeroException e)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Stack trace: " + e.StackTrace);
                    Console.WriteLine("\n Message: " + e.Message);
                    Console.WriteLine("\n TargetSite: " + e.TargetSite);
                    Console.WriteLine("\n Data: " + e.Data);
                 
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("-----------------------------------------------------------");
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Stack trace: " + e.StackTrace);
                    Console.WriteLine("\n Message: " + e.Message);
                    Console.WriteLine("\n TargetSite: " + e.TargetSite);
                    Console.WriteLine("\n Data: " + e.Data);
                }

            }

        }
        public static void Main()
        {
            Exception ex = new Exception();
            ex.MultipleCatch();
        }
    }
}
