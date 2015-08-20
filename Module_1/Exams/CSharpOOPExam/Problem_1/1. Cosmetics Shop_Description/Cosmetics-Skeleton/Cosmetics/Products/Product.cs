namespace Cosmetics.Products
{
    using System;
    using System.Text;
        
    using Common;
    using Contracts;

    public abstract class Product : IProduct
    {   
        private const string ErrorMessageName = "Product name"; 
        private const int MinNameSymbolsName = 3;
        private const int MaxManeSymbolsName = 10;
        private const string ErrorMessageBrand = "Product brand";
        private const int MinNameSymbolsBrand = 2;
        private const int MaxManeSymbolsBrand = 10;

        private string name;
        private string brand;
        private decimal price;
        private GenderType gender;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, 
                    ExeptionMassages.LengthErrorMessage(Product.ErrorMessageName, Product.MinNameSymbolsName, Product.MaxManeSymbolsName));
                Validator.CheckIfStringLengthIsValid(value, 
                    MaxManeSymbolsName, 
                    MinNameSymbolsName, 
                    ExeptionMassages.LengthErrorMessage(Product.ErrorMessageName,Product.MinNameSymbolsName, Product.MaxManeSymbolsName));

                this.name = value;
            }
        }

        public string Brand
        {
            get 
            {
                return this.brand;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value,
                    ExeptionMassages.LengthErrorMessage(Product.ErrorMessageBrand, Product.MinNameSymbolsBrand, Product.MaxManeSymbolsBrand));
                Validator.CheckIfStringLengthIsValid(value,
                    MaxManeSymbolsBrand,
                    MinNameSymbolsBrand,
                    ExeptionMassages.LengthErrorMessage(Product.ErrorMessageBrand, Product.MinNameSymbolsBrand, Product.MaxManeSymbolsBrand));
                this.brand = value;
            }
        }

        public decimal Price
        {
            get 
            {
                return this.price; 
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price can not be negative value!");
                }

                this.price = value;
            }
        }

        public GenderType Gender
        {
            get
            {
                return this.gender;
            }
            private set
            {
                this.gender = value;
            }
        }

        public string Print()
        {
            return this.ToString();         
        }

        public override string ToString()
        {              
            string brandAndName = string.Format("- {0} - {1}:", this.Brand, this.Name);
            string price = string.Format("  * Price: ${0:0.00}", this.price);
            string forGender = string.Format("  * For gender: {0}", this.Gender.ToString());

            var sb = new StringBuilder();
            sb.AppendLine(brandAndName);
            sb.AppendLine(price);
            sb.Append(forGender);

            return sb.ToString();
        }

        // TODO: make shure that is needed for romoving products from catalog and shopping chart
        public override bool Equals(object obj)
        {
            if ((obj as Product).Name == this.Name &&
                (obj as Product).Price == this.Price &&
                (obj as Product).Brand == this.Brand &&
                (obj as Product).Gender == this.Gender)
            {
                return true;
            }

            return false;
        }
    }
}
