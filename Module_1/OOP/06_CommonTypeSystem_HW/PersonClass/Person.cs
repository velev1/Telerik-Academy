namespace PersonClass
{
    using System.Text;

    public class Person
    {
        // fields
        private string name;
        private byte? age; // nullable byte? for age (255 looks enough for person's age)

        // constructors
        public Person(string name)
        {
            this.Name = name;

            // do not set this.Age to null because the default vale of nullable byte, int, long etc. is null not 0
        }

        public Person(string name, byte? age)
            : this(name)
        {
            this.Age = age;
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
                this.name = value;
            }
        }

        public byte? Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        // public methods incl overrides
        public override string ToString()
        {
            // it cud be done without StringBuilder on one line and maybe is the better way
            // string sb = string.Format("Name: {0}\nAge: {1}", this.Name, this.Age != null ? this.Age.ToString() : "Not set");
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(string.Format("Name: {0}", this.Name));
            sb.Append(string.Format("Age: {0}", this.Age != null ? this.Age.ToString() : "Not set"));

            return sb.ToString();
        }
    }
}
