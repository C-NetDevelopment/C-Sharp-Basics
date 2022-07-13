using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Question1
{
    class Employee
    {
        private string name;
        private string address;
        private string city;
        private string department;
        private double salary;

        public string Name { get { return name ; } set {  name = value; } }
        public string Address { get { return address; } set { address = value; } }

        public string City { get { return city; } set { city = value; } }
        public string Department { get { return department; } set { department = value; } }

        public double Salary { get { return salary; } set { salary = value; } }
        
        
    }
}
