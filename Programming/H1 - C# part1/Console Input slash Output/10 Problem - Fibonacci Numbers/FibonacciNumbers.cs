/*Problem 10. Fibonacci Numbers

Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
Note: You may need to learn how to use loops.

Examples:

n	comments
1	0
3	0 1 1
10	0 1 1 2 3 5 8 13 21 34
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Problem___Fibonacci_Numbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Salute! Fibonacci time.");

            Console.WriteLine("First 'n' Fibonacci Numbers.");
            Console.Write("Choose n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int Fib0 = 0;
            int Fib1 = 1;

            Console.WriteLine();
            Console.Write(Fib0 + ", " + Fib1);
            int FibCount = Fib0 + Fib1;
            int i = 0;
            int j = 0;
            while (i <= n - 3)
            {
                i++;
                Console.Write(", " + FibCount);
                j = FibCount - j;
                FibCount =j + FibCount;
                
            }

            Console.WriteLine();
            /*
            for (int i = 0; i < n; i++)
            {
                
            }
            */
        }
    }
}
