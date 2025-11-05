using BankManagement.Models;

namespace BankManagement.Utils
{
    public static class AccountExtensions
    {
        public static Transaction Deposit(this Account acc, Customer receiver, double amount)
        {
            acc.Deposit(amount);
            string receiverName = $"{receiver.LastName} {receiver.FirstName}";
            return new Transaction(null, acc.AccountNumber, null, receiverName, amount, TransactionType.Deposit);
        }
        public static Transaction Withdraw(this Account acc, Customer sender, double amount)
        {
            acc.Withdraw(amount);
            string senderName = $"{sender.LastName} {sender.FirstName}";
            return new Transaction(acc.AccountNumber, null, senderName, null, amount, TransactionType.Withdraw);
        }
        public static Transaction Transfer(this Account from, Account to, Customer sender, Customer receiver, double amount)
        {
            // Validate transfer logic
            if (from == to)
                throw new Exception("Cannot transfer to the same account!");
            if (!from.Type.CanTransfer)
                throw new Exception("This account cannot be used to transfer money!");
            if (amount <= 0)
                throw new ArgumentException("Transfer amount must be a positive value (amount > 0)!");
            if (!from.Type.AllowOverdraft && from.Balance < amount)
                throw new InvalidOperationException("Insufficient Balance!");
            if (from.Type.AllowOverdraft && (from.Balance - amount) < -from.Type.CreditLimit)
                throw new InvalidOperationException("Exceeds Credit Limit!");

            from.Withdraw(amount);
            to.Deposit(amount);

            string senderName = $"{sender.LastName} {sender.FirstName}";
            string receiverName = $"{receiver.LastName} {receiver.FirstName}";
            return new Transaction(from.AccountNumber, to.AccountNumber, senderName, receiverName, amount, TransactionType.Transfer);
        }
    }
}