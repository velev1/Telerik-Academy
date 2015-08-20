namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Linq;

    public class Student : Person
    {

        private static IEnumerable<string> usedNums = new HashSet<string>();

        // fields
        private int classNumber;
        private string testNumber;

        // constructors
        public Student(string firstName, string lastName, string testnumbet)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ClassNumber = StudentID.NextID();
            this.FreeTextBox = new List<string>();
            this.TestNumber = testnumbet;
        }

        public string TestNumber
        {
            get
            {
                return this.testNumber;
            }

            private set
            {
                if (usedNums.Contains(value))
                {
                    throw new ArgumentException("TestID already exist");
                }

                this.testNumber = value;
                usedNums.Add(value);
            }
        }
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                this.classNumber = value;
            }
        }

        // methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Name : {0}", this.FullName));
            sb.AppendLine(string.Format("Class number : {0}", this.classNumber));

            return sb.ToString();
        }
    }
}
