namespace ProblemStructure
{
    using System;

    public static class Calculations
    {
        
        public static void Print(Point3D p1, Point3D p2)
        {
            double? result;
            // 3 dimensional distance equation
            // d = √((x1 - x2)^2 + (y1 - y2)^2 + (z1 - z2)^2)
            result = (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y) + (p1.Z - p2.Z) * (p1.Z - p2.Z);
            result = Math.Sqrt((double)result);
            Console.WriteLine("The distance between 2 points is {0:F6}", result);

        }
    }
}
