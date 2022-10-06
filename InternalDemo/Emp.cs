using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TE_CSharp;

namespace InternalDemo;
 
internal class Emp
{
    public static void Main()
    {
       AccessSpecifiersExample example = new AccessSpecifiersExample();
        Console.WriteLine("Salaries after calculating bonus");
        example.SalaryCalc(40000, 45000, 50000, 75000);
        Allotment1 al = new Allotment1();
        al.Department();
    }
}
