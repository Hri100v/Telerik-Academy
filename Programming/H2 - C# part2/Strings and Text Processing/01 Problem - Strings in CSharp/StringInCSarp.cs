/*Problem 1. Strings in C#.

Describe the strings in C#.
What is typical for the string data type?
Describe the most important methods of the String class.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStringsInCSharp
{
    class StringInCSarp
    {
        static void Main(string[] args)
        {
            string s1 = "ABCD";     //"Hello";
            string s2 = "abcd";     //"World";

            Console.WriteLine(s1 + string.Concat(" ", s2));
            var resultCompare = string.Compare(s1, s2);
            Console.WriteLine(resultCompare);
            switch (resultCompare)
            {
                case 0:
                    Console.WriteLine("{0} = {1}", s1, s2);
                    break;
                case -1:
                    Console.WriteLine("{0} > {1}", s1, s2);     // s1 is smaller than s2
                    break;
                case 1:
                    Console.WriteLine("{0} < {1}", s1, s2);     // s2 is smaller than s1
                    break;
                default:
                    break;
            }
            Console.WriteLine("Length of word [{0}] = {1} letters",s1, s1.Length);

            string str1 = "ABCD";
            string str2 = "abcd";
            var res = String.CompareOrdinal(str1, str2);
            string str = (res > 0) ? "greater than" : (res < 0) ? "less than" : "equal to";
            Console.WriteLine("{0} {1} {2}", str1, str, str2);

            Console.WriteLine();

            Console.WriteLine(s1.Contains("BC"));

            string someWord = "Example";
            Console.WriteLine("Spelling word - {0}", someWord);
            for (int i = 0; i < someWord.Length; i++)
            {
                Console.Write("{0}_", someWord[i]);
            }
            Console.WriteLine();

            int indexStart = someWord.IndexOf('a');
            Console.WriteLine("Index of letter 'a' is {0}", indexStart);
            var partWord = someWord.Substring(indexStart);
            Console.WriteLine("Extract part of a word from letter 'a' - {0}", partWord);

            string line = "This is some expression.";
                         //012345678
            char[] array = new char[4];
            line.CopyTo(8,array, 0,4);    
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
