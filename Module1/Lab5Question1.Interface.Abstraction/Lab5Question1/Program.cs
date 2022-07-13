using Lab5Question1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BankingOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For ICICI");

            ICICI iciciSaving = new ICICI();
            iciciSaving.AccountType = BankAccountTypeEnum.Saving;
            iciciSaving.Deposit(50000);
            ICICI iciciCurrent = new ICICI();
            iciciCurrent.AccountType = BankAccountTypeEnum.Current;
            iciciCurrent.Deposit(10000);

            Console.WriteLine("Balance of Saving Account:\n " + iciciSaving.GetBalance());
            Console.WriteLine("Balance of Current Account:\n " + iciciCurrent.GetBalance());

            iciciSaving.Transfer(iciciCurrent, 5000);
            iciciSaving.Withdraw(5000);
            

            Console.WriteLine("Balance After Transfer");
            Console.WriteLine("Balance of Saving Account:\n " + iciciSaving.GetBalance());
            Console.WriteLine("Balance of Current Account:\n " + iciciCurrent.GetBalance());
            Console.ReadLine();


            // for HSBC bank
            Console.WriteLine("For HSBC");
            HSBC hsbcSaving = new HSBC();
            hsbcSaving.AccountType = BankAccountTypeEnum.Saving;
            hsbcSaving.Deposit(50000);
            HSBC hsbcCurrent = new HSBC();
            hsbcCurrent.AccountType = BankAccountTypeEnum.Current;
            hsbcCurrent.Deposit(10000);

            Console.WriteLine("Balance of Saving Account:\n " + hsbcSaving.GetBalance());
            Console.WriteLine("Balance of Current Account:\n " + hsbcCurrent.GetBalance());

            hsbcSaving.Transfer(hsbcCurrent, 30000);
            hsbcSaving.Withdraw(30000);


            Console.WriteLine("Balance After Transfer");
            Console.WriteLine("Balance of Saving Account:\n " + hsbcSaving.GetBalance());
            Console.WriteLine("Balance of Current Account:\n " + hsbcCurrent.GetBalance());
            Console.ReadLine();

            Console.WriteLine("Claculate Simple interest for ICICI bank");
            Console.WriteLine("Enter Principle Amount");
            double principle =double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate of interest ");
            double rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Principle Timeperiod in year");
            int timePeriod = int.Parse(Console.ReadLine());

            iciciSaving.CalculateInterest(principle, rate, timePeriod);

            Console.ReadLine();

            Console.WriteLine("Claculate Simple interest for HSBC bank");
            Console.WriteLine("Enter Principle Amount");
             principle = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Rate of interest ");
             rate = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Principle Timeperiod in year");
             timePeriod = int.Parse(Console.ReadLine());

            hsbcSaving.CalculateInterest(principle, rate, timePeriod);

            Console.ReadLine();

        }
    }
}
