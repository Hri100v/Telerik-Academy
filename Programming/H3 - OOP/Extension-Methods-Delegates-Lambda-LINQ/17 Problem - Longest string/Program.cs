/*Problem 17. Longest string

Write a program to return the string with maximum length from an array of strings.
Use LINQ.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testing1_LongestStrArr
{
    class Program
    {
        public static int bigValue = 0;
        static void Main(string[] args)
        {
            var strArray = new[] { "Maya", "Something", "And One More", "PET" };
            Print(strArray); Console.WriteLine();

            var res2 = strArray.OrderByDescending(x => x.Length).First();
            Console.WriteLine(res2);

            var res3 = strArray.Max(x => x.Length);
            Console.WriteLine(res3);

            var res4 = strArray.Aggregate("", (x, y) => x.Length > y.Length ? x : y);
            Console.WriteLine(res4);

            var res5 =
                from x in strArray
                where GetLongestString(x)
                select x;
            // Print(res5);
            Console.WriteLine(res5.Last());

        }

        private static bool GetLongestString(string x)
        {
            if (x.Length > bigValue)
            {
                bigValue = x.Length;
                return true;
            }
            return false;
        }


        private static void Print(IEnumerable strArray)
        {
            foreach (var item in strArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
