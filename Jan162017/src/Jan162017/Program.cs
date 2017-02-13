using System;
using Jan162017.AccountType;
using Jan162017.State;

namespace Jan162017
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var account = new Account();

            account.Open(1000, new GoldAccount(account), new InOperativeState(account));

            account.Deposit(5000);
            account.Withdraw(3000);
            account.AccountType = new DiamondAccount(account);
            account.Deposit(1000);
            account.PayInterest();
            account.PayCashback();

            Console.WriteLine("Balance:{0}, Cashback:{1}", account.Balance, account.CashBack);
        }
    }
}
