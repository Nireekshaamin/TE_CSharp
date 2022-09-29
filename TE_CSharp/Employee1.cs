using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    
    internal class Employee1
    {
        public static void Main()
        {
            int id;
            string name;
            string dep;
            EmployeeDetails(out id,out name,out dep);
            Console.WriteLine("Student Id is "+id + "\nStudent name is " +name+"\nStudent department is "+dep);
        }
        public static void EmployeeDetails(out int sid,out string sname,out string sdep)
        {
            sid = 1;
            sname = "harry";
            sdep = "cs";
        }
        
    }
}
