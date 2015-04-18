namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
        
    using Common;
    using Contracts;

    public class Category : ICategory
    {
        private const string ErrorMessageName = "Category name must be between 2 and 15 symbols long!";
        private const int MinNameSymbolsName = 2;
        private const int MaxManeSymbolsName = 15;

        private string name;
        private IList<IProduct> cosmeticsInCategory;

        public Category(string name)
        {
            this.Name = name;
            this.cosmeticsInCategory = new List<IProduct>();
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, ErrorMessageName);
                Validator.CheckIfStringLengthIsValid(value, MaxManeSymbolsName, MinNameSymbolsName, ErrorMessageName);
                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, "Cannot add null poroduct to category!");
            this.cosmeticsInCategory.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {            
            if (!this.cosmeticsInCategory.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.cosmeticsInCategory.Remove(cosmetics);
        }

        public string Print()
        {
           return this.ToString();
        }

        public override string ToString()
        {
            string nameAndProductsCount = string.Format("{0} category - {1} {2} in total",
                this.Name,
                this.cosmeticsInCategory.Count,
                this.cosmeticsInCategory.Count == 1 ? "product" : "products");

            var sb = new StringBuilder();
            sb.AppendLine(nameAndProductsCount);

            // TODO: evventually to set the ordering when adding product or use ostred list and override produce CompareTo;
            var sortedProducts = this.cosmeticsInCategory.OrderBy(p => p.Brand).ThenByDescending(p => p.Price);
            foreach (var product in sortedProducts)
            {
                // TODO: maybe to use product Print() mesthod of product;
                sb.AppendLine(product.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
