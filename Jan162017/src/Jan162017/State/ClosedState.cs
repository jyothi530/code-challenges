using System;

namespace Jan162017.State
{
    public class ClosedState : AccountState
    {
        public ClosedState(Account account)
        {
            
        }

        public override void Deposit(double amount)
        {
            Console.WriteLine("No transaction Can be made!!");
        }

        public override void Withdraw(double amount)
        {
            Console.WriteLine("No transaction Can be made!!");
        }

        public override void PayInterest()
        {
            Console.WriteLine("Interest cannot be calculated for In-Active accounts");
        }
    }
}
