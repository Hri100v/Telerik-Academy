/*Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
 */

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07_Problem___Replace_sub_string
{
    class ReplaceSubString
    {
        static string inputPath = "../../../start finish.txt";
        static string outputPath = "../../output replaced.txt";

        static void Main(string[] args)
        {
            // exaple
            // File.WriteAllText("Path", Regex.Replace(File.ReadAllText("Path"), "[Pattern]", "Replacement"));

            using(StreamReader reader = new StreamReader(inputPath))
            {
                string line;
                using (StreamWriter writer = new StreamWriter(outputPath))
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        line = Regex.Replace(line, "start", "finish", RegexOptions.IgnoreCase); // , RegexOptions.IgnoreCase
                        writer.WriteLine(line);
                    }
            }
                

        }
    }
}
