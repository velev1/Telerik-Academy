namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Class : ICommentBox
    {
        // fields
        private List<Student> classStudents;
        private List<Teacher> classTeachers;
        private string identifier;

        // constructors
        public Class(string id)
        {
            this.ClassStudents = new List<Student>();
            this.ClassTeachers = new List<Teacher>();
            this.Identifier = id;
        }

        public Class(string id, List<Student> students, List<Teacher> teachers)
           : this(id)
        { 
            this.ClassStudents = new List<Student>(students);
            this.ClassTeachers = new List<Teacher>(teachers);
        }

        // properties
        public List<Student> ClassStudents 
        { 
            get
            {
                return this.classStudents;
            }

            set
            {
                this.classStudents = value;
            }
        }

        public List<Teacher> ClassTeachers
        {
            get
            {
                return this.classTeachers;
            }

            set
            {
                this.classTeachers = value;
            }
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            set
            {
                if (ClassesID.CheckID(value))
                {
                    throw new ArgumentException("This identifier is already in use");
                }
                else if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The identifier can not be empty");
                }
                else
                {
                     this.identifier = value;
                }
            }
        }

        public List<string> FreeTextBox { get; private set; }

        // methods
        public void AddFreeTextMessage(string text)
        {
            this.FreeTextBox.Add(text);
        }

        public void AddTeacher(Teacher newTeacher)
        {
            this.classTeachers.Add(newTeacher);
        }

        public void AddStudent(Student newStuden)
        {
            this.ClassStudents.Add(newStuden);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Class identifier : {0}", this.Identifier));
            sb.AppendLine(string.Format("Teachers : \n{0}", string.Join("\n", this.classTeachers)));
            sb.AppendLine(string.Format("Students : \n{0}", string.Join("\n", this.classStudents)));

            return sb.ToString();
        }
    }
}
