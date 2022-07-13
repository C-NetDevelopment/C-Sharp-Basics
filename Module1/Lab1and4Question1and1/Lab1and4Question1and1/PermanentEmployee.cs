using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1and4Question1and1
{
   class PermanentEmployee : Employee
    {
       
        private int NoOfLeaves;
        private double ProvidendFund { get; set; }
        public PermanentEmployee() { }
        public PermanentEmployee(int noOfLeaves, double providendFund, string name, string address, string city, string department, double salary)
            : base(name, address, city, department, salary)
        {
            this.NoOfLeaves = noOfLeaves;
            this.ProvidendFund = providendFund;
        }
        public override double GetSalary()
        {
            return salary - ProvidendFund;
        }
    }
}
