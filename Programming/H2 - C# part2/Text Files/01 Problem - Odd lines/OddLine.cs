/*Problem 1. Odd lines

Write a program that reads a text file and prints on the console its odd lines.
 */

using System;
using System.Linq;
using System.IO;

namespace ProblemOdd_lines
{
    class OddLine
    {
        static void Main(string[] args)
        {
            string path1 = @"../../../LoremIpsum.txt";
            string path2 = "\\numbers.txt";

            string value1 = File.ReadAllText(path1);
            //string value2 = File.ReadAllText(path2);

            Console.WriteLine("--- Contents of file.txt: ---");
            Console.WriteLine(value1);  //.OrderBy(x => x % 2 == 0)

            Console.WriteLine();

            Console.WriteLine("--- Contents of file.txt: ---");
            //Console.WriteLine(value2);

            string line;
            StreamReader reader = new StreamReader(@"../../../numbers2.txt");
            
            //line = reader.ReadLine();
            
            //Console.WriteLine(line);
            int k = 0;
            //char[] delimeter = { '*', ' ', '*', ' ', };

            while (true)
            {
                
                string line2 = reader.ReadLine();

                if (k % 2 == 0)
                {
                    Console.WriteLine(k + " " + new string('*', 15));
                }
                else
                {
                    Console.WriteLine(k + " " + line2); // Use line.
                }

                if (line2 == null)
                {
                    break;
                }
                //Console.WriteLine(line2); // Use line.

                ++k;
            }
            reader.Close();

        }
    }
}
