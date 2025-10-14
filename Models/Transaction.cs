using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdraw,
        Transfer
    }
    internal class Transaction
    {
        public string TransactionID { get; } = Guid.NewGuid().ToString();
        public string? FromAccountNumber { get; } 
        public string? ToAccountNumber { get; }
        public double Amount { get; }
        public TransactionType Type { get; }
        public DateTime TransactionTime { get; }
        public Transaction(string? fromAccNum, string? toAccNum, double amount, TransactionType type)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be > 0");
            if (type == TransactionType.Transfer) // For Transfer transaction
            {
                if (string.IsNullOrEmpty(fromAccNum) || string.IsNullOrEmpty(toAccNum))
                    throw new ArgumentException("Transfer requires both source and target accounts!");
            }
            else if (type == TransactionType.Deposit && string.IsNullOrEmpty(toAccNum)) // For Deposit transaction
                throw new ArgumentException("Deposit requires a destination account!"); 
            else if (type == TransactionType.Withdraw && string.IsNullOrEmpty(fromAccNum)) // For Withdrawal transation
                throw new ArgumentException("Withdraw requires a source account!");

            FromAccountNumber = fromAccNum;
            ToAccountNumber = toAccNum;
            Amount = amount;
            Type = type;
            TransactionTime = DateTime.Now;
        }
        

    }
}
