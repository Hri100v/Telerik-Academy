/*Problem 12. Remove words

Write a program that removes from a text file all words listed in given another text file.
Handle all possible exceptions in your methods.
 */


using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Security;

namespace _12_Problem___Remove_words
{
    class RemoveWords
    {
        static string inputPath = "../../../LoremIpsumCopy.txt";
        static string outputPath = "../../output remove words.txt";
        static string blackList = "../../../black list.txt";

        static void Main(string[] args)
        {
            try
            {
                string regex = @"\b(" + String.Join("|", File.ReadAllLines(blackList)) + @")\b";

                using (StreamReader input = new StreamReader(inputPath))
                using (StreamWriter output = new StreamWriter(outputPath))
                    for (string line; (line = input.ReadLine()) != null; )
                        output.WriteLine(Regex.Replace(line, regex, String.Empty));
            }

            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (SecurityException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
