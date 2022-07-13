using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLab
{
    class Employee
    {
        int id;
        string name;
        DateTime dateOfBirth;
        decimal salary;
        long mobileNo;

        public DateTime DateOfJoining { get; set; }     //properties public int MyProperty { get; set; }

        public string Address { get; set; }
        //constructor to initialise the instance variable
        public Employee(int id, string name, DateTime dob, decimal salary, long mobileNo)        //ctor and two tab
        {
            this.id = id;
            this.name = name;
            dateOfBirth = dob;
            this.salary = salary;
            this.mobileNo = mobileNo;
        }

        public int CalculateAge()               //implementing the method tocalculate age
        {
            var age = DateTime.Today.Year - dateOfBirth.Year;
            return age;
        }

        public void Display()
        {
            Console.WriteLine($"Emp Id: {id}\n Name:{name}\n " +
                $"Date Of Birth: {dateOfBirth}\n Salary: {salary}\n " +
                $"Mobile Number: {mobileNo}\n Date of Joining:{DateOfJoining}\n" +
                $"Address: {Address}");
        }
    }
}
