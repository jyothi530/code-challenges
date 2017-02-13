using System.Linq;
using Jan162017.State;

namespace Jan162017.Visitor
{
    public class InterestVisitor : IVisitor
    {
        public void Visit(Account account)
        {
            var activeTransactions =
                account.Transactions.Where(transaction => transaction.AccountState is ActiveState).ToList();

            var transactionsGroupByAccType =
                activeTransactions.GroupBy(transaction => transaction.AccountType.GetType().FullName)
                    .Select(grouping => new {Type = grouping.Key, Transactions = grouping.ToList()})
                    .ToList();

            foreach (var accTypeTransactions in transactionsGroupByAccType)
            {
                var transactions = accTypeTransactions.Transactions;

                var accountType = transactions.FirstOrDefault().AccountType;

                var depositAmount =
                    transactions.Where(
                            transaction =>
                                transaction.Type == TransactionType.Deposit || transaction.Type == TransactionType.Open)
                        .Sum(transaction => transaction.Amount);

                var withdrawAmount =
                    transactions.Where(transaction => transaction.Type == TransactionType.Withdraw)
                        .Sum(transaction => transaction.Amount);

                var balance = depositAmount - withdrawAmount;

                if(balance<0)
                    continue;

                var interestRate = balance * accountType.InterestRate;

                account.Balance += interestRate;
            }
        }
    }
}
