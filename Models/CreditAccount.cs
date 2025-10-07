using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
