using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Participent participant = new Participent();

            Console.WriteLine("Enter EmpId");
            participant.EmpId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            participant.Name = Console.ReadLine();

            Console.WriteLine("Enter Foundation Marks");
            participant.FoundationMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Web Basic MArks");
            participant.WebBasicMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter .Net Marks");
            participant.DotNetMarks = int.Parse(Console.ReadLine());

              participant.CalculateTotalMarks();

            participant.CalculatePercentage();

            Console.WriteLine("Employee Percentage is:");
            Console.Write(participant.ShowPercentage());
            Console.ReadKey();


            Console.ReadLine();
            
        }
    }
}
