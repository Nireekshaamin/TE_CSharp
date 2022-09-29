using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class MatrixAddition
    {
        public static void Main()
        {
            int i, j, n=3;
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int[,] c = new int[10, 10];
            Console.WriteLine("Enter the elements for first matrix");
            for(i=0; i < n; i++)
            {
                for(j=0; j < n; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements for second matrix");
            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("First matrix is");
            for(i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for(j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + "\t");
                }
            }
            Console.WriteLine("\nSecond matrix is");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for (j = 0; j < n; j++)
                {
                    Console.Write(b[i, j] + "\t");
                }
            }
            for(i = 0; i < n; i++)
            {
                for(j=0; j < n; j++)
                {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            Console.WriteLine("\nSum of matrix a and b");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine("\n");
                for(j=0; j < n; j++)
                {
                    Console.Write(c[i, j] + "\t");
                }
            }
            Console.WriteLine("\n");
        }
    }
}
