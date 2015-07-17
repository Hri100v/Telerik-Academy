using System;

public class Program
{
    public struct Size
    {
        public double width { get; private set; }
        public double height { get; private set; }

        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }

    public static Size RotateSize(Size size, double angle)
    {
        double sin = Math.Abs(Math.Sin(angle));
        double cos = Math.Abs(Math.Cos(angle));

        return new Size(
            (sin * size.width) - (cos * size.height),
            (sin * size.width) + (cos * size.height)
            );
    }
}
