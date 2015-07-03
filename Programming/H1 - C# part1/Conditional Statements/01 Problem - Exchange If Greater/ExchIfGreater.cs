/*Problem 1. Exchange If Greater

Write an if-statement that takes two double variables a and b and exchanges their values if 
the first one is greater than the second one. As a result print the values a and b, separated by a space.
Examples:

a	b	    result
5	2	    2 5
3	4	    3 4
5.5	4.5	    4.5 5.5
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class ExchIfGreater
    {
        static void Main()
        {
            double a, b;
            Console.WriteLine("Enter first number: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Result: ");
            if (a < b)
            {
                Console.Write("{0} {1}", a, b);
            }
            else
            {
                Console.Write("{0} {1}", b, a);
            }
            Console.WriteLine();
        }
    }
}
