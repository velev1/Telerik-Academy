namespace MobileDevices
{
    using System;

    public class Display : Device
    {
        // fields
        private decimal size;
        private int colors;

        // constructors
        public Display(string setModel, Manufacturers setManifacturer)
            : base(setModel, setManifacturer)
        {
        }

        public Display(string setModel, Manufacturers setManifacturer, int setColors, decimal setSize)
            : this(setModel, setManifacturer)
        {
            this.Colors = setColors;
            this.Size = setSize; 
        }

        // properties
        public int Colors
        {
            get
            {
                return this.colors;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Colors cannot be less than zero!");
                }

                this.colors = value;
            }            
        }

        public decimal Size
        {
            get
            {
                return this.size;
            }

            private set
            {
                if (value < 0M)
                {
                    throw new ArgumentOutOfRangeException("Colors cannot be less than zero!");
                }

                this.size = value;
            }
        }
    }
}
