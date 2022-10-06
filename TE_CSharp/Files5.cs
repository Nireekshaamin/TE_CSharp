using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Files5
    {
        public static void Main()
        {
            string path = @"C:\Users\EI13059\Assignment1.txt";
            
            
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
        }
    }
}