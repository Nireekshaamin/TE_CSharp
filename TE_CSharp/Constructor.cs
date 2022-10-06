using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Constructor
    {
        public void add(int a,int b)
        {
            Console.WriteLine("{0}", (a + b));
        }
        public void add(float a, float b)
        {
            Console.WriteLine("{0}", (a + b));
        }
        public void add(string a, string b)
        {
            Console.WriteLine("{0}", (a + b));
        }

        public static void Main()
        {
            Constructor c = new Constructor();
            c.add(10,20);
            c.add(2.5F,3.7F);
            c.add("hey","siri");
        }
        
    }
}
