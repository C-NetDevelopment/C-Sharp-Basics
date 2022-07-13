using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab5Question1
{
   public interface IBankAccount 
    {
        double GetBalance();
        void Deposit(double amount);



        void CalculateInterest(double amount, double rate, int time);
        bool Withdraw(double amount);
        bool Transfer(IBankAccount toAccount, double amount);
        BankAccountTypeEnum AccountType { get; set; }

    }
}
