/*Problem 8. Extract sentences

Write a program that extracts from a given text all sentences containing given word.
Example:

The word is: in

The text is: We are living in a yellow submarine. We don't have anything else. 
Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

Consider that the sentences are separated by . and the words – by non-letter symbols.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemExtractSentences
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            string word =" in ".Trim();
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            
            //Console.Write("Write word: ");
            //string word = Console.ReadLine();
            //
            //Console.WriteLine("Write text.");
            //string text = Console.ReadLine();
            word = " " + word + " ";
           
            Console.WriteLine();

            Console.WriteLine(ExtractSent(word, text));

        }
        static StringBuilder ExtractSent(string word, string text) 
        {
            StringBuilder builder = new StringBuilder();
            //builder.Append("some");

            //to take diff sent
            StringBuilder temporery = new StringBuilder();
            List<string> splitSent = new List<string>();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != '.')
                {
                    //add to TempBuilder
                    temporery.Append(text[i]);
                }
                else
                {
                    //find '.' => END of sent
                    //add > list of Split
                    temporery.Append(".");
                    splitSent.Add(temporery.ToString());
                    temporery.Clear();
                }
            }
            
            foreach (var item in splitSent)
            {
                if (item.Contains(word))
                {
                    builder.Append(item);
                } 
            }

            return builder;
        }

    }
}
