/*Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan        George
Peter       Ivan 
Maria       Maria 
George	    Peter
 
 */

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace _06_Problem___Save_sorted_names
{
    class SaveSortedNames
    {
        static string inputPath = "../../../input name.txt";
        static string pathOutput = "../../output name.txt";

        static void Main(string[] args)
        {
            string[] arrayName = TakeFileToArray();
            Console.WriteLine("Array: ");
            PrintArray(arrayName);

            Array.Sort(arrayName);

            Console.WriteLine("Array after sorting: ");
            PrintArray(arrayName);

            //write to file
            WriteToFile(arrayName);

            Console.WriteLine();    //numLine   test
        }

        private static void WriteToFile(string[] arrayName)
        {
            using (StreamWriter output = new StreamWriter(pathOutput))
                foreach (string line in arrayName)
                    output.WriteLine(line);

            Console.WriteLine("File is written!");
        }

        private static void PrintArray(string[] arrayName)
        {
            Console.WriteLine(string.Join("\n", arrayName));
            Console.WriteLine();
        }

        private static string[] TakeFileToArray()
        {
            StreamReader input = new StreamReader(inputPath);
            var numLine = File.ReadLines(inputPath).Count();
            string[] arrayName = new string[numLine];
            for (int i = 0; i < numLine; i++)
            {
                arrayName[i] = input.ReadLine();
            }
            return arrayName;
        }
    }
}
