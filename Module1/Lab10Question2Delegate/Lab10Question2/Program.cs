using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Question2
{
    public delegate decimal opdelegate(decimal num1, decimal num2);
    class Program
    {
        static void Main(string[] args)
        {
            opdelegate Operation = (decimal num1, decimal num2) => num1 + num2;

            PerformArithmeticOperation(20, 10, Operation);
            Console.ReadLine();
        }
        static void PerformArithmeticOperation(int num1, int num2, opdelegate arOperation)
        {
            var result = arOperation(num1, num2);
            Console.WriteLine(result);
        }
        
    }
}
