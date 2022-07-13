using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = ConfigurationManager.AppSettings["File2Path"];

            try
            {
                //stream
                //filestream
                //streamwriter
                //streamreader
                /*using (FileStream stream =new 
                    FileStream(path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine("Hello World");
                        writer.WriteLine("Welcome to Capgemini");
                    }
                }*/

                /*if (File.Exists(path))
                {

                } 
                

                using (FileStream stream = new
                    FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        
                        while (!reader.EndOfStream)
                        {
                            Console.WriteLine(reader.ReadLine());
                        }
                    }
                }*/
                Console.WriteLine("Enter text");
                string data = Console.ReadLine();


                File.WriteAllText(path, "Hello Capgemini");   //00000000000000

            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine("Done");


            Console.Read();
        }
    }
}
