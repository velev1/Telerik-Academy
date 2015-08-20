namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Text;
        
    using Common;
    using Contracts;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const string ErrorMessageNullIngrdients = "Thootphaste must have ingredients";
        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            Validator.CheckIfNull(ingredients, ErrorMessageNullIngrdients);
            this.ingredients = ingredients;
        }
                
        public string Ingredients
        {
            get 
            {
                return string.Join(", ", this.ingredients);
            }           
        }

        public override string ToString()
        {
            string ingredients = string.Format("  * Ingredients: {0}", this.Ingredients);            

            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append(ingredients);

            return sb.ToString();
        }
    }
}
