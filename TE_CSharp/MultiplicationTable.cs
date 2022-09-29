using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class MultiplicationTable
    {
        public static void Main()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Mul(arr);
        }
        public static void Mul(params int[] nums)
        {
            int[] n = new int[10];
            for(int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    n[i] = (j+1) * nums[i];
                    Console.Write(n[i].ToString() + "\t");

                }
                Console.WriteLine();


            }
            
        }
    }
}