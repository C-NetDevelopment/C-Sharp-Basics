using EmployeeManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7Question3
{
    class Program
    {
        static List<Employee> employeeList = new List<Employee>();
        static Employee employee = new Employee();
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Employee MnageMent System");
                Console.WriteLine("1. Add Employee\n" +
                                  "2. Search Employee\n" +
                                  "3. Delete Employee\n" +
                                  "4. Display Employees\n" +
                                  "5. Exit");
                string input = Console.ReadLine();
                if (int.TryParse(input,out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddEmployee(employee);
                            break;
                        case 2:
                            SearchEmployee(employee);
                            break;
                        case 3:
                            Deleteployee(employee);
                            break;
                        case 4:
                            DisplayEmployee(employee);
                            break;
                        default:
                            break;
                    }
                }
            } while (true);
        }

        private static void DisplayEmployee(Employee employee)
        {
            foreach (var emp in employeeList)
            {
                Console.WriteLine(emp);
            }
        }

        private static void Deleteployee(Employee employee)
        {
            Console.WriteLine("Enter Employee ID");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int empId))
            {
                var isExist = employeeList.Find(e => e.EmpNo == empId);
                if (isExist == null)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    employeeList.Remove(isExist);
                }
            }
            else
            {
                Console.WriteLine("Invslid Input");
            }
        }

        private static void SearchEmployee(Employee employee)
        {
            Console.WriteLine("Enter Employee ID");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int empId))
            {
                var isExist = employeeList.Find(e => e.EmpNo == empId);
                if (isExist ==null)
                {
                    Console.WriteLine("Record Not Found");
                }
                else
                {
                    Console.WriteLine(isExist);
                }
            }
            else
            {
                Console.WriteLine("Invslid Input");
            }
        }

        private static void AddEmployee(Employee employee)
        {
            Console.WriteLine("Enter Employee ID");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int empid))
            {
                employee.EmpNo = empid;

                Console.WriteLine("Enter Employee Name");
                employee.EmpName = Console.ReadLine();

                Console.WriteLine("Enter Employee Salary");
                input = Console.ReadLine();
                if (double.TryParse(input, out double empSalary))
                {
                    employee.Salary = empSalary;

                    Console.WriteLine("Enter Monthly PF ");
                    employee.PF = double.Parse(Console.ReadLine());

                    employeeList.Add(employee);
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
    }
}
