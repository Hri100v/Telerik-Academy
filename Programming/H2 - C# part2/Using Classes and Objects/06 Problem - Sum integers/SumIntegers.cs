/*Problem 6. Sum integers

You are given a sequence of positive integer values written into a string, separated by spaces.
Write a function that reads these values from given string and calculates their sum.
Example:

input	output
"43 68 9 23 318"	461
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSumIntegers
{
    class SumIntegers
    {
        static void Main(string[] args)
        {
            /**/
            string input = "43 68 9 23 318";
            /**/
            /*string input = Console.ReadLine();/**/

            Stopwatch sw = new Stopwatch();


            //*************************************************************************** some test
            sw.Start();
            SumOfInteger(input);
            sw.Stop();

            var time = sw.Elapsed;
            Console.WriteLine((int)time.TotalMilliseconds);
        }

        private static void SumOfInteger(string stringNumber)
        {
            var result = stringNumber.Split().Select(x => int.Parse(x)).ToArray().Sum();

            Console.WriteLine(result);
        }
    }
}
