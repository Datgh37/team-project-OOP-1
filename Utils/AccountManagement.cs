using BankManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Utils
{
    public class AccountManagement
    {
        private readonly List<Account> _accounts = new(); // Bank Accounts
        public List<Account> Accounts { get => _accounts; } // Public List to access
        // CRUD: Create, Read, Update, Delete
        public void AddAccount(Account account)
        {
            if (account == null)
                throw new ArgumentNullException(nameof(account), "Account cannot be null!");
            
            if (_accounts.Any(a => a.AccountNumber == account.AccountNumber))
                throw new InvalidOperationException($"Account {account.AccountNumber} already exists!");
            
            if (HasAccountType(account.CustomerID, account.Type.Type))
            {
                throw new InvalidOperationException(
                    $"Customer already has a {account.Type.AccType} account! " +
                    "Each customer can only have one account of each type.");
            }
            
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
        public void ClearList()
        {
            _accounts.Clear();
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
        public List<Account> FindByStringInput(string input) =>
            _accounts.Where(acc =>
                acc.AccountNumber.ToLower().Contains(input) ||
                acc.AccountTypeName.ToLower().Contains(input) ||
                acc.Balance.ToString().Contains(input) ||
                acc.CustomerID.ToString().ToLower().Contains(input) ||
                acc.OpenAt.ToString().ToLower().Contains(input) || 
                acc.InterestRate.ToString().Contains(input) ||
                acc.CustomerID.ToString().ToLower().Equals(input)
            )
            .ToList();
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
        // Get Statistic
        public int GetTotalItemsInList()
        {
            return _accounts.Count;
        }
        public (int, int, int) GetTotalItemsEachAccountType()
        {
            int d = 0, c = 0, s = 0;
            foreach(Account acc in _accounts)
            {
                switch (acc.AccountTypeName)
                {
                    case "Debit":
                        d++;
                        break;
                    case "Credit":
                        c++;
                        break;
                    case "Savings":
                        s++;
                        break;
                    default:
                        throw new ArgumentException("Unexpected Error!");
                }
            }
            return (d,c,s);
        }
        
        // List Interaction with CSV File
        public void ImportAccountListFromCSV(string filePath = "")
        {
            filePath = (filePath == "") ? GlobalSettings.AccountInfoPath : filePath;
            _accounts.Clear();
            
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
                            Account acc = new Account(line);
                            _accounts.Add(acc);
                        }
                        catch (Exception ex)
                        {
                            throw new FormatException($"Error parsing line {lineNumber}: {line}", ex);
                        }
                    }
                }
            }
            Account.UpdateAccountNumberSeed(_accounts);
        }
        public List<Account> GetAccountListFromCSV(string filePath = "")
        {
            filePath = (filePath == "") ? GlobalSettings.AccountInfoPath : filePath; // Get default path
            var accounts = new List<Account>();
            // Stream Reader, read file content
            using (StreamReader reader = new StreamReader(filePath))
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
        public void SaveAccountsToCSV(string filePath = "")
        {
            filePath = string.IsNullOrEmpty(filePath) ? GlobalSettings.AccountInfoPath : filePath;
            _accounts.SaveCSV(filePath);
            //StringBuilder csv = new StringBuilder();
            //csv.AppendLine("AccountNumber,Balance,InterestRate,OpenAt,AccountTypeName,CustomerID");

            //foreach (var acc in _accounts)
            //{
            //    string line = $"{acc.AccountNumber},{acc.Balance},{acc.InterestRate}," +
            //                 $"{acc.OpenAt:dd-MM-yyyy},{(int)acc.Type.Type},{acc.CustomerID:N}";
            //    csv.AppendLine(line);
            //}

            //File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
        }
        private Account GetOrThrow(string accNumber) =>
            this[accNumber] ?? throw new Exception("Account Not Exist!");

        // Check if customer already has this account type
        public bool HasAccountType(Guid customerId, AccountTypeEnum accountType)
        {
            return _accounts.Any(a => 
                a.CustomerID == customerId && 
                a.Type.Type == accountType);
        }
        
        // Get existing account of same type for customer
        public Account? GetAccountByCustomerAndType(Guid customerId, AccountTypeEnum accountType)
        {
            return _accounts.FirstOrDefault(a => 
                a.CustomerID == customerId && 
                a.Type.Type == accountType);
        }
    }
}
