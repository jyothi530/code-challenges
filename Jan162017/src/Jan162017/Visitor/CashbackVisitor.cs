using System.Linq;

namespace Jan162017.Visitor
{
    public class CashbackVisitor : IVisitor
    {
        public void Visit(Account account)
        {
            account.CashBack = account.Transactions.Sum(transaction => transaction.Cashback);
        }
    }
}
