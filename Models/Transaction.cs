using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Utils;

namespace BankManagement.Models
{
    public enum TransactionType
    {
        Deposit,
        Withdraw,
        Transfer
    }
    
    public class Transaction
    {
        public string TransactionID { get; private set; } = Guid.NewGuid().ToString();
        public string? FromAccountNumber { get; private set; }
        public string? Sender { get; private set; }
        public string? ToAccountNumber { get; private set; }
        public string? Receiver { get; private set; }
        public double Amount { get; private set; }
        public TransactionType Type { get; private set; }
        public string GetTransType { get => Type.ToString(); }
        public DateTime TransactionTime { get; private set; }
        
        public Transaction() { }
        
        public Transaction(string? fromAccNum, string? toAccNum, string? sender, string? receiver, double amount, TransactionType type)
        {
            if (amount <= 0) throw new ArgumentException("Amount must be > 0");
            if (sender == null && receiver == null)
                throw new ArgumentException("No Sender or Receiver included!");
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
            Sender = sender;
            Receiver = receiver;
            Amount = amount;
            Type = type;
            TransactionTime = DateTime.Now;
        }
        public Transaction(string dataLine)
        {
            var line = dataLine.Split(",");
            if (line.Length < 7)
                throw new FormatException($"Invalid transaction data line. Expected at least 7 fields, got {line.Length}");
            
            TransactionID = line[0];
            FromAccountNumber = string.IsNullOrWhiteSpace(line[1]) ? null : line[1];
            Sender = string.IsNullOrWhiteSpace(line[2]) ? null : line[2];
            ToAccountNumber = string.IsNullOrWhiteSpace(line[3]) ? null : line[3];
            Receiver = string.IsNullOrWhiteSpace(line[4]) ? null : line[4];
            Amount = line[5].ToDouble();
            
            // ✅ Parse TransactionType - hỗ trợ cả số và tên enum
            if (int.TryParse(line[6], out int enumValue))
            {
                Type = (TransactionType)enumValue;
            }
            else
            {
                Type = Enum.Parse<TransactionType>(line[6]);
            }
            
            // ✅ Parse TransactionTime - hỗ trợ nhiều format
            if (line.Length > 7 && !string.IsNullOrWhiteSpace(line[7]))
            {
                TransactionTime = line[7].ToDateMonthYear();
            }
            else
            {
                TransactionTime = DateTime.Now;
            }
        }
    }
}
