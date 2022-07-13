using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 Addition, 2 Subtraction, 3 Multiplication, 4 Devision, 5 Modulus");
            string input = Console.ReadLine();
            // int operation = Convert.ToInt32(input);
            if (int.TryParse(input, out int operation))
            {
                switch (operation)
                {
                    case 1:
                        Console.WriteLine("Enter the first Number");
                        input = Console.ReadLine();
                        decimal Num1 = Convert.ToDecimal(input);

                        Console.WriteLine("Enter the Second Number");
                        input = Console.ReadLine();
                        decimal Num2 = Convert.ToDecimal(input);

                        ArithmaticCalculator calcObj = new ArithmaticCalculator(Num1, Num2);
                        decimal Addition = calcObj.Addition();
                        Console.WriteLine($"The Addition of two Number is: {Addition}");
                        Console.Read();
                        break;
                    case 2:
                        Console.WriteLine("Enter the first Number");
                        input = Console.ReadLine();
                        Num1 = Convert.ToDecimal(input);

                        Console.WriteLine("Enter the Second Number");
                        input = Console.ReadLine();
                        Num2 = Convert.ToDecimal(input);

                        ArithmaticCalculator calcObj1 = new ArithmaticCalculator(Num1, Num2);
                        decimal Subtration = calcObj1.Subtract();
                        Console.WriteLine($"The Subtration of two Number is: {Subtration}");
                        Console.Read();
                        break;
                    case 3:
                        Console.WriteLine("Enter the first Number");
                        input = Console.ReadLine();
                        Num1 = Convert.ToDecimal(input);

                        Console.WriteLine("Enter the Second Number");
                        input = Console.ReadLine();
                        Num2 = Convert.ToDecimal(input);

                        ArithmaticCalculator calcObj2 = new ArithmaticCalculator(Num1, Num2);
                        decimal Multiplication = calcObj2.Multiplication();
                        Console.WriteLine($"The Multiplication of two Number is: {Multiplication}");
                        Console.Read();
                        break;
                    case 4:
                        Console.WriteLine("Enter the first Number");
                        input = Console.ReadLine();
                        Num1 = Convert.ToDecimal(input);

                        Console.WriteLine("Enter the Second Number");
                        input = Console.ReadLine();
                        Num2 = Convert.ToDecimal(input);

                        ArithmaticCalculator calcObj3 = new ArithmaticCalculator(Num1, Num2);
                        decimal Devision = calcObj3.Devision();
                        Console.WriteLine($"The Devision of two Number is: {Devision}");
                        Console.Read();
                        break;

                    case 5:
                        Console.WriteLine("Enter the first Number");
                        input = Console.ReadLine();
                        Num1 = Convert.ToDecimal(input);

                        Console.WriteLine("Enter the Second Number");
                        input = Console.ReadLine();
                        Num2 = Convert.ToDecimal(input);

                        ArithmaticCalculator calcObj4 = new ArithmaticCalculator(Num1, Num2);
                        decimal Modulus = calcObj4.Modulus();
                        Console.WriteLine($"The Modulus of two Number is: {Modulus}");
                        Console.Read();
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please Provide Valid input");
            }
            Console.ReadLine();
        }
    }
}
