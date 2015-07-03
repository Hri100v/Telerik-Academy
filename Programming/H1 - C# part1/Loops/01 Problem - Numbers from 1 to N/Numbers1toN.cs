/*Problem 1. Numbers from 1 to N

Write a program that enters from the console a positive integer n and prints all the numbers 
from 1 to n, on a single line, separated by a space.

 * Examples:
n	output
3	1 2 3
5	1 2 3 4 5
 */

using System;

class Numbers1toN
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer number: ");
        string numberStr;
        uint number;
        bool isNegativeN = true;
        while (isNegativeN)
        {
            numberStr = Console.ReadLine();
            int numCompare = int.Parse(numberStr);
            number = (uint)numCompare;
            if (numCompare < 0)
            {
                Console.WriteLine("Enter correct number.");
                isNegativeN = true;
            }
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.Write("{0} ", i);
                }
                Console.WriteLine();
                isNegativeN = false;
            }

        }
    }
}