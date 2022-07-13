using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    class MathOps
    {
        public static void Add(decimal num1, decimal num2)
        {
            Console.WriteLine("Addition is : " + (num1 + num2));
        }

        public static void Substract(decimal num1, decimal num2)
        {
            Console.WriteLine("Substract is: " + (num1 - num2));
        }
    }
}
