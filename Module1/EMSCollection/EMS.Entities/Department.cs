using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public string DepartmentName { get; set; }

        public override string ToString()
        {
            return $"ID: {DepartmentId},  Name: {DepartmentName}";

        }
    }
}
