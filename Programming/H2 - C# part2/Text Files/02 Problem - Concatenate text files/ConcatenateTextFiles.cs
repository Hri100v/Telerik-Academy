/*Problem 2. Concatenate text files

Write a program that concatenates two text files into another text file.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace ProblemConcatenate_text_files
{
    class ConcatenateTextFiles
    {
        static void Main(string[] args)
        {
            string text1Content = string.Empty;
            string text2Content = string.Empty;

            var text1 = new StreamReader("../../../num1.txt");
            using (text1)
            {
                text1Content = text1.ReadToEnd();
                Console.WriteLine(text1Content);
            }

            //Console.WriteLine();

            var text2 = new StreamReader("../../../num2.txt");
            using (text2)
            {
                text2Content = text2.ReadToEnd();
                Console.WriteLine(text2Content);
            }

            var result = text1Content + "\t\n\r" + text2Content;
            Console.WriteLine("-- Text Concatenate --");
            //Console.WriteLine(result);

            string fileName = "../../Concatenate Text.txt";
            StreamWriter streamWriter = new StreamWriter(fileName);
            using (streamWriter)
            {
                streamWriter.WriteLine(result);
            }
            
            Console.WriteLine("File is written!");

            Console.WriteLine();
        }
    }
}
