namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;

    using FurnitureManufacturer.Interfaces;

    public abstract class Furniture : IFurniture
    {       
        private string model;
        private string material;
        private decimal price;
        private decimal height;

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get 
            {
                return this.model;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("MOdel can not be empty!");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Model sjhould have at least 3 symbols");
                }
                
                this.model = value;
            }
		 
	    }
 

        public string Material
        {
            get
            {
                return this.Material;
            }

            private set
            {
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price can not be zero or negative!");
                }

                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can not be zertp ot less!");
                }

                this.height = value;
            }           
        }

        public override string ToString()
        {
            return string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, ", this.GetType().Name, this.Model, this.Material, this.Price, this.Height);
        }
    }
}
