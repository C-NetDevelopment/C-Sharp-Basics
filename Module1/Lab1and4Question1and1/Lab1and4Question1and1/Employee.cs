using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1and4Question1and1
{
    abstract class Employee
    {

        public string name;
        public string address;
        public string city;
        public string department;
        public double salary;
        internal string perk;

        public Employee() { }
        public Employee(string name, string address, string city, string department, double salary)
        {
            this.name = name;
            this.address = address;
            this.city = city;
            this.department = department;
            this.salary = salary;
        }
        public abstract double GetSalary();

    }
}
