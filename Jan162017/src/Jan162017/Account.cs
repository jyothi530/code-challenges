using Jan162017.State;
using System.Collections.Generic;
using Jan162017.Visitor;

namespace Jan162017
{
    public class Account
    {
        public double Balance { get; set; }

        public double CashBack { get; set; }

        public AccountType.AccountType AccountType { get; set; }

        public AccountState State { get; set; }

        public IList<Transaction> Transactions { get; set; }

        public void Deposit(double amount)
        {
            State.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            State.Withdraw(amount);
        }

        public void PayInterest()
        {
            State.PayInterest();
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void PayCashback()
        {
            Accept(new CashbackVisitor());
        }

        public void Open(double openingBalance, AccountType.AccountType type, AccountState state)
        {
            Balance = openingBalance;
            AccountType = type;
            State = state;

            Transactions = new List<Transaction>
            {
                new Transaction
                {
                    AccountState = state,
                    AccountType = type,
                    Amount = openingBalance,
                    Type = TransactionType.Open
                }
            };
        }
    }
}
