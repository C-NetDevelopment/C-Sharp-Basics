using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1and4Question1and1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee[] employees =new ContractEmployee[10];
            int choice = 0;
            while (choice != 3)
            {
                Console.WriteLine("1. Add contract employee");
                Console.WriteLine("2. Add permanent employee");
                Console.WriteLine("3. Exit");
                Console.Write("Your choice: ");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            
                            for (int i = 0; i < employees.GetLength(0); i++)
                            {
                                Console.WriteLine("Enter Name of Employee");
                                employees[i].perk = Console.ReadLine();
                                Console.WriteLine("Enter address of Employee");
                                employees[i].address = Console.ReadLine();
                                Console.WriteLine("Enter City of Employee");
                                employees[i].city = Console.ReadLine();
                                Console.WriteLine("Enter address of Department");
                                employees[i].department = Console.ReadLine();
                                Console.WriteLine("Enter address of Salary");
                                employees[i].salary =double.Parse(Console.ReadLine());
                                ContractEmployee cemp = new ContractEmployee();
                                Console.WriteLine("Enter address of Perk");
                                
                            }
                            
                            
                        }
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Wrong menu item. Try again.");
                        break;
                }
            }
            Console.ReadLine();

        }
    }
}
