namespace StudentsAndWorkers
{
    using System;

    public class Student : Human
    {
        // fields
        private Grade grade;

        // constructors
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, Grade grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        // properties
        public Grade Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                this.grade = value;
            }
        }

        // metjods
        public void ChangeGrade(Grade grade)
        {
            this.Grade = grade;
        }
    }
}
