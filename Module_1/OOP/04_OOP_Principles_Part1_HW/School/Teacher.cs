namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Teacher : Person
    {
        // fields
        private List<Discipline> teachersDisciplines;

        // constructors
        public Teacher(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TeachersDisciplines = new List<Discipline>();
            this.FreeTextBox = new List<string>();
        }
        
        public Teacher(string firstName, string lastName, List<Discipline> disciplines)
            : this(firstName, lastName)
        {
            this.TeachersDisciplines = disciplines;
        }

        // properties
        public List<Discipline> TeachersDisciplines 
        { 
            get
            {
               return this.teachersDisciplines;
            }

            private set
            {
                this.teachersDisciplines = value;
            }
        }

        // methods
        public void AddDiscipline(Discipline dsc)
        {
            this.teachersDisciplines.Add(dsc);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Name : {0}", this.FullName));
            sb.AppendLine(string.Format("Disciplines : \n{0}", string.Join("\n", this.teachersDisciplines)));

            return sb.ToString();
        }
    }
}
