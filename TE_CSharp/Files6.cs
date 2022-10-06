using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Files7
    {
        

        public void read1()
        {
            string fileName = @"C:\Users\EI13059\Assignment1.txt";
            int count = 0;
            StreamReader sr = File.OpenText(fileName);
            try
            {
                string s = "";
                count = 0;
                Console.WriteLine("The file contents");
                while ((s = sr.ReadLine()) != null)
                    {
                    
                    Console.WriteLine(s);
                        count++;
                    }
                    Console.WriteLine("");
                
                Console.Write(" The number of lines in  the file {0} is : {1} \n\n", fileName, count);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sr.Close();
            }

        }

    }
    internal class Files6
    {
        public static void Main()
        {
            Files7 demo = new Files7();
            
            demo.read1();
        }
    }

}