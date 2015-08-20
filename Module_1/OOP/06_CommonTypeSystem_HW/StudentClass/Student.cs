namespace StudentClass
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        // constructor (first because in this case there are no fields and the properties sits after the constructors)
        public Student(string firstName, string middleName, string lastName,
            string ssn, string permanentAddres, string mobilePhone, string email,
            string coures, Specialty speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.PermanentAddres = permanentAddres;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Coures = coures;
            this.Specialty = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        // properties (just basic without any validations - do not do this at real world :))
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string PermanentAddres { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public string Coures { get; set; }
        public Specialty Specialty { get; set; }
        public University University { get; set; }
        public Faculty Faculty { get; set; }

        // public static methods first (incl overrides)
        public static bool operator ==(Student first, Student second)
        {
            return first.Equals(second);
        }

        public static bool operator !=(Student first, Student second)
        {
            return !first.Equals(second);
        }

        // public non static methods
        public object Clone()
        {
            Student clonedStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN,
                this.PermanentAddres, this.MobilePhone, this.Email, this.Coures, this.Specialty, this.University, this.Faculty);

            return clonedStudent;
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo(((Student)obj).FirstName) != 0)
            {
                return this.FirstName.CompareTo(((Student)obj).FirstName);
            }

            if (this.MiddleName.CompareTo(((Student)obj).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo(((Student)obj).MiddleName);
            }

            if (this.LastName.CompareTo(((Student)obj).LastName) != 0)
            {
                return this.LastName.CompareTo(((Student)obj).LastName);
            }

            if (this.SSN.CompareTo(((Student)obj).SSN) != 0)
            {
                return this.SSN.CompareTo(((Student)obj).SSN);
            }

            return 0;
        }

        public override bool Equals(object obj)
        {
            if (this.FirstName != ((Student)obj).FirstName ||
                this.MiddleName != ((Student)obj).MiddleName ||
                this.LastName != ((Student)obj).LastName ||
                this.SSN != ((Student)obj).SSN)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            int hashCode = this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() ^ this.LastName.GetHashCode() ^ this.SSN.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName));
            sb.AppendLine(string.Format("SSN: {0}", this.SSN));
            sb.AppendLine(string.Format("Addres: {0}", this.PermanentAddres));
            sb.AppendLine(string.Format("Tel: {0}", this.MobilePhone));
            sb.AppendLine(string.Format("Email: {0}", this.Email));
            sb.AppendLine(string.Format("Course: {0}", this.Coures));
            sb.AppendLine(string.Format("Speciality: {0}", this.Specialty));
            sb.AppendLine(string.Format("University: {0}", this.University));
            sb.AppendLine(string.Format("Faculty: {0}", this.Faculty));

            return sb.ToString().Trim();
        }
    }
}
