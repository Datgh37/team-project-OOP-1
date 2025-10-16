using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Utils;

namespace BankManagement.Models
{
    internal class CreditAccount : Account
    {
        public CreditAccount() : base() { } 
        public CreditAccount(string ownerFullName) : base(ownerFullName) { }
        public CreditAccount(string ownerFullName, double initBalance) : base(ownerFullName, initBalance) { }

        public override string GetAccountType()
        {
            return "Type: Credit";
        }
        public static double CreditInterestRate { get; private set; } = 0.5;
        public static bool SetInterestRate(double newRate)
        {
            if (newRate >= 0 && newRate < 3)
            {
                CreditInterestRate = newRate;
                return true;
            }
            return false;
        }
        public override double InterestRate => CreditInterestRate; // Pass DebitInterestRate to Account
        public override void ApplyInterest() => Balance += Balance * (InterestRate / 100);
    }
}
