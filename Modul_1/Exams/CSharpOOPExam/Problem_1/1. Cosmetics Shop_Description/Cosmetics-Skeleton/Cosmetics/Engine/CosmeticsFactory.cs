namespace Cosmetics.Engine
{
    using System.Collections.Generic;

    using Cosmetics.Common;
    using Cosmetics.Contracts;
    using Cosmetics.Products;

    public class CosmeticsFactory : ICosmeticsFactory
    {
        public ICategory CreateCategory(string name)
        {
            ICategory newCategory = new Category(name);
            return newCategory;
        }

        public IShampoo CreateShampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
        {
            IShampoo newShampoo = new Shampoo(name, brand, price, gender, milliliters, usage);
            return newShampoo;
        }

        public IToothpaste CreateToothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
        {
            IToothpaste newToothpaste = new Toothpaste(name, brand, price, gender, ingredients);
            return newToothpaste;
        }

        public IShoppingCart ShoppingCart()
        {
            IShoppingCart newShoppingChart = new ShoppingCart();
            return newShoppingChart;
        }
    }
}
