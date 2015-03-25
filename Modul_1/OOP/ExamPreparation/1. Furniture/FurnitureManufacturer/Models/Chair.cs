namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture, IFurniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cahir can not have negative number of legs!"); // Eventually to change min legs to 1
                }

                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("Legs: {0}", this.NumberOfLegs);
        }
    }
}
