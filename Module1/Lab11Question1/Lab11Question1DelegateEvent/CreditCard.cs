using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11Question1DelegateEvent
{
    public delegate void SendSMS(string message);
    class CreditCard
    {
        private decimal creditCardNo;
        private string cardHolderName;
        private double balanceAmount;
        private double creditLimit;

        public CreditCard(decimal creditCardNo, string cardHolderName, double balanceAmount, double creditLimit)
        {
            this.creditCardNo = creditCardNo;
            this.cardHolderName = cardHolderName;
            this.balanceAmount = balanceAmount;
            this.creditLimit = creditLimit;
        }

        public double GetBalance()
        {
            return balanceAmount;
        }

        public double GetCreditLimit()
        {
            return creditLimit;
        }

        public event SendSMS paymentIsMade;

        public void MakePayment(double amount)
        {
            if (paymentIsMade != null)
            {
                if (amount <= creditLimit)
                {
                    this.balanceAmount -= amount;
                    paymentIsMade($"{cardHolderName} has made payment of amount {amount}. The balance is {balanceAmount} now");
                }
                else
                {
                    paymentIsMade($"The customer with credit card no {creditCardNo} has credit limit {creditLimit}");
                }
            }


        }
        

    }
}
