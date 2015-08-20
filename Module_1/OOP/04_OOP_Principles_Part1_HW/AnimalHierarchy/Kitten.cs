namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat, ISound
    {
        // constructor wit automatic set of sex
        public Kitten(string name, int age)
            : base(name, age)
        {
            this.Sex = Sex.Female;
        }

        // methods
        public override string Sound()
        {
            return "I'm A Pussy Cat";
        }
    }
}
