/*Problem 24. Order words

Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_Problem___Order_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.";
            string[] words = input.Split(' ');

            Array.Sort(words);

            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
    }
}
