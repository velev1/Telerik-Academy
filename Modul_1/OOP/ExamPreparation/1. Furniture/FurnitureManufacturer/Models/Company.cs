namespace FurnitureManufacturer.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentException("Company name could not be empty and should be at least 5 symbols!");
                }

                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get
            {
                return this.registrationNumber;
            }

            private set
            {
                if (string.IsNullOrEmpty(value ) || RegistrationNumberInvalid(value))
                {
                    throw new ArgumentException("Invalid registration code (should be exactly 10 digits)!");
                }

                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return this.furnitures;
            }
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            foreach (var furniture in this.Furnitures)
            {
                if (model.ToLower() == furniture.Model.ToLower())
                {
                    return furniture;
                }
            }

            return null;
        }

        public string Catalog()
        {
            return string.Format("{0} - {1} - {2} {3}",
                                    this.Name,
                                    this.RegistrationNumber,
                                    this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                                    this.Furnitures.Count != 1 ? "furnitures" : "furniture");
        }

        private static bool RegistrationNumberInvalid(string param)
        {
            if (param.Length != 10)
	        {
		         return true;
	        }

            foreach (char symbol in param)
            {
                if (!char.IsDigit(symbol))
                {
                    return true;
                }
            }

            return false;
        }

        //public override string ToString()
        //{
        //    return string.Format("{0} - {1} - {2} {3}",
        //                            this.Name,
        //                            this.RegistrationNumber,
        //                            this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
        //                            this.Furnitures.Count != 1 ? "furnitures" : "furniture");
        //}
    }
}
