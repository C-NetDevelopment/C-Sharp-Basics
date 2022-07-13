using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Question4
{
    class StudentRecord
    {
        decimal rollNumber;
        string nameOfStudent;
        decimal age;
        DateTime dateOfBirth;
        string address;
        decimal percentage;

        public StudentRecord(decimal rollNumber,string nameOfStudent,decimal age,DateTime dateOfBirth,
        string address,decimal percentage)
        {
            this.rollNumber = rollNumber;
            this.nameOfStudent = nameOfStudent;
            this.age = age;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
            this.percentage = percentage;
        }

        public void printInfo()
        {
            Console.WriteLine("Student Record: ");
            Console.WriteLine("\tRoll Number     : " + rollNumber);
            Console.WriteLine("\tName     : " + nameOfStudent);
            Console.WriteLine("\tAge     : " + age);
            Console.WriteLine("\tDate of Birth     : " + dateOfBirth);
            Console.WriteLine("\tAddress   : " + address);
            Console.WriteLine("\tPercentage      : " + percentage);
        }
    }

}
