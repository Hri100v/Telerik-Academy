/*Problem 9. Forbidden words

We are given a string containing a list of forbidden words and a text containing some of these words.
Write a program that replaces the forbidden words with asterisks.

Example text: 
Microsoft announced its next generation PHP compiler today. 
It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.

Forbidden words: PHP, CLR, Microsoft

The expected result: 
********* announced its next generation *** compiler today. 
It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.
 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EverythingTest
{
    class ForbiddenWords
    {
        static void Main(string[] args)
        {
            string text = "Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.";
            string someWords = "PHP, CLR, Microsoft";
            #region Test some 
            /*
            string[] forbiddenWords = someWords.Split(' ', ',', '.');
            foreach (var item in forbiddenWords)
            {
                if (item != "")
                {
                    Console.WriteLine(item);
                }
            }
             */
#endregion

            ///string[] forbWords = someWords.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);

            string clearResult = Regex.Replace(text, someWords.Replace(", ", "|"), m => new String('*', m.Length));
            Console.WriteLine(clearResult);

            //FindIndexOfWord();

        }

        //private static int[] FindIndexOfWord(string word)
        //{
        //    List<int>
        //    while (true)
        //    {
        //        if (true)
        //        {

        //        }
        //    }
        //}
    }
}