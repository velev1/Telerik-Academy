namespace Points
{
    using System;

    // Problem 3. Static class
    // Write a static class with a static method to calculate the distance between two points in the 3D space.
    public static class Point3DTools
    {
        // static methods
        public static double CalculateDistance(Point3D p, Point3D q)
        {
            double distance = Math.Sqrt(((p.X - q.X) * (p.X - q.X)) + ((p.Y - q.Y) * (p.Y - q.Y)) + ((p.Z - q.Z) * (p.Z - q.Z)));
            return distance;
        }
    }
}
