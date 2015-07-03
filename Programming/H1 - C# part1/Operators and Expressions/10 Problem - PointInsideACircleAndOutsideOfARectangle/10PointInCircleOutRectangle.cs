/*Problem 10. Point Inside a Circle & Outside of a Rectangle

Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
Examples:

x	    y	        inside K & outside of R
1	    2	        yes
2.5	    2	        no
0	    1	        no
2.5	    1	        no
2	    0	        no
4	    0	        no
2.5	    1.5	        no
2	    1.5	        yes
1	    2.5	        yes
-100    -100	    no
 */

using System;

    class PointInCircleOutRectangle
    {
        static void Main()
        {
            Console.WriteLine("Enter two number. First is: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second number: ");
            double y = Convert.ToDouble(Console.ReadLine());
            double rK = 1.5;
            double xy = 1;
/*
            //check is it in circle
            if ( (Math.Pow((xy - x), 2)) + (Math.Pow((xy - y), 2)) <= Math.Pow(1.5, 2) )
            {
                Console.WriteLine("In Circle");
            }
            else
            {
                Console.WriteLine("Out Circle");
            }
*/
            //check in rectangle -> after this > !(chekcRect) && checkCircle >>> ssearching result
            //rectangle R(top=1, left=-1, width=6, height=2) => left = -1, right = -1 + 6 = 5, top = 1, bottom = 1 - 2 = -1

            double left = -1, right = 5, top = 1, bottom = -1;
/*
            if ( !(((x >= left) && (x <= right)) && ((y <= top) && (y >= bottom))) )
            {
                Console.WriteLine("out Rect");
            }
            else
            {
                Console.WriteLine("in rect");
            }
 */

            if ( (Math.Pow((xy - x), 2)) + (Math.Pow((xy - y), 2)) <= Math.Pow(1.5, 2) )   //in Circle
            {
                if (!(((x > left) && (x < right)) && ((y < top) && (y > bottom))))      //out Rectangle   (without '=' for correct result)
                {
                Console.WriteLine("YES. X = {0} and Y = {1} are In Circle and Out Rectangle", x, y);
                }
                else
                {
                    Console.WriteLine("NO. X = {0} and Y = {1} they don`t pass the condition", x, y);
                }
            }
            else
            {
                Console.WriteLine("NO. X = {0} and Y = {1} they don`t pass the condition", x, y);
            }

        }
    }
