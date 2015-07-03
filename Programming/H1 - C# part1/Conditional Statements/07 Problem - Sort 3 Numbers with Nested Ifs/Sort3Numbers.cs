/*Problem 7. Sort 3 Numbers with Nested Ifs

Write a program that enters 3 real numbers and prints them sorted in descending order.
Use nested if statements.
Note: Don’t use arrays and the built-in sorting functionality.

Examples:

a	    b	    c	    result
5	    1	    2	    5 2 1
-2	    -2	    1	    1 -2 -2
-2	    4	    3	    4 3 -2
0	    -2.5    5	    5 0 -2.5
-1.1    -0.5	-0.1	-0.1 -0.5 -1.1
10	    20	    30	    30 20 10
1	    1	    1	    1 1 1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Problem___Sort_3_Numbers_with_Nested_Ifs
{
    class Sort3Numbers
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                if (b > c)
                {
                    Console.WriteLine("{0} {1} {2}", a, b, c);
                }
                else
                {
                    Console.WriteLine("{0} {2} {1}", a, b, c);
                }
            }
            else
            {
                if (b > c)
                {
                    if (a > c)
                    {
                        Console.WriteLine("{1} {0} {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{1} {2} {0}", a, b, c);
                    }
                }
                else  //c is biggest
                {
                    if (a > b)
                    {
                        Console.WriteLine("{2} {0} {1}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{2} {1} {0}", a, b, c);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
