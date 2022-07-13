using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Question4
{
    class Supplier
    {
        int supplierID;
        string supplierName;
        string city;
        double phoneNo;
        string eMail;

        public void AcceptDetails()
        {
            Console.WriteLine("Enter Supplier Id");
            this.supplierID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Supplier Name");
            this.supplierName = Console.ReadLine();

            Console.WriteLine("Enter City Name");
            this.city = Console.ReadLine();

            Console.WriteLine("Enter Phone Number");
            this.phoneNo = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Email ID");
            this.eMail = Console.ReadLine();
        }

        public void DisolayDetails()
        {
            Console.WriteLine($"1.Supplier ID: {supplierID} \n" +
                              $"2.Supplier Name: {supplierName}\n" +
                              $"3.Supplier City: {city}\n" +
                              $"4.Supplier Phone Number: {phoneNo}\n" +
                              $"5.Suppler eMail: {eMail}\n");
        }
    }
}
