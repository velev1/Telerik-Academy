namespace Bank.Modules
{
    using Bank.Interfaces;

    public class Loan : Account, IInterest
    {
        // constants
        private const int GratisPeriodPrivateClients = 3;
        private const int GratisPeriodCorporatClients = 2;

        // constructor
        public Loan(string accountID, decimal intestRate, Customer customer)
            : base(accountID, intestRate, customer)
        { 
        }

        // implementation of the method for calculation of interests
        public override decimal CalculateIntersetAmount(int months)
        {
            if (this.Customer is CorporateCustomer)
            {
                if (months < GratisPeriodCorporatClients)
                {
                    return 0m;
                }
                else
                {
                    return this.CalcInterests(months, GratisPeriodCorporatClients);
                }
            }
            else
            {
                if (months < GratisPeriodPrivateClients)
                {
                    return 0m;
                }
                else
                {
                    return this.CalcInterests(months, GratisPeriodPrivateClients);
                }
            }
        }

        // private method for calculating the interests
        private decimal CalcInterests(int months, int gratisPeriod)
        {
            return this.Balance * (decimal)(months - gratisPeriod) * this.InterestRate;
        }
    }
}
