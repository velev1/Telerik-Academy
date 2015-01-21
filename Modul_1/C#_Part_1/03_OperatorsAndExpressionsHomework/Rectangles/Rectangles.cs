//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.
//Examples:

//width	height	perimeter	area
//3	4	14	12
//2.5	3	11	7.5
//5	5	20	25


namespace Rectangles
{
    using System;

    class Rectangles
    {
        static void Main()
        {
            Console.Write("Enter rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter rectangle's height: ");
            double height = double.Parse(Console.ReadLine());

            double perimeter = (2 * width) + (2 * height);
            double area = width * height;

            Console.WriteLine("Your rectange has perimeter {0} and area {1}", perimeter, area);


        }
    }
}
