/*Problem 23. Series of letters

Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
Example:

input	                        output
aaaaabbbbbcdddeeeedssaa	        abcdedsa
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Problem____Series_of_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "soomeee iddeeennntttiic worrds";

            StringBuilder output = new StringBuilder();

            output.Append(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] != text[i - 1])
                {
                    output.Append(text[i]);
                }
            }
            Console.WriteLine(output);
        }
    }
}
