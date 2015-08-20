namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double hight)
            : base(width, hight)
        {
        }

        public override double CalculateSurface()
        {
            return (this.Hight * this.Width) / 2;
        }
    }
}
