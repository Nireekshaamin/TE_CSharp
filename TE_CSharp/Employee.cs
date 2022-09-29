using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Employee
    {
        public static void Main()
        {
            Console.WriteLine("Enter the no of employees");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <=n; i++)
            {
                Console.WriteLine("Enter the details of employee "+i);
                EmployeeDetails();
            }
        }
        public static void EmployeeDetails()
        {
            int empId;
            Console.WriteLine("Enter employee ID");
            empId  = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee name");
            string empName=(Console.ReadLine());
            Console.WriteLine("Enter employee age");
            int empAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter employee department");
            string department =Console.ReadLine();
            Employee emp = new Employee();
            emp.DisplayEmployee(empId,empName,empAge,department);
        }
        public void DisplayEmployee(int id,string name,int age,string dept)
        {
            Console.WriteLine("Employee ID is "+id+ "\nEmployee name is " + name+"\nEmployee age is "+age+"\nEmployee department is "+dept);
        }
    }
}
