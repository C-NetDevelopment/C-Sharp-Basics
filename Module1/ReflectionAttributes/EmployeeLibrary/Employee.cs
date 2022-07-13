using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Employee
    {
        public int Id { get; set; }
        public int Name { get; set; }

        public bool Add(int id, string name)
        {
            return true;
        }
    }
}
