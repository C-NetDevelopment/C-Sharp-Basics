using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Question1Delegate
{
    class ArithMaticOperation
    {
        public static void Add(decimal num1, decimal num2)
        {
            Console.WriteLine("Addition is : " + (num1 + num2));
        }

        public static void Substract(decimal num1, decimal num2)
        {
            Console.WriteLine("Substract is: " + (num1 - num2));
        }
        public static void Multiply(decimal num1, decimal num2)
        {
            Console.WriteLine("Multiply is: " + (num1 * num2));
        }
        public static void Devision(decimal num1, decimal num2)
        {
            Console.WriteLine("Devision is: " + (num1 / num2));
        }
        public static void MaxNumber(decimal num1, decimal num2)
        {
            if (num1>num2)
            {
                Console.WriteLine("Number one is greater than number two");
            }
            else
            {
                Console.WriteLine("Number two is greater than number one");
            }
        }
    }
}
