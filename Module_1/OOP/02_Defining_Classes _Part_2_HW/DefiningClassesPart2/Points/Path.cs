namespace Points
{
    using System;
    using System.Collections.Generic;

    // Problem 4. Path
    // Create a class Path to hold a sequence of points in the 3D space.
    // Create a static class PathStorage with static methods to save and load paths from a text file.
    // Use a file format of your choice.
    public class Path
    {
        // fields
        private List<Point3D> pointsCollection;

        // constructor
        public Path()
        {
            this.pointsCollection = new List<Point3D>();
        }

        // indexer
        public Point3D this[int index]
        {
            get
            {
                return this.pointsCollection[index];
            }

            set
            {
                this.pointsCollection[index] = value;
            }
        }

        // public methods
        public void AddPoint(Point3D newPoin)
        {
            this.pointsCollection.Add(newPoin);
        }

        public void RemovePintAtIndex(int index)
        {
            this.pointsCollection.RemoveAt(index);
        }

        public void AddPionts(params Point3D[] points)
        {
            this.pointsCollection.AddRange(points);
        }

        public override string ToString()
        {
            return string.Join(" - ", this.pointsCollection);
        }
    }
}