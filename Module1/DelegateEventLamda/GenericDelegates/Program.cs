using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    public delegate T Myhandler<T>(T param1, T param2);
    class Program
    {
        static void Main(string[] args)
        {
            Myhandler<int> addHandler = Add;
            int sum = addHandler(20,20);
            Console.WriteLine(sum);
            Console.ReadKey();

            Program P = new Program();
            Myhandler<string> concateHandler = P.Concat;
            string result = concateHandler("Hello ","India");
            Console.WriteLine(result);

            Console.ReadKey();
        }

        private string Concat(string param1, string param2)
        {
            return param1 + param2;
        }

        private static int Add(int param1, int param2)
        {
            return param1 + param2;
        }
    }
}
