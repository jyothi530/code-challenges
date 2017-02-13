namespace Jan162017.State
{
    public abstract class AccountState
    {
        public Account Account { get; set; }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

        public abstract void PayInterest();
    }
}
