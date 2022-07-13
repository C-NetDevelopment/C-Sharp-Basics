using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Select Your Favorite Car");
            Console.WriteLine("1 Oddi, 2 Bolero, 3 Swift, 4 Jeep, 5 RollesRoyel");
            string input = Console.ReadLine();
            //int choice = Convert.ToInt32(input);
            if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Your choice is odi");
                        break;
                    case 2:
                        Console.WriteLine("Your choice is Bolero");
                        break;
                    case 3:
                        Console.WriteLine("Your choice is swift");
                        break;
                    case 4:
                        Console.WriteLine("Your choice is jeep");
                        break;
                    case 5:
                        Console.WriteLine("Your choice is RollesRoyel");
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please Provide Valid input");
            }
            Console.ReadLine();
        }
    }
}
