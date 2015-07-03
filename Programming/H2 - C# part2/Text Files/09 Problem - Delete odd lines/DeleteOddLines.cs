/*Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
 */

using System;
using System.IO;
using System.Linq;

namespace _09_Problem___Delete_odd_lines
{
    class DeleteOddLines
    {
        static string inputPath = "../../../LoremIpsumCopy.txt";
        static string outputPath = "../../output.txt";

        static void Main(string[] args)
        {
            // only test
            var textArray = TakeFileToArray();
            var size = TakeFileToArray().Count();
            string[] takeText = new string[size];
            Array.Copy(textArray, takeText, size);
            Console.WriteLine(string.Join(" <!!!> ", takeText));

            SaveToFile(TakeFileToArray());
            
        }

        private static void SaveToFile(string[] array)
        {
            using(StreamWriter writer = new StreamWriter(outputPath))
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        writer.WriteLine(array[i]);
                    }
                }
            }
        }

        private static string[] TakeFileToArray()
        {
            StreamReader input = new StreamReader(inputPath);
            var numLine = File.ReadLines(inputPath).Count();
            string[] array = new string[numLine];
            for (int i = 0; i < numLine; i++)
            {
                array[i] = input.ReadLine();
            }
            return array;
        }
    }
}
