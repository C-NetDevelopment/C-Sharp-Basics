using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLab      // package/folder 
{
    class Program     //Base class
    {
        static void Main(string[] args)         //main method
        {
            Console.WriteLine("Enter Employee Id");             //taking input from user
            string input = Console.ReadLine();
            int id = Convert.ToInt32(input);                    //convert it into integer

            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Date of birth");
            input = Console.ReadLine();
            DateTime dateOfBirth = Convert.ToDateTime(input);

            Console.WriteLine("Enter Salary");
            input = Console.ReadLine();
            decimal salary = Convert.ToDecimal(input);

            Console.WriteLine("Enter Mobile NUmber");
            input = Console.ReadLine();
            long mobileNo = Convert.ToInt64(input);

            Employee emp = new Employee(id, name, dateOfBirth,
                salary, mobileNo);     // creating object of base class

            Console.WriteLine("Enter Address");
            emp.Address = Console.ReadLine();

            Console.WriteLine("Enter date of joining");
            input = Console.ReadLine();
            emp.DateOfJoining = Convert.ToDateTime(input);

            Console.WriteLine($"Age is : {emp.CalculateAge()}");    //calling CalculateAge method to dispaly age

            emp.Display();                  // dispaly method
            Console.ReadLine();

        }
    }
}
