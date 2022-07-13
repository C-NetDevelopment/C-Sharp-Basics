using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    public delegate void OperationHandler(decimal num1, decimal num2);  //declarn or define of delegate
    class Program
    {

        static void Main(string[] args)
        {

            Func<int, int, int> addition = (num1, num2) => num1 + num2;

            Func<int, int, int> addition1 = (num1, num2) =>
            {
                return num1 + num2;

            };

            int sum = addition(50,20);
            Console.WriteLine(sum);

            int result = addition1(50,90);
            Console.WriteLine(result);

            Console.ReadLine();

            /*
            // instance
            OperationHandler handler = new OperationHandler(MathOps.Add);
            //handler(20,50);

            handler += MathOps.Substract;
            handler(50,40);

            OperationHandler handler2 = delegate (decimal num1, decimal num2)
            {
                Console.WriteLine($"sum: {num1 + num2}");
            };

            handler2(20,30);
            Console.ReadLine();
            */
        }
    }
}
