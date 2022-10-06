using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    
    public class Employee1
    {
        public static void Main()
        {
            int id;
            string name;
            string dep;
            Employee1 emp=new Employee1();
            emp.EmployeeDetails(out id,out name,out dep);
            Console.WriteLine("Student Id is "+id + "\nStudent name is " +name+"\nStudent department is "+dep);
        }
        public void EmployeeDetails(out int sid,out string sname,out string sdep)
        {
            sid = 1;
            sname = "harry";
            sdep = "cs";
        }
        public void sum()
        {
            int s, a, b;
            a = 10;
            b = 20;
            s = a + b;
            Console.WriteLine(s);
        }
        
    }
}
