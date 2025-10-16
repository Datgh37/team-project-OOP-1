using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagement.Utils;

namespace BankManagement.Models
{
    internal class AccountType
    {
        public string AccType { get; private set; } 
        public double InterestRate { get; private set; } // Depends on which type
        public bool AllowOverdraft { get; private set; } // True only if Credit type 
        public double CreditLimit { get; private set; } // For Credit type only
        public bool CanTransfer { get; private set; } // False if Savings Type
        public AccountType(int typeID = 0, double? customInterestRate = null)
        {
            switch (typeID)
            {
                case 0:
                    AccType = "Debit";

                    InterestRate = customInterestRate ?? 0.15; // Set default rate for Debit if not pass the value
                    AllowOverdraft = false;
                    CreditLimit = 0;
                    CanTransfer = true;
                    break;
                case 1:
                    AccType = "Credit";
                    InterestRate = customInterestRate ?? 4; // Set default rate for Credit if not pass the value
                    AllowOverdraft = true;
                    CreditLimit = 20_000_000; 
                    CanTransfer = true;
                    break;
                case 2:
                    AccType = "Savings";
                    InterestRate = customInterestRate ?? 0.3; // Set default rate for Savings if not pass the value
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
