using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class AccessSpecifiersExample
    {
        public int tse;
        public int jse;
        public int tl;
        public int man;

        public void SalaryCalc(int tse1,int jse1,int tl1,int man1)
        {
            tse = tse1;
            jse = jse1;
            tl = tl1;
            man = man1;
            int tseBonus = ((20*tse)/100)+tse;
            int jseBonus = ((30 * jse) / 100) + jse;
            int tlBonus = ((40 * tl) / 100) + tl;
            int manBonus = ((50 * man) / 100) + man;
            Console.WriteLine("TSE Salary after adding bonus is "+tseBonus);
            Console.WriteLine("JSE Salary after adding bonus is " + jseBonus);
            Console.WriteLine("TL Salary after adding bonus is " + tlBonus);
            Console.WriteLine("Manager Salary after adding bonus is " + manBonus);
        }

    }
}
