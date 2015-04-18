namespace Points
{
    using System;

    public class PointsMainTests
    {
        public static void Main()
        {
            // set and print test Point3D
            Point3D testPoint = new Point3D(1, 2, 3);
            System.Console.WriteLine(testPoint);

            // set test Path
            Path testPath = new Path();
            testPath.AddPionts(new Point3D(1, 1, 1), new Point3D(2, 2, 2), new Point3D(3, 3, 3), new Point3D(4, 4, 4));
            
            // print test Path
            Console.WriteLine();
            Console.WriteLine(testPath);

            // saves the test Path to "..\..\testPath.txt"
            PathStorage.SavePath(testPath, "testPath");

            // load currently saved test Path from "..\..\testPath.txt"
            Path loadedPath = PathStorage.LoadPath("testPath");

            // print loaded Path
            Console.WriteLine();
            Console.WriteLine(loadedPath);
        }
    }
}
