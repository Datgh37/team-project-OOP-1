using BankManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Models
{
    internal class Account
    {
        private int _number = 10000; // Initial Bank Number
        public string Number { get; } // Bank Account Number, Read Only, Unique
        public Customer Owner { get; protected set; } // Owner, Read Only, Unique
        public double Balance { get; protected set; } // Balance, No data change from outside
        public DateTime OpenAt { get; } // Account Open Time, Read Only
        public static double InterestRate { get; private set; } // Invest Rate, default 0.2, private set
        // CONSTRUCTOR
        static Account() // Static Constructor
        {
            InterestRate = 0.2;
        }
        public Account() : this("Annonymous Annonymous", 0) { }

        public Account(string ownerFullName, double initBalance)
        {
            if(string.IsNullOrEmpty(ownerFullName)) throw new ArgumentException("Owner name must not be empty!");
            if (initBalance < 0) throw new ArgumentException("Balance must be >= 0");

            var (ho, ten) = ownerFullName.TachHoTen();
            Number = (++_number).ToString();
            Balance = initBalance;
            OpenAt = DateTime.Now;
            Owner = new Customer(ho, ten);
        }
        public Account(string ownerFullName) : this(ownerFullName, 0) { }
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
            var to = bank[toNum];
            if(to == null) throw new Exception("Recipient Account Not Found!");
            else Transfer(to, amount);
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
