namespace School
{
    using System;
    using System.Collections.Generic;

    public class Person : ICommentBox
    {
        // fields
        private string firstName;
        private string lastName;

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
                    throw new ArgumentException("First name must have at least one symbol!");
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
                    throw new ArgumentException("Last name must have at least one symbol!");
                }

                this.lastName = value;
            }
        }

        public string FullName
        {
            get
            {
                return this.firstName + " " + this.lastName;
            }
        }

        // CommentBox stuff
        public List<string> FreeTextBox { get; protected set; }

        public void AddFreeTextMessage(string text)
        {
            this.FreeTextBox.Add(text);
        }
    }
}
