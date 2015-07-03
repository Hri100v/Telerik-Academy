/*Problem 2. Get largest number

Write a method GetMax() with two parameters that returns the larger of two integers.
Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Problem___Get_largest_number
{
    class MaxValue
    {
        static void Main()
        {
            Console.WriteLine("Largest number from 3 numbers.");
            Console.WriteLine("Please enter first.");
            string one = Console.ReadLine();
            Console.WriteLine("Please enter second.");
            string two = Console.ReadLine();
            Console.WriteLine("Please enter third.");
            string three = Console.ReadLine();
            string print = GetMax(GetMax(one, two), three);
            Console.WriteLine("The largest number is {0}.", print);
        }
        static string GetMax(string numOne, string numTwo)
        {
            int maxNumber = 0;
            int firstN = int.Parse(numOne);
            int secondN = int.Parse(numTwo);

            if ( firstN > secondN)
            {
                maxNumber = firstN;
            }
            else
            {
                maxNumber = secondN;
            }

            return maxNumber.ToString();
        }
    }
}
