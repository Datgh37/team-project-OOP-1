using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
