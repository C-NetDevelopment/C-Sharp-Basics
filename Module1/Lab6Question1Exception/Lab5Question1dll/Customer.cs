using Lab5Question1dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer.Entities
{
    public class CustomerClass
    {

        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Address { get; set; }
        public City City { get; set; }
        public double Phone { get; set; }
        public decimal CreditLimit { get; set; }



        public override string ToString()
        {
            return $"ID: {CustId}\n CustName:{CustName}\n Address:{Address}\n" +
                $" City:{City}\n Phone:{Phone}\n CreditLimit:{CreditLimit}\n ";

        }
        /* private int custId;
         private string custName;
         private string address;
         private string city;
         private double phone;
         private decimal creditLimit;

         //default ctor
         public Customer() { }
         //para ctor
         public Customer( int custId, string custName, string address, string city,
          double phone, decimal creditLimit)
         {
             this.custId = custId;
             this.custName = custName;
             this.address = address;
             this.city = city;
             this.phone = phone;
             this.creditLimit = creditLimit;
         }
        */
    }
}
