namespace Bank.Modules
{
    using System;
    using Bank.Interfaces;

    public abstract class Account : IInterest
    {
        // fields
        private string accountID;
        private decimal balance;
        private decimal interestRate;
        private Customer customer;

        // constructor
        public Account(string accountID, decimal intesrestRate, Customer customer)
        {
            this.AccountID = accountID;
            this.InterestRate = intesrestRate / 100m;
            this.Customer = customer;
            this.balance = 0m; // assume that the accaoun is initialised the initial balance is 0.00
        }

        // properties
        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            protected set
            {
                this.customer = value;
            }
        }

        public string AccountID
        {
            get
            {
                return this.accountID;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Account ID can not be null or empty!");
                }

                // TO DO - check for unique Account ID or autamatic set
                this.accountID = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            set
            {
                this.interestRate = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            protected set
            {
                this.balance = value;
            }
        }

        // methods
        public void DepositMoney(decimal depoitAmount)
        {
            this.Balance += depoitAmount;
        }

        // not implemet the method from IInterest because this calss is abstract 
        public abstract decimal CalculateIntersetAmount(int months);

        // override ToString method (Customer's ToStrig is overrided also)
        public override string ToString()
        {
            return "Account ID: " + this.AccountID + Environment.NewLine + this.Customer + Environment.NewLine + "Balance: " + this.Balance;
        }
    }
}
