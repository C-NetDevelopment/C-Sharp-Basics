using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12Question2
{
    class Program
    {
       
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter File Path");
            string input = Console.ReadLine();
            Console.WriteLine("Enter File Path");
            string input1 = Console.ReadLine();

            string Path = @"D:\Lab\" + input;

            string line = "";
            using (StreamReader sr = new StreamReader(Path))
            {
                line = sr.ReadToEnd();
            }

            string Path1 = @"D:\Lab\" + input1;
            using (StreamWriter sw = new StreamWriter(Path1))
            {
                sw.Write(line);
            }
        }
    }
}
