/*Problem 11. Prefix "test"

Write a program that deletes from a text file all words that start with the prefix test.
Words contain only the symbols 0…9, a…z, A…Z, _.
 */

using System;
using System.IO;
using System.Text.RegularExpressions;

namespace _11_Problem___Prefix__test_
{
    class Prefix_test_
    {
        static string inputPath = "../../../PrimesNumbers.txt";
        static string outputPath = "../../output test_.txt";

        static void Main(string[] args)
        {
            int n = 0;
            using (StreamReader input = new StreamReader(inputPath))
            using (StreamWriter output = new StreamWriter(outputPath))
                for (string line; (line = input.ReadLine()) != null && n < 10; n++)    // 10 because this is only test :)  and  use less memory
                    output.WriteLine(Regex.Replace(line, @"\btest\w*\b", String.Empty));
        }
    }
}
