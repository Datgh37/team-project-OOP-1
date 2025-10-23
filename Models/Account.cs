using BankManagement.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BankManagement.Models
{
    public class Account
    {
        private static int _number = 10000; // Initial Bank Number
        //public string BankName { get; set; }
        public string AccountNumber { get; } // Bank Account Number, Read Only, Unique
        public Guid CustomerID { get ; private set; } // Customer ID, Account Owner, Unique
        public double Balance { get; private set; } // Balance, with Debit/Savings account, Debt with Credit account
        public double InterestRate { get; private set; }
        public AccountType Type { get; } // Account Type (Debit / Credit / Savings)
        public string AccountTypeName { get => Type.AccType; } // A separate property to get data from Type
        public DateTime OpenAt { get; } // Account Open Time, Read Only
       
        // CONSTRUCTOR
        // No Need for parameterless Constructor, currently using Full optional constructor
        public Account(AccountTypeEnum type = AccountTypeEnum.Debit, double initBalance = 0, Customer? customer = null)
        {
            if (initBalance < 0) throw new ArgumentException("Balance must be >= 0");
            AccountNumber = (++_number).ToString();
            Balance = (type != AccountTypeEnum.Credit)? initBalance : 0; // Always set initBalance = 0 if Credit Account (Balance = Debt)
            OpenAt = DateTime.Now;
            CustomerID = customer?.UID ?? Guid.NewGuid(); // Get customer UID, if not, create a temporary unique id
            Type = new AccountType(type);
            InterestRate = Type.InterestRate;
        }
        // Get Data from CSV file
        public Account(string dataLine)
        {
            string[] line = dataLine.Split(",");
            AccountNumber = line[0];
            Balance = line[1].ToDouble();
            InterestRate = line[2].ToDouble();
            OpenAt = line[3].ToDateMonthYear();
            // Parse enum from number or string
            AccountTypeEnum typeEnum = (AccountTypeEnum)Enum.Parse(typeof(AccountTypeEnum), line[4]);
            Type = new AccountType(typeEnum, InterestRate);
            CustomerID = Guid.Parse(line[5]);
        }
        public Account(Account acc) // Copy Constructor
        {
            this.AccountNumber = acc.AccountNumber;
            this.CustomerID = acc.CustomerID;
            this.Balance = acc.Balance;
            this.InterestRate = acc.InterestRate;
            this.Type = acc.Type;
            this.OpenAt = acc.OpenAt;
        }
        // METHODS
        public string GetAccountType() 
        {
            return Type.AccType;
        }
        public void ChangeInterestRate(double rate)
        {
            switch (Type.AccType)
            {
                case "Debit":
                    if (rate < 0 || rate > 0.5) 
                        throw new ArgumentException("Invalid or Exceeds Interest Rate limit for Debit Type Account!");
                    else InterestRate = rate;
                    break;
                case "Credit":
                    if (rate < 0 || rate > 20) 
                        throw new ArgumentException("Invalid or Exceeds Interest Rate limit for Credit Type Account!");
                    else InterestRate = rate;
                    break;
                case "Savings":
                    if (rate < 0 || rate > 6) 
                        throw new ArgumentException("Invalid or Exceeds Interest Rate limit for Savings Type Account!");
                    else InterestRate = rate;
                    break;
                default:
                    throw new Exception("Unexpected Error");
            }
        }
        public void ApplyInterest() => Balance += Balance * (InterestRate / 100);
        public void Deposit(double amount)
        {
            if (amount < 0) throw new ArgumentException("Invalid Amount!");
            Balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount < 0) throw new ArgumentException("Invalid Amount!");
            else if (Balance < amount && !Type.AllowOverdraft) throw new InvalidOperationException("Insufficient Balance!");
            Balance -= amount;
        }
        // Update Account Number in case of importing external file to avoid conflicts
        public static void UpdateAccountNumberSeed(IEnumerable<Account> accounts)
        {
            if (accounts == null || !accounts.Any()) return;
            int maxNumber = accounts
                .Select(a => int.TryParse(a.AccountNumber, out int n) ? n : 0)
                .Max();
            if (maxNumber > _number)
                _number = maxNumber;
        }
    }
    internal static class MoneyFmt
    {
        public static string Format(double amount) =>
            string.Format("{0:N2} VND", amount);
        // Format amount, 0: First parameter, N: Number format, 2: Number of decimal digit
        // Ex: 10000 => 10000.00 VND
    }
}
