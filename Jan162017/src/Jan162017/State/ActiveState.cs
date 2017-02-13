using Jan162017.Visitor;

namespace Jan162017.State
{
    public class ActiveState : AccountState
    {
        private readonly Account _account;

        public ActiveState(Account account)
        {
            _account = account;
        }

        public override void Deposit(double amount)
        {
            _account.AccountType.Deposit(amount);
        }

        public override void Withdraw(double amount)
        {
            _account.AccountType.Withdraw(amount);
        }

        public override void PayInterest()
        {
            _account.Accept(new InterestVisitor());
        }
    }
}
