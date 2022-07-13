using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public decimal Salary { get; set; }

        public string Email { get; set; }
        public Gender Gender { get; set; }
        public Hobbies Hobbies { get; set; }

        public int DepartmentId { get; set; }
        public override string ToString()
        {
            return $"ID: {Id}, {Name}, {DateOfJoining}, {Gender},{Hobbies},{Email},{DepartmentId}";

        }
    }
}
