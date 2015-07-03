/*Problem 1. Leap year

Write a program that reads a year from the console and checks whether it is a leap one.
Use System.DateTime.
 */

using System;
using System.Linq;
using System.Text;

namespace ProblemLeapYear
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Write Year.");
            int yearCheck = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("{0} {1}.", yearCheck, DateTime.IsLeapYear(yearCheck) ? "is LEAP year" : "is NOT leap year");
            //DateTime.IsLeapYear
        }
    }
}
