namespace Jan162017.AccountType
{
    public class GoldAccount : AccountType
    {
        public GoldAccount(Account account) : base(account)
        {
            MinimumBalance = 0;
            CashBackPct = 0.01;
            InterestRate = 0.03;
            Penalty = 0;
        }
    }
}
