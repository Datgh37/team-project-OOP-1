using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
