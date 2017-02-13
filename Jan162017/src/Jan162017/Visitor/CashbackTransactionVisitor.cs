namespace Jan162017.Visitor
{
    public class CashbackTransactionVisitor : ITransactionVisitor
    {
        public void Visit(Transaction transaction)
        {
            if(transaction.Type!=TransactionType.Deposit)
                return;

            transaction.Cashback = transaction.Amount * transaction.AccountType.CashBackPct;
        }
    }
}
