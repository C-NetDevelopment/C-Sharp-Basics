using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Question1
{
    class Program
    {
        static void Main(string[] args)         //main method
        {
            Employee[] employees = new Employee[10];
            for (int i = 0; i < employees.Length; i++)
            {

                employees[i] = new Employee();
                Console.WriteLine($"Details of {i+1} Employee");
                Console.Write("Enter Employee Name: ");
                employees[i].Name = Console.ReadLine();
                Console.Write("Enter Employee Address: ");
                employees[i].Address = Console.ReadLine();
                Console.Write("Enter Employee City: ");
                employees[i].City = Console.ReadLine();
                Console.Write("Enter Employee Department: ");
                employees[i].Department = Console.ReadLine();
                Console.Write("Enter Employee Salary: ");
                employees[i].Salary = double.Parse(Console.ReadLine());
               
                
            }




            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine("----------Employee Record-----------");
                Console.WriteLine("\nEmployee {0}", (i + 1));
                Console.WriteLine("Employee Name: {0}", employees[i].Name);
                Console.WriteLine("Employee Address: {0}", employees[i].Address);
                Console.WriteLine("Employee City: {0}", employees[i].City);
                Console.WriteLine("Employee Department: {0}", employees[i].Department);
                Console.WriteLine("Employee Salary: {0}\n", employees[i].Salary.ToString("C"));
            }
            Console.ReadLine();

            
        }
    }
}
