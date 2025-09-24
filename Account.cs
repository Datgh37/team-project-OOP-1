using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    internal class Account
    {
        private int _number = 10000; // Initial Bank Number
        public string Number { get; } // Bank Account Number, Read Only, Unique
        public string Owner { get; private set; } // Owner, Read Only, Unique
        public double Balance { get; private set; } // Balance, No data change from outside
        public DateTime OpenAt { get; } // Account Open Time, Read Only
        public static double InterestRate { get; private set; } // Invest Rate, default 0.2, private set
        // CONSTRUCTOR
        static Account() // Static Constructor
        {
            InterestRate = 0.2;
        }
        public Account() : this("Annonymous", 0) { }

        public Account(string owner, double balance)
        {
            if (balance < 0) throw new ArgumentException("Balance must be >= 0");
            Number = (++_number).ToString();
            Owner = owner;
            Balance = balance;
            OpenAt = DateTime.Now;
        }
        public Account(string owner) : this(owner, 0) { }
        public Account(Account acc) // Copy Constructor
        {
            this.Number = acc.Number;
            this.Owner = acc.Owner;
            this.Balance = acc.Balance;
            OpenAt = acc.OpenAt;
        }
        // METHODS
        public void Transfer(Account toAcc, double amount)
        {
            if (Balance < amount) throw new Exception("Insufficient Balance!");
            Balance -= amount;
            toAcc.Balance += amount;
        }
        public void Transfer(Bank bank, string toNum, double amount)
        {

        }
        public bool ChangeInterestRate(double newRate)
        {
            if (newRate >= 0 && newRate <= 10)
            {
                InterestRate = newRate;
                return true;
            }
            return false;
        }
        public void ApplyInterest()
        {
            Balance += Balance * (InterestRate / 100);
        }
        public void Deposit(double amount)
        {
            if (amount < 0) throw new ArgumentException("Invalid Amount!");
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount < 0) throw new ArgumentException("Invalid Amount!");
            else if (Balance < amount) throw new InvalidOperationException("Insufficient Balance!");
            Balance -= amount;
        }
    }
    internal static class MoneyFmt
    {
        public static string Format(double amount) =>
            string.Format("{0:N2} VND", amount);
        // Format amount, 0: First parameter, N: Number format, 2: Number of decimal digit
        // Ex: 10000 => 10000.00 VND
    }
}
