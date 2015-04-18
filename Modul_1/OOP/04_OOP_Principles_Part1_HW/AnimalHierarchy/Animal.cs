namespace AnimalHierarchy
{
    using System;

    public  abstract class Animal : ISound
    {
        // fields
        private string name;
        private int age;
        private Sex sex;

        // protected constructor because the calss is abstract and can not made instance of it ayway
        protected Animal(string name, int age)
        {
            this.Name = name;
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
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The animal's name can not be empty");
                }

                this.name = value;
            }

        }

        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Animal's name can not be empty");
                }

                this.age = value;
            }
        }

        public Sex Sex
        {
            get
            {
               return  this.sex;
            }

            set
            {
                this.sex = value;
            }
        }

        // virtual method
        public virtual string Sound()
        {
            return "A'm animal";
        }

        // override ToString()
        public override string ToString()
        {
            return this.GetType().Name + " " + this.Name;
        }
    }
}
