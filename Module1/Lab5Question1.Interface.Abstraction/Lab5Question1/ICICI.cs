using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Question1
{
    public class ICICI : BankAccount
    {
        public override void CalculateInterest(double amount, double rate, int time)
        {
            double interest = (amount * rate * time) / 100;
            Console.WriteLine(interest);
        }

        public override bool Transfer(IBankAccount toAccount, double amount)
        {
            if (balance - amount >= 1000)
            {

                toAccount.Deposit(amount);
                return true;
            }
            else
            {
                return false;
            }

        }

        public override bool Withdraw(double amount)
        {
            double operation = balance - amount;
            if (operation >= 0)
            {
                balance = balance - amount;
            }
            return true;
        }
    }
}
