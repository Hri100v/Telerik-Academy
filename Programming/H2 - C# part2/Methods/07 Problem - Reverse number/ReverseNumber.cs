/*Problem 7. Reverse number

Write a method that reverses the digits of given decimal number.
Example:

input	output
256	    652
123.45	54.321
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem7ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            Console.WriteLine("Write some decimal number: ");
            //int decNumber = int.Parse(Console.ReadLine());
            string input = Console.ReadLine(); // = "123.45";
            Console.WriteLine("Reverse: ");
            ReverseDecNumber(input);
        }

        static void ReverseDecNumber(string number)
        {
            var newN = number.Reverse().ToList();

            foreach (var item in newN)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
