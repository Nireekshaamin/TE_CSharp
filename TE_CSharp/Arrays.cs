using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Arrays
    {
        public static void Main()
        {
            int[] array = new int[] { 1, 2, 3 };
            Console.WriteLine("array");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(array.Max());
            Console.WriteLine(array.Min());
            Console.WriteLine(array.Count());
            Console.WriteLine(array.Sum());
            Console.WriteLine(array.Average());
            Array.Sort(array);
            Console.WriteLine("sorted array");
            foreach (int j in array)
            {
                Console.WriteLine(j);
            }
            Array.Reverse(array);
            foreach(int k in array)
            {
                Console.WriteLine(k);
            }
        }
    }
}
