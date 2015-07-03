/*Problem 20. Palindromes

Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _20_Problem___Palindromes
{
    class Palindromes
    {
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        static void Main()
        {
            string str = "some expression like ABBA, lamal, exe, neven, or, xor, txt.";

            foreach (Match item in Regex.Matches(str, @"\w+"))
                if (IsPalindrome(item.Value)) Console.WriteLine(item);

            //foreach (Match item in Regex.Matches(str, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b"))  
            //    Console.WriteLine(item);
        }
    }
}
