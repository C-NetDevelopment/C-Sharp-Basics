using EMS.BL;
using EMS.Entities;
using EMS.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EMS.PL
{
    class Program
    {
        static void Main(string[] args)
        {

            do
            {
                Console.WriteLine("Employee Managemant System");
                Console.WriteLine("1. Add Department\n" + 
                                  "2. List Department\n" + 
                                  "3. Add Employee\n" + 
                                  "4. List Employee\n" + 
                                  "5. UpdateEmployee\n" + 
                                  "6. Delete Employee \n" + 
                                  "7. SearchEmployee\n" +
                                  "8. Update Department\n" +
                                  "9. Delete Department\n" +
                                  "10. Emplyee By Department\n" +
                                  "11. Employee Details\n" +
                                  "12. Exit\n");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddDepartment();
                            break;
                        case 2:
                            ListDepartments();
                            break;
                        case 3:
                            AddEmployee();
                            break;
                        case 4:
                            ListEmployee();
                            break;
                        case 5:
                            UpdateEmployee();
                            break;
                            case 6:
                            DeleteEmployee();
                            break;
                        case 7:
                            SearchEmployee();
                            break;
                        case 8:
                            UpdateDepartment();
                            break;
                        case 9:
                            DeleteDepartment();
                            break;
                        case 10:
                            EmpByDepartment();
                            break;
                        case 11:
                            EmpDetail();
                            break;
                        case 12:
                            EMSBL.SerializeData();
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
            } while (true);
        }

        private static void EmpDetail()
        {
            Console.WriteLine("Enter Employee Id:");
            string EmpId = Console.ReadLine();
            IEnumerable<Employee> list = EMSBL.EmpDetail(EmpId);
            if (list.Count() == 0)
            {
                Console.WriteLine("Employee Not Found");
            }
            else
            {
                foreach (var employee in list)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        private static void EmpByDepartment()
        {
            Console.WriteLine("Enter Department Id");
            int deptId = int.Parse(Console.ReadLine());
            IEnumerable<Employee> list = EMSBL.EmpByDepartment(deptId);
            if (list.Count() == 0)
            {
                Console.WriteLine("Department Not Found");
            }
            else
            {
                foreach (var employee in list)
                {
                    Console.WriteLine(employee);
                }
            }
        }

        private static void SearchEmployee()
        {
            Console.WriteLine("Enter Employee Id, name, Email OR DateOfJoining");
            string criteria = Console.ReadLine();
            IEnumerable<Employee> list = EMSBL.SearchEmployee(criteria);
            if (list.Count() == 0)
            {
                Console.WriteLine("Employee Not Found");
            }
            else
            {
                foreach (var employee in list)
                {
                    Console.WriteLine(employee);
                }
            }
            
        }

        private static void DeleteDepartment()
        {
            Console.WriteLine("Enter Department ID");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int dId))
            {
                try
                {
                    bool isDeleted = EMSBL.DeleteDepartment(dId);
                    if (isDeleted)
                    {
                        Console.WriteLine("department Delete Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Delete Failed");
                    }
                }
                catch (EmsExceptions ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }
        private static void DeleteEmployee()
        {
            Console.WriteLine("Enter Employee ID");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int empId))
            {
                try
                {
                    bool isDeleted = EMSBL.DeleteEmployee(empId);
                    if (isDeleted)
                    {
                        Console.WriteLine("Epm Delete Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Delete Failed");
                    }
                }
                catch (EmsExceptions ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        private static void UpdateDepartment()
        {
            Console.WriteLine("Enter Department Id");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int dId))
            {
                bool isExist = EMSBL.DepartmentExist(dId);
                if (isExist)
                {
                    Department department = new Department();
                    department.DepartmentId = dId;
                    Console.WriteLine("Enter new Department Name ");
                    department.DepartmentName = Console.ReadLine();

                    try
                    {
                        bool isUpdated = EMSBL.UpdateDepartment(department);
                        if (isUpdated)
                        {
                            Console.WriteLine("Department updated successfully");
                        }
                        else
                        {
                            Console.WriteLine("Department update fail");
                        }
                    }
                    catch (EmsExceptions ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Deparment Not Exist");
                }
                
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

        }
        private static void UpdateEmployee()
        {
            Console.WriteLine("Enter Employee Id");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int empId))
            {
                bool isEmpExist = EMSBL.EmployeeExist(empId);
                if (isEmpExist)
                {
                    //update
                    Employee emp = new Employee();
                    emp.Id = empId;            //imp
                    Console.WriteLine("Enter Name");
                    emp.Name = Console.ReadLine();
                    Console.WriteLine("Enter DateOf Joining");
                    input = Console.ReadLine();
                    if (DateTime.TryParse(input, out DateTime doj))
                    {
                        emp.DateOfJoining = doj;
                    }
                    else
                    {
                        Console.WriteLine("Invalid date");
                    }

                    Console.WriteLine("Enter Salary");
                    input = Console.ReadLine();
                    if (decimal.TryParse(input, out decimal salary))
                    {
                        emp.Salary = salary;
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }

                    Console.WriteLine("Enter Email");
                    input = Console.ReadLine();
                    Regex regex = new Regex("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");

                    if (regex.IsMatch(input))
                    {
                        emp.Email = input;
                    }
                    else
                    {
                        Console.WriteLine("Invalid email");
                    }

                    Console.WriteLine("Enter Gender");
                    input = Console.ReadLine();
                    if (Enum.TryParse(input, out Gender gender))
                    {
                        emp.Gender = gender;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Gender");
                    }
                    Console.WriteLine("Enter Hobby");
                    input = Console.ReadLine();
                    if (Enum.TryParse(input, out Hobbies hobby))
                    {
                        emp.Hobbies = hobby;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Hobby");
                    }

                    Console.WriteLine("Enter Department Id");
                    input = Console.ReadLine();
                    if (int.TryParse(input, out int deptId))
                    {
                        emp.DepartmentId = deptId;
                    }
                    else
                    {
                        Console.WriteLine("invalid input");
                    }
                    try
                    {
                        bool isUpdated = EMSBL.UpdateEmployee(emp);
                        if (isUpdated)
                        {
                            Console.WriteLine("Employee updated successfully");
                        }
                        else
                        {
                            Console.WriteLine("Employe update fail");
                        }
                    }
                    catch (EmsExceptions ex)
                    {

                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    Console.WriteLine("Employee Not Exist With This Id");
                }
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }

        private static void ListEmployee()
        {
            IEnumerable<Employee> list = EMSBL.EmployeeList();
            foreach (var emp in list)
            {
                Console.WriteLine(emp);
            }
        }

        private static void AddEmployee()
        {
            Employee emp = new Employee();
            Console.WriteLine("Enter Name");
            emp.Name = Console.ReadLine();
            Console.WriteLine("Enter DateOf Joining");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out DateTime doj))
            {
                emp.DateOfJoining = doj;
            }
            else
            {
                Console.WriteLine("Invalid date");
            }

            Console.WriteLine("Enter Salary");
            input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal salary))
            {
                emp.Salary = salary;
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            Console.WriteLine("Enter Email");
            input = Console.ReadLine();
            Regex regex = new Regex("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$");

            if (regex.IsMatch(input))
            {
                emp.Email = input;
            }
            else
            {
                Console.WriteLine("Invalid email");
            }

            Console.WriteLine("Enter Gender");
            input = Console.ReadLine();
            if (Enum.TryParse(input, out Gender gender))
            {
                emp.Gender = gender;
            }
            else
            {
                Console.WriteLine("Invalid Gender");
            }
            Console.WriteLine("Enter Hobby");
            input = Console.ReadLine();
            if (Enum.TryParse(input, out Hobbies hobby))
            {
                emp.Hobbies = hobby;
            }
            else
            {
                Console.WriteLine("Invalid Hobby");
            }

            Console.WriteLine("Enter Department Id");
            input = Console.ReadLine();
            if (int.TryParse(input, out int deptId))
            {
                emp.DepartmentId = deptId;
            }
            else
            {
                Console.WriteLine("invalid input");
            }

            try
            {
                bool isAdded = EMSBL.AddEmployee(emp);
                if (isAdded)
                {
                    Console.WriteLine("Emp Added Successfully");
                }
                else
                {
                    Console.WriteLine("emp failed");
                }
            }
            catch (EmsExceptions ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void ListDepartments()
        {
            IEnumerable<Department> list = EMSBL.DepartmentList();
            foreach (var dept in list)
            {
                Console.WriteLine(dept);
            }
        }

        private static void AddDepartment()
        {
            Console.WriteLine("Enter Department Name");
            string departmentName = Console.ReadLine();

            Department department = new Department
            {
                DepartmentName = departmentName
            };

            try
            {
                bool isAdded = EMSBL.AddDepartment(department);
                if (isAdded)
                {
                    Console.WriteLine("Dept added successfully");
                }
                else
                {
                    Console.WriteLine("Add Dept Fail");
                }
            }
            catch (EmsExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
