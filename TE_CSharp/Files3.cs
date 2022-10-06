using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    internal class Files3
    {
        public static void Main()
        {
            string path = @"C:\Users\EI13059\Assignment1.txt";
            //copy
            string dest_path = @"C:\Users\EI13059\Assignment4.txt";
            string[] content;
            content = File.ReadAllLines(path);
            Console.WriteLine(content[0]);
            int option;
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1: Copy \n2: Move \n3. Delete");
            option = Convert.ToInt16(Console.ReadLine());
            switch (option)
            {
                case 1:File.Copy(path, dest_path);
                       Console.WriteLine("copied successfully");
                       break;
                case 2: File.Move(@"C:\Users\EI13059\Assignment2.txt", @"C:\Users\EI13059\Practice\Assignment2.txt");
                        Console.WriteLine("file moved successfully");
                        break;
                case 3: File.Delete(@"C:\Users\EI13059\Assignment4.txt");
                        Console.WriteLine("file deleted successfully");
                        break;
                default:Console.WriteLine("invalid");
                        break;
            }
          
        }
    }
}