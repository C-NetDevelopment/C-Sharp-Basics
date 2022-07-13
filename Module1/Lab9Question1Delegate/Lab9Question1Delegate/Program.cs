using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Question1Delegate
{
    public delegate void Delegateoperation(decimal num1, decimal num2);
    class Program
    {
        static void Main(string[] args)
        {
            //ArithMaticOperation opertn = new ArithMaticOperation();
            
            do
            {
                Console.WriteLine("1. Add\n" +
                                  "2. Subtract\n" +
                                  "3. Multiply\n" +
                                  "4. Devision\n" +
                                  "5. Max Number\n" +
                                  "6. Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter num1");
                            decimal num1 = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter num2");
                            decimal num2 = decimal.Parse(Console.ReadLine());
                            Delegateoperation operation1 = new Delegateoperation(ArithMaticOperation.Add);
                            operation1(num1,num2);
                            break;
                        case 2:
                            Console.WriteLine("Enter num1");
                            num1 = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter num2");
                            num2 = decimal.Parse(Console.ReadLine());
                            Delegateoperation operation2 = new Delegateoperation(ArithMaticOperation.Substract);
                            operation2(num1, num2);
                            break;
                        case 3:
                            Console.WriteLine("Enter num1");
                             num1 = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter num2");
                             num2 = decimal.Parse(Console.ReadLine());
                            Delegateoperation operation3 = new Delegateoperation(ArithMaticOperation.Multiply);
                            operation3(num1, num2);
                            break;
                        case 4:
                            Console.WriteLine("Enter num1");
                             num1 = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter num2");
                             num2 = decimal.Parse(Console.ReadLine());
                            Delegateoperation operation4 = new Delegateoperation(ArithMaticOperation.Devision);
                            operation4(num1, num2);
                            break;
                        case 5:
                            Console.WriteLine("Enter num1");
                             num1 = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Enter num2");
                             num2 = decimal.Parse(Console.ReadLine());
                            Delegateoperation operation5 = new Delegateoperation(ArithMaticOperation.MaxNumber);
                            operation5(num1, num2);
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);

        }
    }
}
