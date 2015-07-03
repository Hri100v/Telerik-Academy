/*Problem 2. Random numbers

Write a program that generates and prints to the console 10 random values in the range [100, 200].
 */

using System;
using System.Linq;

namespace ProblemRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 100;
            int num2 = 200;
            Print10RandomNumber(num1, num2);
        }

        private static void Print10RandomNumber(int from, int to)
        {
            Random randomNum = new Random();
            for (int i = 0; i < 10; i++)
            {
                int result = randomNum.Next(from, to + 1);
                Console.WriteLine("{0} -> {1}", i+1, result);
            }
        }
    }
}
