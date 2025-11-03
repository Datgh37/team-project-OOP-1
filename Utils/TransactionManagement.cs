using BankManagement.Models;
using System.Collections.Generic;
using System.Linq;

namespace BankManagement.Utils
{
    public class TransactionManagement
    {
        private readonly List<Transaction> _transactions = new();
        public List<Transaction> Transactions { get => _transactions; }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
        }
        public void ClearHistory()
        {
            _transactions.Clear();
        }
        // Total transactions and money in that type transaction
        public (int count, double totalAmount) GetStatistics(TransactionType type)
        {
            var filtered = _transactions.Where(t => t.Type == type);
            int count = filtered.Count();
            double totalAmount = filtered.Sum(t => t.Amount);
            return (count, totalAmount);
        }
        public List<Transaction> FindByAccount(string accNumber) =>
            _transactions.Where(t => t.FromAccountNumber == accNumber || t.ToAccountNumber == accNumber).ToList();

        public List<Transaction> FindByCustomer(string customerName) =>
            _transactions.Where(t => t.Sender == customerName || t.Receiver == customerName).ToList();

        public List<Transaction> FindByType(TransactionType type) =>
            _transactions.Where(t => t.Type == type).ToList();

        public List<Transaction> FindByDateRange(DateTime from, DateTime to) =>
            _transactions.Where(t => t.TransactionTime >= from && t.TransactionTime <= to).ToList();
    }
}