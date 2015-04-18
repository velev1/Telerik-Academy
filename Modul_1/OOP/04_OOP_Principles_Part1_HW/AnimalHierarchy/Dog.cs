namespace AnimalHierarchy
{
    using System;

    public class Dog : Animal, ISound
    {
        // constructors
        public Dog(string name, int age)
            : base(name, age)
        {           
        }

        public Dog(string name, int age, Sex sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        // methods
        public override string Sound()
        {
            return "I'm doggy";
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.Sound();
        }
    }
}
