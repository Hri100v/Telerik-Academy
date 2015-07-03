/*Problem 3. Circle Perimeter and Area

Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
Examples:

r	perimeter	area
2	12.57	    12.57
3.5	21.99	    38.48
 */

using System;

    class CirclePerArea
    {
        static void Main()
        {

            Console.Write("Please enter radius of 'Circle': ");
            double radius = double.Parse(Console.ReadLine());
            double perimeterC = 2*Math.PI*radius;
            double areaC = Math.PI * Math.Pow(radius, 2);
            Console.Clear();
            Console.WriteLine("The Circle have 'perimeter = {0:N2}' and 'area = {1:N2}'", perimeterC, areaC);
        }
    }