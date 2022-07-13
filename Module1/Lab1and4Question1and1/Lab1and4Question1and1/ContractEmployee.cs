using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1and4Question1and1
{
    class ContractEmployee : Employee
    {
        
        public double Perks;

        public ContractEmployee()
        {
        }

        public ContractEmployee(double perk, string name, string address, string city, string department, double salary)
            : base(name, address, city, department, salary)
        {
            this.Perks = perk;
        }
        public override double GetSalary()
        {
            return salary + Perks;
        }
    }
}
