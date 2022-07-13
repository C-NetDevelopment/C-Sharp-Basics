using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssyncLab
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = Add(10, 30);
            Console.WriteLine(sum);

            var result = AddAsync(10, 20);
            Console.WriteLine(result.Result);
            Console.WriteLine("In main");

            Console.Read();
        }

        private static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        static async Task<int> AddAsync(int num1, int num2)
        {
            await Task.Delay(500);
            Console.WriteLine("In side Add Method");
            return num1 + num2;
        }
    }
}
