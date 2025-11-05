using BankManagement.Models;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace BankManagement.Utils
{
    public class TransactionManagement
    {
        private readonly List<Transaction> _transactions = new();
        private readonly List<Transaction> _allTransactions = new(); // Store original list
        public List<Transaction> Transactions { get => _transactions; }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);
            _allTransactions.Add(transaction);
        }

        public void ImportTransactionListFromCSV(string filePath = "")
        {
            filePath = string.IsNullOrWhiteSpace(filePath) ? GlobalSettings.TransactionInfoPath : filePath;
            _transactions.Clear();
            _allTransactions.Clear();
            
            if (!File.Exists(filePath)) return;

            using (StreamReader reader = new StreamReader(filePath))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // Skip Header
                int lineNumber = 1; // Track line numbers for debugging
                
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    lineNumber++;
                    
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        try
                        {
                            Transaction trans = new Transaction(line);
                            _transactions.Add(trans);
                            _allTransactions.Add(trans);
                        }
                        catch (Exception ex)
                        {
                            throw new FormatException($"Error parsing transaction line {lineNumber}: {line}", ex);
                        }
                    }
                }
            }
        }
        public void SaveTransactionListToCSV(string filePath = "")
        {
            filePath = string.IsNullOrWhiteSpace(filePath) ? GlobalSettings.TransactionInfoPath : filePath;
            _allTransactions.SaveCSV(filePath);
        }

        public void ClearHistory()
        {
            _transactions.Clear();
            _allTransactions.Clear();
        }
        
        // Total transactions and money in that type transaction (filtered)
        public int GetTotalItemsInList(bool all = false)
        {
            if (all) return _allTransactions.Count;
            return _transactions.Count;
        }
        
        public (int, int, int) GetTotalItemsEachTransactionType(bool all = false)
        {
            int d = 0, w = 0, t = 0;
            if (all)
            {
                foreach (Transaction trans in _allTransactions)
                {
                    switch (trans.Type)
                    {
                        case TransactionType.Deposit:
                            d++;
                            break;
                        case TransactionType.Withdraw:
                            w++;
                            break;
                        case TransactionType.Transfer:
                            t++;
                            break;
                        default:
                            throw new ArgumentException("Unexpected Error!");
                    }
                }
            }
            else
            {
                foreach (Transaction trans in _transactions)
                {
                    switch (trans.Type)
                    {
                        case TransactionType.Deposit:
                            d++;
                            break;
                        case TransactionType.Withdraw:
                            w++;
                            break;
                        case TransactionType.Transfer:
                            t++;
                            break;
                        default:
                            throw new ArgumentException("Unexpected Error!");
                    }
                }
            }
            return (d, w, t);
        }
        
        // Update List to carry only Filtered Transactions based on Account
        public void UpdateFilteredTransaction(string accountNumber)
        {
            _transactions.Clear();
            var filtered = _allTransactions.Where(t => t.FromAccountNumber == accountNumber || t.ToAccountNumber == accountNumber).ToList();
            _transactions.AddRange(filtered);
        }
        
        // Reset to show all transactions
        public void ResetFilter()
        {
            _transactions.Clear();
            _transactions.AddRange(_allTransactions);
        }

        public List<Transaction> FindByAccount(string accNumber) =>
            [.. _allTransactions.Where(t => t.FromAccountNumber == accNumber || t.ToAccountNumber == accNumber)];

        public List<Transaction> FindByCustomer(string customerName) =>
            [.. _allTransactions.Where(t => t.Sender == customerName || t.Receiver == customerName)];

        public List<Transaction> FindByType(TransactionType type) =>
            [.. _allTransactions.Where(t => t.Type == type)];

        public List<Transaction> FindByDateRange(DateTime from, DateTime to)
        {
            if (from > to)
                throw new ArgumentException("From date must be before To date!");
            return [.. _allTransactions.Where(t => t.TransactionTime >= from && t.TransactionTime <= to)];
        }
    }
}