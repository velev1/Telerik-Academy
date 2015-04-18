namespace Bank.Modules
{
    using Bank.Interfaces;

    public class Mortgage : Account, IInterest
    {
        // constants
        private const int GratisPeriodPrivateClients = 6;
        private const int GratisPeriodCorporatClients = 12;

        // constructor
        public Mortgage(string accountID, decimal intestRate, Customer customer)
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
                    return this.CalcGratisPreiodInterests(months);
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
                    return this.CalcGratisPreiodInterests(months);
                }
                else
                {
                    return this.CalcInterests(months, GratisPeriodPrivateClients);
                }
            }
        }

        // private methods for calculating the interests
        private decimal CalcInterests(int months, int gratisPeriod)
        {
            decimal interests = this.Balance * gratisPeriod * (this.InterestRate / 2m);
            interests += this.Balance * (months - gratisPeriod) * (this.InterestRate / 2m);
            return interests;
        }
                
        private decimal CalcGratisPreiodInterests(int months)
        {
            decimal interests = this.Balance * months * (this.InterestRate / 2m);
            return interests;
        }
    }
}
