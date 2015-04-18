namespace AnimalHierarchy
{
    using System;

    public class Frog : Animal, ISound
    {
        // constructors
         public Frog(string name, int age)
             : base(name, age)
        {          
        }

         public Frog(string name, int age, Sex sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        // methods
         public override string Sound()
        {
            return "I'm froggy";
        }

         public override string ToString()
         {
             return base.ToString() + " - " + this.Sound();
         }
    }
}
