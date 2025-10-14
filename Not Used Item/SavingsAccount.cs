using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Utils;

namespace BankManagement.Models
{
    internal class SavingsAccount : Account
    {
        public SavingsAccount() : base() { }
        public SavingsAccount(string ownerFullName) : base(ownerFullName) { }
        public SavingsAccount(string ownerFullName, double initBalance) : base(ownerFullName, initBalance) { }
        public override string GetAccountType()
        {
            return "Type: Savings";
        }
        public static double SavingsInterestRate { get; private set; } = 0.5;
        public static bool SetInterestRate(double newRate)
        {
            if (newRate >= 0 && newRate < 5)
            {
                SavingsInterestRate = newRate;
                return true;
            }
            return false;
        }
        public override double InterestRate => SavingsInterestRate; // Pass to Account
        public override void ApplyInterest() => Balance += Balance * (InterestRate / 100);
    }
}
