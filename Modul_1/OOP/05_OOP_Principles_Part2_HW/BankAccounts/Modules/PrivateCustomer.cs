namespace Bank.Modules
{
    using System;

    using Bank.Interfaces;

    public class PrivateCustomer : Customer
    {
        // fields
        private string firstName;
        private string lastName;
        private string personalID;

        // constructor
        public PrivateCustomer(string firstName, string lastName, string personalID, string bankID)
            : base(bankID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PersonalID = personalID;
            this.Owner = this.FirstName + " " + this.LastName;
        }

        // properties
        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can not be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string PersonalID
        {
            get
            {
                return this.personalID;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can not be null or empty!");
                }

                // TO DO - check for correct id number    
                this.personalID = value;
            }
        }
    }
}
