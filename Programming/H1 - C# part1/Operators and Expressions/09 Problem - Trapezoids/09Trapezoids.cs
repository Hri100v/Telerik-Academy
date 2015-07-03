/*Problem 9. Trapezoids

Write an expression that calculates trapezoid's area by given sides a and b and height h.
Examples:

a	    b	    h	    area
5	    7	    12	    72
2	    1	    33	    49.5
8.5	    4.3	    2.7	    17.28
100	    200	    300	    45000
0.222	0.333	0.555	0.1540125
 */

using System;

    class Trapezoids
    {
        static void Main()
        {
            Console.WriteLine("Program for calculates trapezoid's area by given sides a and b and height h");
            Console.WriteLine("Please enter a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter h: ");
            double h = double.Parse(Console.ReadLine());

            Console.WriteLine("The area of Trapezoid is {0}", ((a+b)/2)*h);
        }
    }
