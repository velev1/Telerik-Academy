namespace Bank
{
    using System;

    using Bank.Interfaces;
    using Bank.Modules;

    public class BankAccountsMain
    {
        public static void Main(string[] args)
        {
            // initialise new private customer and all types of accounts with it
            var privateGosho = new PrivateCustomer("Gosho", "Ubawetsa", "9005062452", "P0001620");
            var newDepositPrivate = new Deposit("DP00001", 1m, privateGosho);
            var newLoanPrivate = new Loan("LP00001", 20m, privateGosho);
            var newMortPrivate = new Mortgage("MP00001", 15m, privateGosho);

            // initialise ne corporate customer and all types of accounts with it
            var corporatePesho = new CorporateCustomer("Kurti ltd", "BG130607427", "C00012368");
            var newDepositCorp = new Deposit("DC00001", 0.5m, corporatePesho);
            var newLoanCorp = new Loan("LC00001", 30m, corporatePesho);
            var newMortCorp = new Mortgage("MC00001", 25, corporatePesho);

            // prit the corporate deposit account to ches the ToStrig() overriding
            Console.WriteLine(newDepositCorp);

            // deposit money to the corporatie deposit
            newDepositCorp.DepositMoney(2000m);

            // newDepositCorp.Withdraw(200m); // Shoud throw exeption (insufficient money)

            // prints the interest for 5 monts
            Console.WriteLine();
            Console.WriteLine(newDepositCorp.CalculateIntersetAmount(5));

            // deposit money to private loan
            newLoanPrivate.DepositMoney(100m);

            // print interest fow 2 monts for private loan
            Console.WriteLine();
            Console.WriteLine(newLoanPrivate.CalculateIntersetAmount(2));

            // and so on..
        }
    }
}
