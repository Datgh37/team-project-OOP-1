using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Utils;

namespace BankManagement.Models
{
    internal class DebitAccount : Account
    {
        public DebitAccount() : base() { }
        public DebitAccount(string ownerFullName) : base(ownerFullName) { }
        public DebitAccount(string ownerFullName, double initBalance) : base(ownerFullName, initBalance) { }
        public override string GetAccountType()
        {
            return "Type: Debit";
        }
        public static double DebitInterestRate { get; private set; } = 0.5;
        public static bool SetInterestRate(double newRate)
        {
            if(newRate >= 0 && newRate < 3)
            {
                DebitInterestRate = newRate;
                return true;
            }
            return false;
        }
        public override double InterestRate => DebitInterestRate; // Pass to Account
        public override void ApplyInterest() => Balance += Balance * (InterestRate / 100);
    }
}
