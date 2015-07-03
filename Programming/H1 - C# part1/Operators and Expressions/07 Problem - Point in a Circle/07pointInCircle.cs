/*Problem 7. Point in a Circle

Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
Examples:

x	    y	    inside
0	    1	    true
-2	    0	    true
-1	    2	    false
1.5	    -1	    true
-1.5    -1.5	false
100	    -30	    false
0	    0	    true
0.2	    -0.8	true
0.9	    -1.93	false
1	    1.655	true
 */

using System;

    class pointInCircle
    {
        static void Main()
        {
            Console.WriteLine("Enter two number that will be check are they in circle K({0, 0}, 2): ");
            int constK = 2;
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second: ");
            int y = int.Parse(Console.ReadLine());

            if (x <= (y + constK) && x >= (y - constK))
            {
                Console.WriteLine("X = {0} and Y = {1} are in circle K({{X, Y}}, 2)", x, y);
            }
            else
            {
                Console.WriteLine("X = {0} and Y = {1} are NOT in circle K({{X, Y}}, 2)", x, y);
            }

        }
    }