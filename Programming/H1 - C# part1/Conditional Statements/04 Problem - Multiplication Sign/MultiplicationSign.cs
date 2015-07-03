/*Problem 4. Multiplication Sign

Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
Use a sequence of if operators.
Examples:

a	    b	        c	    result
5	    2	        2	    +
-2	    -2	        1	    +
-2	    4	        3	    -
0	    -2.5	    4	    0
-1	    -0.5	    -5.1	-
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Problem___Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multiplication Sign");
            Console.WriteLine("Write some numbers");
            Console.Write("a = ");
            float numA = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float numB = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float numC = float.Parse(Console.ReadLine());
            float numberSign = numA * numB * numC;


            Console.Clear(); 
            Console.WriteLine("  a  |  b  |  c  | result ");  // 5 | 5 | 5 | 8
            Console.Write(" {0,-3} | {1,-3} | {2,-3} | ", numA, numB, numC);
            if (numberSign > 0)
            {
                Console.WriteLine("{0,3}", "+");
            }
            else if (numberSign < 0)
            {
                Console.WriteLine("{0,3}", "-");
            }
            else
            {
                Console.WriteLine("{0,3}", "0");
            }

            Console.WriteLine();
        }
    }
}
