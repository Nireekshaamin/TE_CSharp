using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
   
    internal class Generic
    {
        
    }
}
namespace Generics_Evolution
{
    public class Generic
    {
        public static void Stage1()
        {
            bool result = AreEqual1<int>(1, 1);

            bool result1 = AreEqual1<string>("hey", "hey");
            if (result1)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
        }
        //public static void Stage3()
        //{
        //    bool result = AreEqual("a", "ab");
        //    if (result)
        //    {
        //        Console.WriteLine("equal");
        //    }
        //    else
        //    {
        //        Console.WriteLine("not equal");
        //    }
        //}
        public static bool AreEqual1<T>(T value1, T value2)
        {
            return value1.Equals(value2);
        }
        //public static bool AreEqual(object value1, object value2)
        //{
        //    return value1 == value2;
        //}
        public static void Main()
        {
            Stage1();
        }
    }
}