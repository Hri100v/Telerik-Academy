/*Problem 4. Rectangles

Write an expression that calculates rectangle’s perimeter and area by given width and height.
Examples:

width	height	perimeter	area
3	    4	    14	        12
2.5	    3	    11	        7.5
5	    5	    20	        25
 */

using System;

    class calcRectangle
    {
        static void Main()
        {
            Console.WriteLine("Calculation of perimeter and area of rectangle.");
            Console.WriteLine("Give dimension of one side");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Give another side");
            double b = double.Parse(Console.ReadLine());

            double rectPer = 2*(a + b);
            double rectArea = a * b;
           

            string w = "width";
            string h = "height";
            string p = "perimeter";
            string ar = "area";

            Console.WriteLine();
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10}", w, h, p, ar);
            Console.WriteLine("{0,-10} | {1,-10} | {2,-10} | {3,-10}", a, b, rectPer, rectArea);
  
        }
    }

