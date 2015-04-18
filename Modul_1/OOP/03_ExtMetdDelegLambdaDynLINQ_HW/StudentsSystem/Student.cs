namespace StudentsSystem
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    // Problem 9. Student groups
    // Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime birthDate { get; set; }
        public int FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<double>  Marks { get; set; }
        public int Age { get { return this.CalculateAge(); } }
        public Group Group { get; set; }

        public Student(string firstName, string lastName, DateTime bd, int fN, string tel, string eMail, List<double> marks, int groupNumber, Departments
            department)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.birthDate = bd;
            this.FN = fN;
            this.Tel = tel;
            this.Email = eMail;
            this.Marks = marks;
            this.Group = new Group(groupNumber, department);
        }

        private int CalculateAge()
        {
            int age = (DateTime.Now.Date - this.birthDate.Date).Days / 365;

            return age;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format("Name: {0} {1}", this.FirstName, this.LastName));
            sb.AppendLine(string.Format("FN: {0}", this.FN));
            sb.AppendLine(string.Format("Age: {0}", this.Age));
            sb.AppendLine(string.Format("Tel.: {0}", this.Tel));
            sb.AppendLine(string.Format("Email: {0}", this.Email));
            sb.AppendLine(string.Format("Marks: {0}", string.Join(", ", this.Marks)));
            sb.AppendLine(string.Format("GroupNumber: {0}", this.Group.GroupNumber));
            sb.AppendLine(string.Format("Department name: {0}", this.Group.DepartmentName));

            return sb.ToString();
        }
    }
}
