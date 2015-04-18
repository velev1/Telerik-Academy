namespace Points
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        // static methods
        public static void SavePath(Path path, string nameOfPath)
        {
            string pathLocation = string.Format(@"..\..\{0}.txt", nameOfPath.Trim());
            using (StreamWriter writer = new StreamWriter(pathLocation))
            {
                writer.Write(path);
            }
        }

        public static Path LoadPath(string nameOfPath)
        {
            Path path = new Path();
            string pathLocation = string.Format(@"..\..\{0}.txt", nameOfPath.Trim());

            using (StreamReader reader = new StreamReader(pathLocation))
            {
                string[] points = reader
                    .ReadToEnd()
                    .Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var point in points)
                {
                    double[] c = point
                        .Split(new char[] { '(', ')', ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(double.Parse)
                        .ToArray();

                    path.AddPionts(new Point3D(c[0], c[1], c[2]));
                }
            }

            return path;
        }
    }
}
