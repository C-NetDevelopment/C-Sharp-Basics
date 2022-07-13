using Customer.DAL;
using Customer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.BL
{
    public class CustomerBL
    {
        public static bool AddCustomer(CustomerClass customer)
        {
            bool isAdded = CustomerDal.AddCustomer(customer);
            return isAdded;
        }

        public static IEnumerable<CustomerClass> CustomerList()
        {
            return CustomerDal.CustomerList();
        }
    }
}
