namespace Jan162017.AccountType
{
    public class PlatinumAccount : AccountType
    {
        public PlatinumAccount(Account account) : base(account)
        {
            CashBackPct = 0.05;
            MinimumBalance = 25000;
            InterestRate = 0.06;
            Penalty = 5000;
        }
    }
}
