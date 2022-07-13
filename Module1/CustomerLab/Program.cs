using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer custObj = new Customer();
            custObj.Id = 001;
            custObj.Name = "Sona";
            custObj.City = City.Gandhinagar;
        }

        Customer customer2 = new Customer
        {
            Id = 2,
            Name = "Param",
            City = City.Mumbai

        };
        var employee = new {Id = =1, Name="Saurabh", City}
        }
    }
}
