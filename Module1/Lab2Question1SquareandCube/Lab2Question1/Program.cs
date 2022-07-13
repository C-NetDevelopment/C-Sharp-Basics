using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question1
{
    class Program
    {
        decimal number;
        public Program(decimal number)
        {
            this.number = number;
        }

       public decimal Square()
        {
            return number * number;
        }
        public decimal Cube()
        {
            return number * number * number;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Operation");
            Console.WriteLine("1 Square, 2 Cube");
            string input = Console.ReadLine();
            //int operation = Convert.ToInt32(input);

            if (int.TryParse(input, out int operation))
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Please Enter The Number");
                        input = Console.ReadLine();
                        decimal number1 = Convert.ToDecimal(input);
                        Program task1 = new Program(number1);
                        Console.WriteLine(task1.Square());
                        Console.Read();
                        break;

                    case 2:
                        Console.WriteLine("Please Enter The Number");
                        input = Console.ReadLine();
                        decimal number2 = Convert.ToDecimal(input);
                        Program task2 = new Program(number2);
                        Console.WriteLine(task2.Cube());
                        
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
                
            }
            else
            {
                Console.WriteLine("Please Provide valid input");
            }
            Console.ReadLine();
        }
    }
}
