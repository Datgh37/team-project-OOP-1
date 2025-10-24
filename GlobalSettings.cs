using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public static class GlobalSettings
    {
        // Use AppDomain.CurrentDomain.BaseDirectory to get the executable directory
        private static readonly string DataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        public static readonly string AccountInfoPath = Path.Combine(DataPath, "AccountInfo.csv");
        public static readonly string CustomerInfoPath = Path.Combine(DataPath, "CustomerInfo.csv");
        public static readonly string TransactionInfoPath = Path.Combine(DataPath, "TransactionInfo.csv");

        public static string DateDMY { get; } = "dd/MM/yyyy";
        public static string DateMDY { get; } = "MM/dd/yyyy";
        public static string DateYMD { get; } = "yyyy-MM-dd";
    }
}
