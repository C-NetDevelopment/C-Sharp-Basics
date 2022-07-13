using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Question4
{
    class SupplierTest
    {
        static void Main(string[] args)
        {
            Supplier supplier = new Supplier();

            supplier.AcceptDetails();
            supplier.DisolayDetails();
            Console.Read();
        }
    }
}
