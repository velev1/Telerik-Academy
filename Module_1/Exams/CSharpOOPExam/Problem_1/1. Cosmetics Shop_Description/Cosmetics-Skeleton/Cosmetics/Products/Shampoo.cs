namespace Cosmetics.Products
{
    using System;
    using System.Text;
        
    using Common;
    using Contracts;

    public class Shampoo : Product, IShampoo, IProduct
    {
        private uint milliliters;
        private UsageType usage;

        public Shampoo(string name, string brand, decimal price, GenderType gender, uint milliliters, UsageType usage)
            : base(name, brand, price, gender)
        {                                                                                            
            this.Milliliters = milliliters;
            this.Usage = usage;
            this.Price = this.SetPrice(price);
        }       

        public uint Milliliters
        {
            get 
            {
               return this.milliliters;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Shampoo's quantity should be greater than 0 ml!");
                }

                this.milliliters = value;
            }
        }

        public UsageType Usage
        {
            get 
            {
                return this.usage;
            }
            private set
            {
                this.usage = value;
            }
        }

        public override string ToString()
        {
            string quantity = string.Format("  * Quantity: {0} ml", this.Milliliters);
            string usage = string.Format("  * Usage: {0}", this.Usage.ToString());

            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine(quantity);
            sb.Append(usage);
            return sb.ToString();
        }

        private decimal SetPrice(decimal price)
        {
            decimal shampooPrice = price * this.Milliliters;
            return shampooPrice;
        }
    }
}
