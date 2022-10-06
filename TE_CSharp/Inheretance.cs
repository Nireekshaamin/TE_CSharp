using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Bonus
    {
        protected int bonus=5000;
      
    }
    public class Staff : Bonus
    {
       public int n = 3;
        public void staff()
        {
            bonus = bonus * n;
            Console.WriteLine("Final Bonus for Staff is :"+bonus);
            Console.WriteLine("Salary of staff after adding bonus:"+(30000+bonus));

        }
        
    }
    public class NonStaff : Bonus
    {
        public int n = 2;
        public void nonstaff()
        {
            bonus = bonus * n;
            Console.WriteLine("Final Bonus for Non Staff is :" + bonus);
            Console.WriteLine("Salary of non staff after adding bonus:" + (20000 + bonus));
        }
    }

    internal class Inheretance
    {
        public static void Main()
        {
            Staff s = new Staff();
            s.staff();
            NonStaff n = new NonStaff();
            n.nonstaff();

        }
    }
}
