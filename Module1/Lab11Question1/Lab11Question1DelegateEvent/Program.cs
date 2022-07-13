using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question1DelegateEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Credit Card number");
            decimal creditNo = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter Credit Card Name");
            string creditName = Console.ReadLine();
            Console.WriteLine("Enter Credit Balance Amount");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Credit Limit");
            double creditLimit = double.Parse(Console.ReadLine());
            CreditCard creditCard = new CreditCard(creditNo, creditName, balance, creditLimit);


            Console.WriteLine("Enetr Amount to paid");
            double amnt = double.Parse(Console.ReadLine());
            creditCard.paymentIsMade += ShowSMS;
            creditCard.MakePayment(amnt);
           

            Console.ReadLine();
        }
        static void ShowSMS(string message)
        {
            Console.WriteLine(message);
        }
    }
}
