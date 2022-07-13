using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Question1
{
    public abstract class BankAccount : IBankAccount
    {
        public double balance { get; set; }
        public BankAccountTypeEnum AccountType 
        {
            get; set;
        }

        public abstract void CalculateInterest(double amount, double rate, int time);
        

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public abstract bool Transfer(IBankAccount toAccount, double amount);

        public abstract bool Withdraw(double amount);
        
    }
}
