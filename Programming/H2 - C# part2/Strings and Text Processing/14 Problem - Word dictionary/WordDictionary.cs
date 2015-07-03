/*Problem 14. Word dictionary

A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	        output
.NET	        platform for applications from Microsoft
CLR	            managed execution environment for .NET
namespace	    hierarchical organization of classes
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14_Problem___Word_dictionary
{
    class WordDictionary
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dictPr = new Dictionary<string, string>();
            dictPr.Add(".NET", "platform for applications from Microsoft");
            dictPr.Add("CLR", "managed execution environment for .NET");
            dictPr.Add("namespace", "hierarchical organization of classes");

            Console.WriteLine("Dictionary: ");
            #region dictionary represent
            foreach (var key in dictPr)
            {
                
                if (key.Key.Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("[");
                }
                if (key.Key.Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(key.Key.ToUpper());
                }
                if (key.Key.Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("] ");
                }
                //Console.Write("[" + key.Key.ToUpper() + "], ");
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            #endregion
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("Choose word.");
            //string word = Console.ReadLine();
            string word = "CLR";

            string translates = dictPr[word];
            Console.WriteLine("Translates:");
            Console.WriteLine(translates);


            //with REGEX
            #region Regex dictioonary
            /*
            string[] dictionary = 
                                    {
                                        ".NET - platform for applications from Microsoft",
                                        "CLR - managed execution environment for .NET",
                                        "namespace - hierarchical - organization of classes"
                                    };

            string word = ".NET";

            // TODO: Interpolation search
            foreach (string item in dictionary)
            {
                var fragments = Regex.Match(item, "(.*?) - (.*)").Groups;

                if (fragments[1].Value == word)
                {
                    Console.WriteLine(fragments[2]);
                    return;
                }
            }
             */
#endregion
        }
    }
}


        
