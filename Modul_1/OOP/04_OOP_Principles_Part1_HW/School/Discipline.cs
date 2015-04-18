namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Discipline : ICommentBox
    {
        // fields
        private string name;
        private int lectionsCount;
        private int exercisesCount;

        // constructor
        public Discipline(string name, int lections, int exerxises)
        {
            this.Name = name;
            this.LectionsCount = lections;
            this.ExercisesCount = exerxises;
        }

        // properties
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("The discipline name can not be less than two symbols");
                }

                this.name = value;
            }
        }

        public int LectionsCount
        { 
             get
            {
                return this.lectionsCount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The discipline;s lections count can not be negative number");
                }

                this.lectionsCount = value;
            }
        }

        public int ExercisesCount
        {
            get
            {
                return this.exercisesCount;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The discipline's exercises count can not be negative number");
                }

                this.exercisesCount = value;
            }
        }

        public List<string> FreeTextBox { get; private set; }

        // methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Name : {0}", this.Name));
            sb.AppendLine(string.Format("Lections : {0}", this.lectionsCount));
            sb.AppendLine(string.Format("Exerxises : {0}", this.exercisesCount));

            return sb.ToString();
        }
        
        public void AddFreeTextMessage(string text)
        {
            this.FreeTextBox.Add(text);
        }
    }
}
