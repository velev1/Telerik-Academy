namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShapesMain
    {
        private static void Main()
        {
            // iniciales list of shapes
            var shapes = new List<Shape>();

            // adding some shapes to the list
            shapes.Add(new Triangle(2.0, 3.0));
            shapes.Add(new Rectangle(2.0, 3.0));
            shapes.Add(new Square(2.0));

            // using LINQ print type name and surface of the shape
            shapes.ForEach(
                shape => Console.WriteLine(
                                    string.Format(
                                            "{0} surface - {1}",
                                            shape.GetType().Name, 
                                            shape.CalculateSurface())));
        }
    }
}
