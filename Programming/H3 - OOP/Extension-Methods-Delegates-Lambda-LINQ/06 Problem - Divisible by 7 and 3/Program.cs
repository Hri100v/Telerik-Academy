/*Problem 6. Divisible by 7 and 3

Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. 
Rewrite the same with LINQ.
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _06_Problem___Divisible_by_7_and_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new[] { 1, 2, 3, 4, 5, 14, 21, 12, 7, 6, 28, 29, 42, 72, 63, 64, 210 };
            //var list = new List<int>() { 1, 2, 3, 4, 5, 14, 21, 12, 7, 6, 28, 29, 42, 72, 63, 64 };
            Print(array);
            
            var resultArr = array.ToList().FindAll(number => (number % 3 == 0) && (number % 7 == 0));
            Print(resultArr);

            var builtArray =
                from number in array
                where (number % 3 == 0) && (number % 7 == 0)
                select number;
            Print(builtArray);
            

        }

        static void Print(IEnumerable collection)
        {
            foreach (var item in collection)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine(new string('=', 35));
        }
    }

}
