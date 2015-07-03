/*Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

namespace _13_Problem___Count_words
{
    class CountWords
    {
        static string inputPath1 = "../../test.txt";
        static string inputPath2 = "../../words.txt";
        static string outputPath = "../../result.txt";
        

        static void Main(string[] args)
        {
            try
            {
                string[] words = File.ReadAllLines(inputPath1); 
                int[] values = new int[words.Length];

                // Count words
                using (StreamReader input = new StreamReader(inputPath2))
                    for (string line; (line = input.ReadLine()) != null; )
                        for (int i = 0; i < words.Length; i++)
                            values[i] += Regex.Matches(line, @"\b" + words[i] + @"\b").Count;

                // Sort
                Array.Sort(values, words);

                // Write output
                using (StreamWriter output = new StreamWriter(outputPath))
                    for (int i = words.Length - 1; i >= 0; i--) // Descending order
                        output.WriteLine("{0}: {1}", words[i], values[i]);
            }

            catch (DirectoryNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (FileNotFoundException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (IOException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (SecurityException exception)
            {
                Console.WriteLine(exception.Message);
            }

            catch (UnauthorizedAccessException exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}
