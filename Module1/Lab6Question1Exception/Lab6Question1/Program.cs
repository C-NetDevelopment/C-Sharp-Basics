using Customer.BL;
using Customer.Entities;
using CustomerException;
using Lab5Question1dll;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Customer.PL
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Employee Managemant System");
                Console.WriteLine("1. Add Customer\n" +
                                  "2. List Customer\n" +
                                  "3. Exit\n");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddCustomer();
                            break;
                        case 2:
                            ListCustomer();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            } while (true);
        }

        private static void ListCustomer()
        {
            IEnumerable<CustomerClass> list = CustomerBL.CustomerList();
            foreach (var customer in list)
            {
                Console.WriteLine(customer);
            }
        }

        private static void AddCustomer()
        {
            CustomerClass customer = new CustomerClass();
            Console.WriteLine("Enetr CustId");
            customer.CustId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name");
            customer.CustName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            customer.Address = Console.ReadLine();

            Console.WriteLine("Enter City");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, out City city))
            {
                customer.City = city;
            }
            else
            {
                Console.WriteLine("Invalid City");
            }

            Console.WriteLine("Enter Phone Number");
            string phone = Console.ReadLine();
            Regex regex = new Regex("^([0-9]{10})+$");

            if (regex.IsMatch(phone))
            {
                double phone1 = double.Parse(phone);
                customer.Phone = phone1;
            }
            else
            {
                Console.WriteLine("Invalid phone number");
            }

            Console.WriteLine("Enter Credit");
            input = Console.ReadLine();
            if (int.TryParse(input, out int creditLimit))
            {
                if (creditLimit < 5000)
                {
                    customer.CreditLimit = creditLimit;

                }
                else
                {
                    creditLimit = 0;
                }
                
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            try
            {
                bool isAdded = CustomerBL.AddCustomer(customer);
                if (isAdded)
                {
                    Console.WriteLine("Emp Added Successfully");
                }
                else
                {
                    Console.WriteLine("emp failed");
                }
            }
            catch (MyCustomException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
