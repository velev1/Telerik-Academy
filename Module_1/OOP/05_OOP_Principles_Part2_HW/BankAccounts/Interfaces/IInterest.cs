namespace Bank.Interfaces
{
    using System;

    public interface IInterest
    {
        // interface for interests (not shure that this is necessary but you can't calculate rates without interest rate)
        decimal InterestRate {get; set;}
                
        decimal CalculateIntersetAmount(int months);
    }
}
