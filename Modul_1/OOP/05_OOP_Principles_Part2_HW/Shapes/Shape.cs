namespace Shapes
{
    using System;

    public abstract class Shape
    {
        // fields
        private double width;
        private double hight;

        // protected constructor because the class is abstrac and can not be inicialised anyway
        protected Shape(double width, double hight)
        {
            this.Width = width;
            this.Hight = hight;
        }

        // properties
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The width can not  be negative");
                }

                this.width = value;
            }
        }

        public double Hight
        {
            get
            {
                return this.hight;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The width can not  be negative");
                }

                this.hight = value;
            }
        }

        // not implemented abstrac method - to implemented by this class childs
        public abstract double CalculateSurface();
    }
}
