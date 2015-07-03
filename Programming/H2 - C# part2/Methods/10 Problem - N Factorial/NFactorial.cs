/*Problem 10. N Factorial

Write a program to calculate n! for each n in the range [1..100].
Hint: Implement first a method that multiplies a number represented as array of digits by given integer number.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem10NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            Console.WriteLine("You want to calculate n!. \nWrite number in the range [1..100].");
            int number = int.Parse(Console.ReadLine());

            BigInteger fact = Factorial(number);
            Console.WriteLine(fact);
        }

        ///\/\/\/\/\/\/\/\/\/\/\/\Method - Print/\/\/\/\/\/\/\/\/\/\/\/\/\\\
        static BigInteger Factorial(BigInteger num)
        {
            int factN = 1;
            if (num <= 1)
            {
                return factN;
            }
            else
            {
                return (num * Factorial(num - 1));
            }
        }
    }
}
