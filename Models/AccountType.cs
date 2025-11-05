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
    
    public class AccountType
    {
        public AccountTypeEnum Type { get; }
        public string AccType { get => Type.ToString(); }
        
        private double _interestRate;
        public double InterestRate 
        { 
            get => _interestRate;
            private set
            {
                switch (Type)
                {
                    case AccountTypeEnum.Debit:
                        if (value < 0 || value > 0.5)
                            throw new ArgumentException($"Interest rate for Debit accounts must be between 0% and 0.5%. Provided: {value}%");
                        break;
                    case AccountTypeEnum.Credit:
                        if (value < 0 || value > 20)
                            throw new ArgumentException($"Interest rate for Credit accounts must be between 0% and 20%. Provided: {value}%");
                        break;
                    case AccountTypeEnum.Savings:
                        if (value < 0 || value > 6)
                            throw new ArgumentException($"Interest rate for Savings accounts must be between 0% and 6%. Provided: {value}%");
                        break;
                    default:
                        throw new ArgumentException("Invalid Account Type!");
                }
                _interestRate = value;
            }
        }
        public bool AllowOverdraft { get; private set; }
        public double CreditLimit { get; private set; }
        public bool CanTransfer { get; private set; }

        public AccountType(AccountTypeEnum type, double? customInterestRate = null)
        {
            Type = type;

            switch (type)
            {
                case AccountTypeEnum.Debit:
                    AllowOverdraft = false;
                    CreditLimit = 0;
                    CanTransfer = true;
                    InterestRate = customInterestRate ?? 0.15;
                    break;
                case AccountTypeEnum.Credit:
                    AllowOverdraft = true;
                    CreditLimit = 20_000_000;
                    CanTransfer = true;
                    InterestRate = customInterestRate ?? 4;
                    break;
                case AccountTypeEnum.Savings:
                    AllowOverdraft = false;
                    CreditLimit = 0;
                    CanTransfer = false;
                    InterestRate = customInterestRate ?? 0.3;
                    break;
                default:
                    throw new ArgumentException("Invalid Account Type!");
            }
        }
    }
}
