namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    
    using Common;
    using Contracts;
        
    public class ShoppingCart : IShoppingCart
    {
        private IList<IProduct> shoppingChartProducts;

        public ShoppingCart()
        {
            this.shoppingChartProducts = new List<IProduct>();
        }

        public void AddProduct(IProduct product)
        {            
            Validator.CheckIfNull(product, "Cannot add anull product to shopping chart!");
            this.shoppingChartProducts.Add(product);
        }

        public void RemoveProduct(IProduct product)
        {            
            (this.shoppingChartProducts as List<IProduct>).Remove(product);
        }

        public bool ContainsProduct(IProduct product)
        {
            return this.shoppingChartProducts.Contains(product);
        }

        public decimal TotalPrice()
        {
            decimal totalPrice = 0m;
            foreach (var product in this.shoppingChartProducts)
            {
                totalPrice += product.Price;
            }

            return totalPrice;
        }
    }
}
