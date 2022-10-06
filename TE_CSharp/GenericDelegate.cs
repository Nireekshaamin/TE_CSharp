using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class GenericDelegate
    {
        // Declaring Generic Delegate
        public delegate T SampleDelegate<T>(T a);
        class MathOperations
        {
            int piValue=Convert.ToInt16(3.14);
            double pi = 3.14;
            //integer value
            public int AreaOfSquare(int a)
            {

                return (a*a);
            }
            public int AreaOfCube(int x)
            {
                return (6 * x * x);
            }
            public int AreaOfCircle(int r)
            {
                return (piValue*r * r);
            }
            //double value
            public double AreaOfSquare(double a)
            {
                return (a * a);
            }
            public double AreaOfCube(double x)
            {
                return (6 * x * x);
            }
            public double AreaOfCircle(double r)
            {
                
                return (pi* r * r);
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                
                MathOperations m = new MathOperations();
                // Instantiate delegate with AreaOfSquare method using int
                SampleDelegate<int> dlgt = new SampleDelegate<int>(m.AreaOfSquare);
                Console.WriteLine("Area of square int: " + dlgt(10));
                // Instantiate delegate with AreaOfCube method
                dlgt = m.AreaOfCube;
                Console.WriteLine("Area of cube for int: " + dlgt(100));
                // Instantiate delegate with AreaOfCircle method
                dlgt = m.AreaOfCircle;
                Console.WriteLine("Area of circle for int " + dlgt(100));

                // Instantiate delegate with AreaOfSquare method
                SampleDelegate<double> dlgt1 = new SampleDelegate<double>(m.AreaOfSquare);
                Console.WriteLine("Area of square for double " + dlgt1(10.6));
                // Instantiate delegate with AreaOfCube method
                dlgt1 = m.AreaOfCube;
                Console.WriteLine("Area of cube for double: " + dlgt1(10.2));
                // Instantiate delegate with AreaOfCircle method
                dlgt1 = m.AreaOfCircle;
                Console.WriteLine("Area of cicle for double: " + dlgt1(8.2));
                Console.ReadLine();
            }
        }
    }
}