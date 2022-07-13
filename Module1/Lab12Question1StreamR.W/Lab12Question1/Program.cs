using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Question1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter File Path");
            string input = Console.ReadLine();
                
            string Path = @"D:\Lab\"+ input;

            try
            {
                 Path = @"D:\Lab\" + input;
            }
            catch (Exception)
            {

                throw new FileNotFoundException("File not Found");
                
            }
            try
            {
                using (FileStream stream = new
                    FileStream(Path, FileMode.Create, FileAccess.Write))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine("Hello World");
                        writer.WriteLine("Welcome to Capgemini");
                    }
                }
            }
            catch (Exception ex)
            {

                throw new IOException(ex.Message); ;
            }


            try
            {
                using (FileStream stream = new
                   FileStream(Path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        
                        while (!reader.EndOfStream)
                        {
                            Console.WriteLine(reader.ReadLine());
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw new FileNotFoundException("File Not Found");
            }
            Console.ReadLine();
        }
    }
}
