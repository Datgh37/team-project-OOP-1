using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Utils;

namespace BankManagement.Models
{
    public enum AccountTypeEnum
    {
        Debit = 0,
        Credit = 1,
        Savings = 2
    }
    internal class AccountType
    {
        public AccountTypeEnum Type { get; }
        public string AccType { get => Type.ToString();} 
        public double InterestRate { get; private set; }
        public bool AllowOverdraft { get; private set; }
        public double CreditLimit { get; private set; }
        public bool CanTransfer { get; private set; }

        public AccountType(AccountTypeEnum type, double? customInterestRate = null)
        {
            Type = type;
            switch (type)
            {
                case AccountTypeEnum.Debit:
                    InterestRate = customInterestRate ?? 0.15;
                    AllowOverdraft = false;
                    CreditLimit = 0;
                    CanTransfer = true;
                    break;
                case AccountTypeEnum.Credit:
                    InterestRate = customInterestRate ?? 4;
                    AllowOverdraft = true;
                    CreditLimit = 20_000_000;
                    CanTransfer = true;
                    break;
                case AccountTypeEnum.Savings:
                    InterestRate = customInterestRate ?? 0.3;
                    AllowOverdraft = false;
                    CreditLimit = 0;
                    CanTransfer = false;
                    break;
                default:
                    throw new ArgumentException("Invalid Account Type!");
            }
        }
    }
}
