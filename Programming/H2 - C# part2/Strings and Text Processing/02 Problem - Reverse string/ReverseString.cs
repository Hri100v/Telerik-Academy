/*Problem 2. Reverse string

Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
 */

using System;
using System.Linq;

namespace ProblemReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string line = "example";
            //string line = Console.ReadLine();
            char[] lineArray = new char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                lineArray[line.Length - 1 - i] = line[i];
            }

            var reversed = String.Join("", lineArray); // lineArray.Select(x => x).ToString();
            Console.WriteLine("'{1}' reverse -> '{0}'", reversed, line);
        }
    }
}
