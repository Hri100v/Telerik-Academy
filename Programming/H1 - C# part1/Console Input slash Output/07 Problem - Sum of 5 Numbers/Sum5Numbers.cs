/*Problem 7. Sum of 5 Numbers

Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.
Examples:

numbers	            sum
1 2 3 4 5	        15
10 10 10 10 10	    50
1.5 3.14 8.2 -1 0	11.84
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

    class Sum5Numbers
    {
        static void Main()
        {
            Console.Write("Enters 5 numbers (given in a single line, separated by a space): ");
            string str1 = Console.ReadLine();

            float[] numbers = str1.Split(' ').Select(n => Convert.ToSingle(n)).ToArray();
         

            float sum = 0;
            foreach (float num in numbers)
            {
                sum += num;
                
            }
            Console.WriteLine(sum);


        }
    }