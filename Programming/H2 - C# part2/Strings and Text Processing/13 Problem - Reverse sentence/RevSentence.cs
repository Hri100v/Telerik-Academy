/*Problem 13. Reverse sentence

Write a program that reverses the words in given sentence.
Example:

input	                                    output
C# is not C++, not PHP and not Delphi!	    Delphi not and PHP, not C++ not is C#!
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string str = "C# is not C++, not PHP and, not Delphi!";

        string regex = @"\s+|,\s*|\.\s*|!\s*|$";

        var words = new Stack<string>();

        foreach (var word in Regex.Split(str, regex))
        { 
            if (!String.IsNullOrEmpty(word)) words.Push(word);
        }

        foreach (var separator in Regex.Matches(str, regex))
        { 
            if (words.Count == 0)
            {
                break;
            }
            else
            {
                Console.Write(words.Pop() + separator);
            }
        }

        Console.WriteLine();
    }
}