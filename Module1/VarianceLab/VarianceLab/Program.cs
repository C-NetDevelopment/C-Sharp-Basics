using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarianceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            Manager manager = new Manager();
            emp = manager;


            List<Manager> managerList = new List<Manager>();
            IEnumerable<Employee> employees = managerList;

            foreach (var m in managerList)
            {

            }

            Parallel.ForEach(managerList, m => Console.WriteLine(m));

            Parallel.for(0, managerList.Count, manager => {
                Console.WriteLine(manager)
            });
            {

            }
        }
    }
}
