using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Utils
{
    internal class AccountManagement
    {
        private readonly List<Account> _accounts = new(); // Bank Accounts
        private readonly List<Transaction> _transactions = new(); // Transactions
        public List<Account> GetAccounts { get => _accounts; } // Public List to access
        public List<Transaction> GetTransactions { get => _transactions; }
        // CRUD: Create, Read, Update, Delete
        public void AddAccount(Account account)
        {
            // Validate to check if duplicates account
            if (_accounts.Any(a => a.AccountNumber == account.AccountNumber))
                throw new Exception("Account already exists!");
            _accounts.Add(account);
        }
        public void RemoveAccount(Account account) // Remove Directly
        {
            if (!_accounts.Contains(account))
                throw new Exception("Account Not Found!");
            _accounts.Remove(account);
        }
        public void RemoveAccount(string accNumber) // Remove using account number
        {
            var acc = this[accNumber]; // Get account using indexer
            if (acc != null)
            {
                _accounts.Remove(acc);
            }
            else throw new Exception("Account Not Found!");
        }

        /* Alternative Remove Approach
        public bool RemoveAccount(Account account) // Remove Directly
        {
            if (!BankAccounts.Contains(account))
                return false;
            else
            {
                BankAccounts.Remove(account);
                return true;
            }    
        }
        public bool RemoveAccount(string number) // Remove using account number
        {
            var acc = this[number]; // Get account using indexer
            if (acc != null)
            {
                BankAccounts.Remove(acc);
                return true;
            }
            else return false;
        }
        */
        public List<Account> FindByCustomerID(Guid customerID) =>
            _accounts
            .Where(acc => acc.CustomerID == customerID)
            .ToList();
        //  [.. BankAccounts.Where(acc => acc.Owner.Contains(owner))]; Using Collection expression
        public List<Account> FindByBalance(double balance) =>
            _accounts.Where(acc => acc.Balance == balance).ToList(); // Find exact balance
        public List<Account> FindByBalance(double min, double max) =>
            _accounts.Where(acc => acc.Balance >= min && acc.Balance <= max).ToList(); // Find in range
        
        // INDEXER, Used to find by Number
        public Account? this[string number] => 
            _accounts.FirstOrDefault(acc => acc.AccountNumber == number); // Return null if Not found account
        // SORTING
        public List<Account> SortDescByBalance() =>
            _accounts.OrderByDescending(acc => acc.Balance).ToList(); // Return a copy of the list
                                                                         // BankAccounts.Sort((a,b) => b.Balance.CompareTo(a.Balance)) Return a the sorted original list (not rcm)
        public List<Account> SortByBalance() =>
            [.. _accounts.OrderBy(acc => acc.Balance)]; // Create a sorted list using [.. ]
        // APPLY INTEREST  
        public void ApplyInterestAll()
        {
            foreach(Account acc in _accounts)
            {
                acc.ApplyInterest();
            }
        }
        // MISC
        // Get List from CSV File
        public void ImportAccountListFromCSV(string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.AccountInfoPath : fileName; // Get default path
            _accounts.Clear(); // Clear all old data to import new form File
            // Stream Reader, read file content
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // Skip Header line
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Account acc = new Account(line);
                        _accounts.Add(acc);
                    } 
                }
            }
            Account.UpdateAccountNumberSeed(_accounts);
        }
        public List<Account> GetAccountListFromCSV(string fileName = "")
        {
            fileName = (fileName == "") ? GlobalSettings.AccountInfoPath : fileName; // Get default path
            var accounts = new List<Account>();
            // Stream Reader, read file content
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (!reader.EndOfStream) reader.ReadLine(); // Skip Header line
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        Account acc = new Account(line);
                        accounts.Add(acc);
                    }
                }
            }
            Account.UpdateAccountNumberSeed(accounts);
            return accounts;
        }
        // Transaction methods
        public void Deposit(string accNumber, double amount) 
        {
            try
            {
                GetOrThrow(accNumber).Deposit(amount);
            }
            catch (Exception ex)
            {
                throw new Exception($"Deposit failed for Account[{accNumber}]\nError:", ex);
            }
        }
        public void Withdraw(string accNumber, double amount)
        {
            try
            {                
                GetOrThrow(accNumber).Withdraw(amount);
            }
            catch (Exception ex)
            {
                throw new Exception($"Withdraw failed for Account[{accNumber}]\nError:", ex);
            }
        }
        // Note: May be will develop to transfer to different Banks later
        public void Transfer(string fromNumber, string toNumber, double amount)
        {
            var from = GetOrThrow(fromNumber); // Get From Account
            var to = GetOrThrow(toNumber); // Get To Account

            ValidateTransfer(from, to, amount);
            from.Withdraw(amount);
            to.Deposit(amount);

            Transaction trans = new Transaction(fromNumber, toNumber, amount, TransactionType.Transfer);
            _transactions.Add(trans);
        }
        private void ValidateTransfer(Account fromAcc, Account toAcc, double amount) 
        {
            if (fromAcc == toAcc)
                throw new Exception("Cannot transfer to the same account!");
            if (fromAcc.Type.CanTransfer == false)
                throw new Exception("This account cannot be used to transfer money!");
            if (amount <= 0)
                throw new ArgumentException("Transfer amount must be a positive value (amount > 0)!");
            if (!fromAcc.Type.AllowOverdraft && fromAcc.Balance < amount)
                throw new InvalidOperationException("Insufficient Balance!");
            if (fromAcc.Type.AllowOverdraft && (fromAcc.Balance - amount) < -fromAcc.Type.CreditLimit)
                    throw new InvalidOperationException("Exceeds Credit Limit!");
        }
        private Account GetOrThrow(string accNumber) =>
            this[accNumber] ?? throw new Exception("Account Not Exist!");
    }
}
