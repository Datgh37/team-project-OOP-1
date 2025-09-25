using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement.Models
{
    internal class Bank
    {
        List<Account> BankAccounts = new List<Account>();
        // CRUD: Create, Read, Update, Delete
        public void AddAccount(Account account)
        {
            if (BankAccounts.Contains(account)) // Check if account already exist
                throw new Exception("Account Already Exists!");
            BankAccounts.Add(account);
        }
        public void RemoveAccount(Account account) // Remove Directly
        {
            if (!BankAccounts.Contains(account))
                throw new Exception("Account Not Found!");
            BankAccounts.Remove(account);
        }
        public void RemoveAccount(string accNumber) // Remove using account number
        {
            var acc = this[accNumber]; // Get account using indexer
            if (acc != null)
            {
                BankAccounts.Remove(acc);
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
        public List<Account> FindByOwner(string owner) =>
            BankAccounts.Where(acc => acc.Owner.Contains(owner)).ToList();
        //  [.. BankAccounts.Where(acc => acc.Owner.Contains(owner))]; Using Collection expression
        public List<Account> FindByBalance(double balance) =>
            BankAccounts.Where(acc => acc.Balance == balance).ToList(); // Find exact balance
        public List<Account> FindByBalance(double min, double max) =>
            BankAccounts.Where(acc => acc.Balance >= min && acc.Balance <= max).ToList(); // Find in range
        
        // INDEXER, Used to find by Number
        public Account? this[string number] => 
            BankAccounts.FirstOrDefault(acc => acc.Number == number); // Return null if Not found account
        // SORTING
        public List<Account> SortDescByBalance() =>
            BankAccounts.OrderByDescending(acc => acc.Balance).ToList(); // Return a copy of the list
                                                                         // BankAccounts.Sort((a,b) => b.Balance.CompareTo(a.Balance)) Return a the sorted original list (not rcm)
        public List<Account> SortByBalance() =>
            [.. BankAccounts.OrderBy(acc => acc.Balance)]; // Create a sorted list using [.. ]
        // APPLY INTEREST  
        public void ApplyInterestAll()
        {
            foreach(Account acc in BankAccounts)
            {
                acc.ApplyInterest();
            }
        }
        // MISC
        public void Deposit(double amount, string accNumber) 
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
        public void Withdraw(double amount, string accNumber)
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
        private Account GetOrThrow(string accNumber) =>
            this[accNumber] ?? throw new Exception("Account Not Exist!");
    }
}
