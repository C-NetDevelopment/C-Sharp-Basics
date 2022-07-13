using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We have to Store City Name in the Array");
            Console.WriteLine("Please Enter the Number of cities You Want to store");
            int size = int.Parse(Console.ReadLine());

            string[] Citeis = new string[size];
            for (int i = 0; i < Citeis.Length; i++)
            {
                Console.WriteLine($"Please Enter the Name of {i+1} city");
                string city = Console.ReadLine();
                Citeis[i] = city;
            }

            Console.WriteLine("-----Your Entered Citeis are-----");
            foreach (string city in Citeis)
                Console.WriteLine($"} {city}");
           
            Console.ReadLine();
        }
    }
}
