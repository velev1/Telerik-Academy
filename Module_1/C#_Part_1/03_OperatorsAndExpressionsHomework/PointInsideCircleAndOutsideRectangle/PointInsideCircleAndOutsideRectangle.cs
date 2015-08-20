//Problem 10. Point Inside a Circle & Outside of a Rectangle

//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
//Examples:

//x	y	inside K & outside of R
//1	2	yes
//2.5	2	no
//0	1	no
//2.5	1	no
//2	0	no
//4	0	no
//2.5	1.5	no
//2	1.5	yes
//1	2.5	yes
//-100	-100	no
//Problem 11. Bitwise: Extract Bit #3


namespace PointInsideCircleAndOutsideRectangle
{
    using System;

    class PointInsideCircleAndOutsideRectangle
    {
        static void Main()
        {
            Console.Write("Enter the x coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the y coordinate: ");
            double y = double.Parse(Console.ReadLine());
            const double radius = 1.5;
            bool inCircle = Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2) <= Math.Pow(radius, 2);
            bool inReact = ((x >= -1) && (x <= 5)) && ((y >= -1) && (y <= 1)) == false;
            bool result = inCircle && inReact == true;
            Console.WriteLine("Inside the circle and outside the reactangle: {0}", result);            
        }        
    }
}
