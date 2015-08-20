using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal, ISound
    {
        // constructors
        public Cat(string name, int age)
            : base(name, age)
        {
        }

        public Cat(string name, int age, Sex sex)
            : this(name, age)
        {
            this.Sex = sex;
        }

        // methods
        public override string Sound()
        {
            return "I'm catty";
        }

        public override string ToString()
        {
            return base.ToString() + " - " + this.Sound();
        }
    }
}
