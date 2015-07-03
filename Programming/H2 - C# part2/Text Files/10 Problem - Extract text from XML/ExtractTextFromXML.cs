/*Problem 10. Extract text from XML

Write a program that extracts from given XML file all the text without the tags.
Example:

<?xml version="1.0">
 <student>
    <name>Pesho</name>
    <age>21</age>
     <interests count="3">
     * <interest>Games</interest>
     * <interest>C#</interest>
     * <interest>Java</interest>
     </interests>
 </student>
 */

using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _10_Problem___Extract_text_from_XML
{
    class ExtractTextFromXML
    {
        static string inputPath = "../../../XML file.txt";
        static string outputPath = "../../output clear XML.txt";

        static void Main(string[] args)
        {
            // String result = Regex.Replace(htmlDocument, @"<[^>]*>", String.Empty);
            var text = File.ReadAllText(inputPath);
            String result = Regex.Replace(text, @"<[^>]*>", String.Empty);
            Console.WriteLine(result);

            SaveToFile(result.ToCharArray().Select(x => x.ToString()).ToArray());

        }

        private static void SaveToFile(string[] array)
        {
            using (StreamWriter writer = new StreamWriter(outputPath))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    
                    writer.Write(array[i]);
                    
                }
            }
        }
    }
}
