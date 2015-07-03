/*Problem 3. Min, Max, Sum and Average of N Numbers

Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, 
the sum and the average of all numbers (displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
The output is like in the examples below.

 * Example 1:

input	output
3       min = 1         //P3
2       max = 5         //P4
5       sum = 8         //P1
1	    avg = 2.67      //P2


 * Example 2:

input	output
2       min = -1 
-1      max = 4 
4	    sum = 3 
        avg = 1.50

 */

using System;

class MinMaxSumAvrg
{
    static void Main()
    {
        int numbers, n = int.Parse(Console.ReadLine());
        double avg;
        int min = Int32.MaxValue;
        int max = Int32.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            numbers = int.Parse(Console.ReadLine());
            sum += numbers;

            if (numbers < min)
            {
                min = numbers;
            }
            if (numbers > max)
            {
                max = numbers;
            }

        }



        avg = (double)sum / n;
        Console.WriteLine("min = {0}", min);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);

    }
}