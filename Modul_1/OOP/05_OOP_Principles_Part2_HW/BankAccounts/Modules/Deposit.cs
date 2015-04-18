namespace Bank.Modules
{
    using System;
    using Bank.Interfaces;
    
    public class Deposit : Account, IInterest
    {    
        // const for the minimu balnce that give interests
        private const decimal MinBlanceForInterests = 1000m;

        // constructor
        public Deposit(string accountID, decimal intestRate, Customer customer)
            : base(accountID, intestRate, customer)
        { 
        }

        // method for withdraw money
        public void Withdraw(decimal amount)
        {
            if (this.Balance - amount < 0m)
            {
                throw new ArgumentException("Insuficient money for the operation", this.Balance.ToString());
            }
            else
            {
                this.Balance -= amount;
            }
        }

        // implementation of the method for calculation of interests
        public override decimal CalculateIntersetAmount(int months)
        {
            if (this.Balance < MinBlanceForInterests)
            {
                return 0m;
            }
            else
            {
                decimal inerest = this.Balance * (decimal)months * this.InterestRate;
                return inerest;
            }
        }
    }
}
