namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat, ISound
    {
        // constructor wit automatic set of sex
        public Tomcat(string name, int age)
            : base(name, age)
        {
            this.Sex = Sex.Male;
        }

        // methods
        public override string Sound()
        {
            return "Tom, Tomcat";
        }
    }
}
