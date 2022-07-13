using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;     //import class
//using static CSharp6.NewFeatures.Second;   //you can import class itself

namespace CSharp6.NewFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello");
            //sayHello();

            //object initializer
            Customer customer = new Customer();


            // collection initializer

            Dictionary<int, string> users = new Dictionary<int, string>
            {
                [1] = "Param",
                [2] = "Ketaki"
            };
            foreach (KeyValuePair<int, string> keyValuePair in users)
            {
                WriteLine();
            }

            //auto property initilizer


            //nameof Expression
            //nameof(number)
            HelloWorld();


            //await
            Customer cust = new Customer();
            var name = cust?.Name ?? "No nmae";
            WriteLine(name);

            ReadLine();
        }

        private static void HelloWorld()
        {
            WriteLine(nameof(HelloWorld));
        }
    }

   /* class Second
    {
        public static void sayHello()
        {
            WriteLine("Manners");
        }
    }*/
}
