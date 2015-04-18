namespace Bank.Modules
{
    using System;

    public abstract class Customer
    {
        // fields
        private string bankID;
        private string owner;

        // constructor contais just BankID because owner is different for the heirs
        protected Customer(string bankID)
        {
            this.bankID = bankID;
        }

        // properties
        public string BankID
        {
            get 
            {
                return this.bankID;
            }

            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("BankID can not be null or empty!");
                }

                // TO DO - check for unique bankID or autamatic set
                this.bankID = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }

            set
            {
                this.owner = value;
            }
        }

        // ovveride the ToString method
        public override string ToString()
        {
            return "Owner: " + this.Owner + " - BankID: " + this.bankID;
        }
    }
}
