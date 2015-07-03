/*Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.
Examples:

n	x	S
3	2	2.75000
4	3	2.07407
5	-4	0.75781
 */

using System;

class CalcFunct1toN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        decimal factorial = 1.00M;
        decimal power = 1.00M;
        decimal sum = 1;
                        //S = 1 + 1!/x + 2!/x2 + … + n!/x^n

        for (int i = 1; i <= n; i++)
        {
            //x^n
            power *= x;
            if (i > 0 && n > 0)
            {
                factorial = factorial * i;
            }

            sum = sum + factorial / (decimal)power;
        }

        Console.WriteLine("Sum is {0:F5}", sum);
    }
}