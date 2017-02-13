using System;
using Jan162017.Visitor;

namespace Jan162017.AccountType
{
    public abstract class AccountType
    {
        private readonly ITransactionVisitor _cashbackVisitor = new CashbackTransactionVisitor();

        protected AccountType(Account account)
        {
            Account = account;
        }

        protected double MinimumBalance;

        public double CashBackPct;

        public double InterestRate;

        protected double Penalty;

        public Account Account { get; }

        public void Deposit(double amount)
        {
            Account.Balance += amount;

            if (Account.Balance < MinimumBalance)
            {
                Account.Balance -= Penalty;
            }

            var transaction = new Transaction
            {
                AccountState = Account.State,
                AccountType = this,
                Amount = amount,
                Type = TransactionType.Deposit
            };

            transaction.Accept(_cashbackVisitor);

            Account.Transactions.Add(transaction);
        }

        public void Withdraw(double amount)
        {
            if (Account.Balance < amount)
            {
                Console.WriteLine("No sufficient funds");
            }

            Account.Balance -= amount;

            if (Account.Balance < MinimumBalance)
            {
                Account.Balance -= Penalty;
            }

            var transaction = new Transaction
            {
                AccountState = Account.State,
                AccountType = this,
                Amount = amount,
                Type = TransactionType.Withdraw
            };

            Account.Transactions.Add(transaction);
        }
    }
}
