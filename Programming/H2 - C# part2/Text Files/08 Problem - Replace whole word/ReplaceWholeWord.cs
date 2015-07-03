/*Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
 */

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;


namespace _08_Problem___Replace_whole_word
{
    class ReplaceWholeWord
    {
        static string inputPath = "../../../start finish - mod.txt";
        static string outputPath = "../../output replaced whole.txt";

        static void Main(string[] args)
        {
            
            using (StreamReader reader = new StreamReader(inputPath))
            {
                string line;
                using (StreamWriter writer = new StreamWriter(outputPath))
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        line = Regex.Replace(line, @"\bstart\b", "finish", RegexOptions.IgnoreCase); // , RegexOptions.IgnoreCase
                        writer.WriteLine(line);
                    }
            }


        }
    }
}
