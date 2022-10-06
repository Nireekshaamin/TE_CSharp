using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TE_CSharp
{
    public class Files1
    {
        public void Write()
        {
            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13059\Assignment1.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamWriter writer = new StreamWriter(fileStream);
            try
            {
               for(int i=1; i<=10; i++)
                {
                    for(int j=1; j<= 10; j++)
                    {
                        writer.Write((i * j)+ "\t");
                    } 
                    writer.WriteLine();
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                writer.Close();
                fileStream.Close();
            }

        }
      
        public void read()
        {

            FileInfo fileInfo = new FileInfo(@"C:\Users\EI13059\Assignment1.txt");
            FileStream fileStream = fileInfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            StreamReader reader = new StreamReader(fileStream);
            try
            {
                string contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                reader.Close();
                fileStream.Close();
            }

        }
    
        }
        internal class Files
        {
            public static void Main()
            {
                Files1 demo = new Files1();
                demo.Write();
                demo.read();
            }
        }
    
}