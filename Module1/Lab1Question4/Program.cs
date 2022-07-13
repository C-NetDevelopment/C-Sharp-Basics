using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Question4
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentRecord[] record = new StudentRecord[2];
            for (int i = 0; i < 2; i++)
            {
                int count = i + 1;
                Console.WriteLine($"Enter Record of {count} Student");
                Console.WriteLine("Enter Student's Roll Number :");
                string input = Console.ReadLine();
                decimal rollNumber = Convert.ToDecimal(input);

                Console.WriteLine("Enter Student's Name:");
                string nameOfStudent = Console.ReadLine();
                
                Console.WriteLine("Enter Student's Age :");
                input = Console.ReadLine();
                decimal age = Convert.ToDecimal(input);

                Console.WriteLine("Enter Date of birth");
                input = Console.ReadLine();
                DateTime dateOfBirth = Convert.ToDateTime(input);

                Console.WriteLine("Enter Student's Address:");
                string address = Console.ReadLine();

                Console.WriteLine("Enter Student's Percentage :");
                input = Console.ReadLine();
                decimal percentage = Convert.ToDecimal(input);
                StudentRecord recObj = new StudentRecord(rollNumber, nameOfStudent, age, dateOfBirth,
        address, percentage);
                recObj.printInfo();
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
