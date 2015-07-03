// Create a static class PathStorage with static methods to save and load paths from a text file.

using System;
using System.IO;

static class PathStorage
{
    private static readonly StreamReader reader = new StreamReader("../../file.txt");
    private static readonly StreamWriter writer = new StreamWriter("../../file.txt");


    // load file
    public static Path Load()
    {
        Path currentPath = new Path();
        using(reader)
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] num = line.Split(' ');

                Point3D currentPoint = new Point3D()
                {
                    X = double.Parse(num[0]),
                    Y = double.Parse(num[1]),
                    Z = double.Parse(num[2])
                };

                currentPath.AddPoint();

                line = reader.ReadLine();
            }
        }


        return currentPath;
    }


    public static void SaveFile(Path currentPath)
    {
        using (writer)
        {
            foreach (var item in currentPath.path)
            {
                string toBeWritten = string.Format("{0} {1} {2}", item.X, item.Y, item.Z);
                writer.WriteLine(toBeWritten);
            }
        }
    }

}

