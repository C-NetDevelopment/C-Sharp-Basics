using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{

    class Program
    {
        static void Main(string[] args)
        {
            /*Func<string, string, string> add = (string a1, string a2) => (a1 + a2);

            Func<int, int, int> addition = (int num1, int num2) =>
            {
                return num1 + num2;
            };

            string qa = add("hello ", "india");
            Console.WriteLine(qa);
            int sum = addition(55,5);
            Console.WriteLine(sum);

            Console.ReadLine();*/

            /*
            Action<int, int> add = (num1, num2) => Console.WriteLine($"Sum: {num1 + num2}");
            add(5,6);
            Console.ReadLine();
            */
             //double Area = r => 3.12 * r * r;

            Predicate<int> even = num =>
            {
                if (num % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            };
            bool isEven = even(11);
            if (isEven)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("odd");
            }
            Console.ReadLine();
        }
    }
}
