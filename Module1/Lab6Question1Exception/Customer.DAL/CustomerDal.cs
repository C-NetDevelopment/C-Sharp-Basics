using Customer.Entities;
using CustomerException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.DAL
{
    public class CustomerDal
    {
        
        static List<CustomerClass> customerList = new List<CustomerClass>();
        static int custCounter = 1;

        public static bool AddCustomer(CustomerClass customer)
        {
            
            CustomerClass existCustomer = customerList.FirstOrDefault(e =>
                                    e.Phone == customer.Phone);

            double credit = (double)customer.CreditLimit;
            if (credit == 0)
            {
                throw new MyCustomException("Credit Not Valid");
            }
            if (existCustomer == null)
            {
                customer.CustId = custCounter++;
                customerList.Add(customer);
                return true;
            }
            else
            {
                throw new MyCustomException("Employee Already exist");
            }
        }

        public static IEnumerable<CustomerClass> CustomerList()
        {
            return customerList;
        }
    }
}
