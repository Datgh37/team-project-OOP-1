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
        private static readonly string DataDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");

        public static readonly string CustomerInfoPath = Path.Combine(DataDir, "CustomerInfo.csv");
        public static readonly string TransactionInfoPath = Path.Combine(DataDir, "TransactionInfo.csv");

        public static string DateDMY { get; } = "dd/MM/yyyy";
        public static string DateMDY { get; } = "MM/dd/yyyy";
        public static string DateYMD { get; } = "yyyy-MM-dd";
    }
}
