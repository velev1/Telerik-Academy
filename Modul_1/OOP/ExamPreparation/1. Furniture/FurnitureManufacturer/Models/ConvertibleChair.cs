namespace FurnitureManufacturer.Models
{
    using System;

    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IFurniture, IConvertibleChair
    {
        private decimal initialHeiht;
        private bool isConverted;

        public ConvertibleChair(string model, string material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.initialHeiht = this.Height;
        }

        public bool IsConverted
        {
            get 
            {
                return this.isConverted;
            }

            private set 
            {
                this.isConverted = value;
            }

        }

        public void Convert()
        {
            this.IsConverted = !this.IsConverted;
            if (isConverted)
            {
                this.Height = 0.10m;
            }
            else
            {
                this.Height = initialHeiht;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format(", State: {0}", this.IsConverted ? "Converted" : "Normal");
        }
    }
}
