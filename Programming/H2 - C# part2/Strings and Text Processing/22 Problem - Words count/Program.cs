/*Problem 22. Words count

Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _22_Problem___Words_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.";

            var dict = new Dictionary<string, int>();

            foreach (Match word in Regex.Matches(str, @"\w+"))
                dict[word.Value] = dict.ContainsKey(word.Value) ? dict[word.Value] + 1 : 1;

            foreach (var pair in dict)
                Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
        }
    }
}
