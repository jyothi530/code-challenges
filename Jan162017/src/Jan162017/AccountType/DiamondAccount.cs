namespace Jan162017.AccountType
{
    public class DiamondAccount : AccountType
    {
        public DiamondAccount(Account account) : base(account)
        {
            MinimumBalance = 5000;
            CashBackPct = 0.03;
            InterestRate = 0.04;
            Penalty = 1000;
        }
    }
}
