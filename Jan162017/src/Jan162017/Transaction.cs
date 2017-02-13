using Jan162017.State;
using Jan162017.Visitor;

namespace Jan162017
{
    public class Transaction
    {
        public double Amount { get; set; }

        public TransactionType Type { get; set; }

        public AccountType.AccountType AccountType { get; set; }

        public AccountState AccountState { get; set; }

        public double Cashback { get; set; }

        public void Accept(ITransactionVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public enum TransactionType
    {
        Deposit,

        Withdraw,

        Open
    }
}
