/*Problem 5. The Biggest of 3 Numbers

Write a program that finds the biggest of three numbers.
Examples:

a	    b	    c	    biggest
5	    2	    2	    5
-2	    -2	    1	    1
-2	    4	    3	    4
0	    -2.5	5	    5
-0.1	-0.5	-1.1	-0.1
 
 */

using System;

    class BiggestOf3Numbers
    {
        static void Main()
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            float big = (a > b && a > c ? a : b > c ? b : c);
            Console.WriteLine(big);
        }
    }