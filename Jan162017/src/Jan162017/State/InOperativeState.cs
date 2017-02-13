using System;

namespace Jan162017.State
{
    public class InOperativeState : AccountState
    {
        private readonly Account _account;

        public InOperativeState(Account account)
        {
            _account = account;
        }

        public override void Deposit(double amount)
        {
            _account.AccountType.Deposit(amount);
            ActivateAccount();
        }

        public override void Withdraw(double amount)
        {
            _account.AccountType.Withdraw(amount);
            ActivateAccount();
        }

        private void ActivateAccount()
        {
            _account.State = new ActiveState(_account);
        }

        public override void PayInterest()
        {
            Console.WriteLine("Interest cannot be calculated for In-Active accounts");
        }
    }
}
