/*Problem 10. Unicode characters

Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	    output
Hi!	        \u0048\u0069\u0021
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ProblemUnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string line = "Hi!";

            //string t1 = "\u0048";
            //Console.WriteLine(t1);

            //string t2 = "H";
            //Console.WriteLine("\\u{0:X4}",(int)t2[0]);

            Console.WriteLine(UnicodeConverter(line));
        }

        static string UnicodeConverter(string text)
        {
            var st = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder(text.Length * 6);

            foreach (char ch in text)
            {
                sb.AppendFormat("\\u{0:X4}", (int)ch);
            }
            st.Stop();
            Console.WriteLine(st.Elapsed);

            return sb.ToString();
        }
    }
}
