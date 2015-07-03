/*Problem 1. Sum of 3 Numbers

Write a program that reads 3 real numbers from the console and prints their sum.
Examples:

a	b	c	    sum
3	4	11	    18
-2	0	3	    1
5.5	4.5	20.1	30.1
 */
using System;

    class ConsoleInputOutput
    {
        static void Main()
        {
            Console.WriteLine("Calculated 3 real numbers");
            Console.Write("Write number a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write number c = ");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of (a + b + c) = {0}", (a + b + c));
        }
    }