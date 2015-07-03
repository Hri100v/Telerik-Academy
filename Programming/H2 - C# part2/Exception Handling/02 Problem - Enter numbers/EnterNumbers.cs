/*Problem 2. Enter numbers

Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

using System;
using System.Linq;

namespace ProblemEnterNumbers
{
    class EnterNumbers
    {
        static void ReadNumber(int start, int end)
        {
            int a = int.Parse(Console.ReadLine());
            try
            {
                
                if (!(start < a && a < end))
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("invalid number");
                //Console.WriteLine("somthing wrong");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter 10 numbers in range [1 - 100].");
            int start = 1;
            int end = 100;

            for (int i = 0; i < 10; i++)  ReadNumber(start, end);
            
        }
    }
}
