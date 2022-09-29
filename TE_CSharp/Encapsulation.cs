using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Program
    {
        private int empId;
        private string empName;

        public int EmpId
        {
            get { return empId; }
            set { empId = value; }
        }
        public string EmpName
        {
            get { return empName; }
            set { empName = value; }
        }
        public void display()
        {
            Console.WriteLine($"{empName}:{empId}");
        }
    }
    internal class Encapsulation
    {
        public static void Main()
        {
            Program p = new Program();
            p.EmpId = 100;
            p.EmpName = "John";
            Console.WriteLine(p.EmpId);
            Console.WriteLine(p.EmpName);
            p.display();
        }
    }
}
