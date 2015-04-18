namespace Bank.Modules
{
    using System;
    using Bank.Interfaces;

    public class CorporateCustomer : Customer
    {
        // fields
        private string companyName;
        private string companyID;

        // constructur
        public CorporateCustomer(string companyName, string companyID, string bankID)
            : base(bankID)
        {
            this.CompanyName = companyName;
            this.CompanyID = companyID;
            this.Owner = this.CompanyName;
        }

        // properties
        public string CompanyName
        {
            get
            {
                return this.companyName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Company name can not be null or empty!");
                }

                this.companyName = value;
            }
        }

        public string CompanyID
        {
            get
            {
                return this.companyID;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Company ID can not be null or empty!");
                }

                // TO DO - check for correct ID
                this.companyID = value;
            }
        }
    }
}