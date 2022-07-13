using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have to store info in 2D array");

            Console.WriteLine("Please Enter the number of row");
            int row = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter the number of column");
            int col = int.Parse(Console.ReadLine());


            int[,] myArray = new int[row, col];
            {
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        Console.WriteLine("Please Enter Element for location: " + (j + 1));

                        myArray[i, j] = int.Parse(Console.ReadLine());
                    }

                }

                Console.WriteLine("-------------Data---------------");

                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); j++)
                    {
                        Console.Write(myArray[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
            }
        }
    }
}
