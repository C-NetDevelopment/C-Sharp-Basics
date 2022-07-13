using BussinessLayer;
using ExceptionLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BussinessClass.Method1();
            }
            catch (MyCustomException ex)
            {
                System.Console.WriteLine();
                
            }
            Console.Read();
        }
    }
}
