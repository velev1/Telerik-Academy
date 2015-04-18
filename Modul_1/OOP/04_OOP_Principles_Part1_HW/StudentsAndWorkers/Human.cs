namespace StudentsAndWorkers
{
    using System;

    public abstract class Human
    {
        // fields
        private string firstName;
        private string lastName;

        // protected constructor because the calss is abstract and can not made instance of it ayway
        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        // properties
        public string FirstName
        {
            get 
            {
                return this.firstName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name can not be empty!");
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

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name can not be empty!");
                }

                this.lastName = value;
            }
        }
    }
}
