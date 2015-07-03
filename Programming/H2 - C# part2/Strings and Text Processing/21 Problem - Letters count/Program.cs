/*Problem 21. Letters count

Write a program that reads a string from the console and prints all 
different letters in the string along with information how many times each letter is found.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_Problem___Letters_count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            str = str.ToLower(); //case-insensitive

            int[] letters = new int['z' - 'a' + 1];

            for (int i = 0; i < str.Length; i++)
            {
                int index = str[i] - 'a';
                letters[index]++;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] != 0)
                {
                    Console.WriteLine("Letter {0} - {1} times", (char)(i + 'a'), letters[i]);
                }
            }
        }
    }
}
