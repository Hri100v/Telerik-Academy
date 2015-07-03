/*
 Problem 11.* Numbers in Interval Dividable by Given Number

Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that 
the reminder of the division by 5 is 0.

Examples:

start	end	    p	    comments
17	    25	    2	    20, 25
5	    30	    6	    5, 10, 15, 20, 25, 30
3	    33	    6	    5, 10, 15, 20, 25, 30
3	    4	    0	    -
99	    120	    5	    100, 105, 110, 115, 120
107	    196	    18	    110, 115, 120, 125, 130, 135, 140, 145, 150, 155, 160, 165, 170, 175, 180, 185, 190, 195
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11asteriks
{
    class NumbersInterval
    {
        static void Main()
        {
            Console.WriteLine("How much Numbers have in Interval Dividable by Given Number?");
            Console.Write("Start with ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("End with ");
            int end = Convert.ToInt32(Console.ReadLine());
            int special = 0;
            int count = 0;

            //take first number
            Console.WriteLine();
            if ((start % 5) == 0)
            {
                Console.Write(start);
                count++;
            }
            else if (((start + 1) % 5) == 0)
            {
                Console.Write(start + 1);
                count++;
            }
            else if (((start + 2) % 5) == 0)
            {
                Console.Write(start + 2);
                count++;
            }
            else if (((start + 3) % 5) == 0)
            {
                Console.Write(start + 3);
                count++;
            }
            else if (((start + 4) % 5) == 0)
            {
                Console.Write(start + 4);
                count++;
            }
            
            //take second number
            special = start + 5;
            while (special <= end)
            {
                if (special % 5 == 0)
                {
                    Console.Write(", " + special);
                    count++;
                }
                
                special++;

            }
            Console.WriteLine();
            Console.WriteLine("Numbers exist between {0} and {1} is p = {2}",start, end, count);
            Console.WriteLine();
/*
            for (; start <= end; start++)
            {
                special = start;

                while (special <= start + 4 && start <= end)
                {
                    Console.Write(", " + special);
                }

                if ((special % 5) == 0)
                {

                    Console.Write(", " + start);
                }

               
            }

*/

            Console.WriteLine();
        }
    }
}
