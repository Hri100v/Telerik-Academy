using System;

namespace Methods
{
    class Methods
    {
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentOutOfRangeException("Sides should be positive.");
            }

            if (!(
                a < b + c &&
                b < a + c &&
                c < a + b
            ))
            {
                throw new ArgumentOutOfRangeException("Each side must be less than the sum of the other two.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        static string DigitToString(int digit)
        {
            switch (digit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentException("Invalid digit!");
            }
        }

        static int FindMax(params int[] array)
        {
            int max = array[0];
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty!");
            }

            for (int i = 1; i < array.Length; i++)
                if (array[i] > max)
                    max = array[i];

            return max;
        }

        /// <summary>
        /// That method represent the number in chossen format.
        /// </summary>
        /// <param name="number"></param>
        /// <param name="format"></param>
        static void ShowNumberInFormat(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
        }

        static void PrintWithDecimalPoint(object number)
        {
            Console.WriteLine("{0:f2}", number);
        }

        static void PrintWithPercent(object number)
        {
            Console.WriteLine("{0:p0}", number);
        }

        static void PrintWithRightAlignment(object number)
        {
            Console.WriteLine("{0,8}", number);
        }

        static double CalcDistance1(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        struct Point
        {
            public double X { get; private set; }
            public double Y { get; private set; }

            public Point(double x, double y)
                : this()
            {
                this.X = x;
                this.Y = y;
            }
        }

        static bool IsHorizontal(Point point1, Point point2)
        {
            return point1.Y == point2.Y;
        }

        static bool IsVertical(Point point1, Point point2)
        {
            return point1.X == point2.X;
        }

        static double CalcDistance(Point point1, Point point2)
        {
            double x = Math.Pow(point2.X - point1.X, 2);
            double y = Math.Pow(point2.Y - point1.Y, 2);
            double distance = Math.Sqrt(x + y);

            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(DigitToString(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintWithDecimalPoint(1.3);
            PrintWithPercent(0.75);
            PrintWithRightAlignment(2.30);

            Point point1 = new Point(3, -1);
            Point point2 = new Point(3, 2.5);
            Console.WriteLine(CalcDistance(point1, point2));
            Console.WriteLine("Horizontal? " + IsHorizontal(point1, point2));
            Console.WriteLine("Vertical? " + IsVertical(point1, point2));

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.BirthDate = new DateTime(1992, 03, 17);
            peter.OtherInfo = "From Sofia.";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.BirthDate = new DateTime(1993, 11, 03);
            stella.OtherInfo = "From Vidin, gamer.";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
