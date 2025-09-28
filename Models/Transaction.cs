using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Models
{
    internal class Transaction
    {
        public string TransactionID { get; set; } = Guid.NewGuid().ToString();
        public string FromAccount { get; set; }
        public string ToAccount { get; set; }
        public double Amount { get; set; }
        public DateTime TransactionAt { get; set; }
        public Transaction(string fromAccount, string toAccount, double amount)
        {
            if (string.IsNullOrEmpty(fromAccount)) throw new ArgumentException("FromAccount must not be empty!");
            else if(string.IsNullOrEmpty(toAccount)) throw new ArgumentException("ToAccount must not be empty!");
            else if (amount <= 0) throw new ArgumentException("Amount must be > 0");
            FromAccount = fromAccount;
            ToAccount = toAccount;
            Amount = amount;
            TransactionAt = DateTime.Now;
        }
    }
}
