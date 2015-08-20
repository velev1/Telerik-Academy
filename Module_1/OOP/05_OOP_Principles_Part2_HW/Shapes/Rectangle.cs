namespace Shapes
{
    public class Rectangle : Shape
    {
        // constructor
        public Rectangle(double width, double hight)
            : base(width, hight)
        {
        }

        // public method for calculating surface
        public override double CalculateSurface()
        {
            return this.Hight * this.Width;
        }
    }
}
