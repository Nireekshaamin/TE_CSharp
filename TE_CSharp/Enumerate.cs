using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TE_CSharp;

namespace CSharp
{
    internal class Enumerate
    {
      enum Days
        {
            sunday,
            monday,
            tuesday,
            wednestday,
            thursday,
            friday,
            saturday
        }
        public static void Main()
        {
            int WeekDayStart = (int)Days.monday;
            int WeekDayEnd = (int)Days.friday;
            Console.WriteLine("Monday:"+WeekDayStart + "\nFriday:" + WeekDayEnd);
        }
    }
}
