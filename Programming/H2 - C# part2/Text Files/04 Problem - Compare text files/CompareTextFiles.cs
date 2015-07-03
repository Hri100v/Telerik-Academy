/*Problem 4. Compare text files

Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
Assume the files have equal number of lines.0
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem___Compare_text_files
{
    class CompareTextFiles
    {
        static void Main(string[] args)
        {
            //string path = "../../../TrueFalse.txt";

            //StreamReader input = new StreamReader(path);
            


            //List<string> textCopyLBL = new List<string>();

            //using (input)
            //{
            //    int n = 1;
            //    for (string line; (line = input.ReadLine()) != null; n++)
            //    {
            //        Console.WriteLine(line);
            //    }
            //}
            //input.Close();

            //StreamReader reader = new StreamReader(path);
            //var value = reader.ReadToEnd();

            //Console.WriteLine();
            //Console.WriteLine(value);
            //Console.WriteLine(value.Count());
            //Console.WriteLine(value.Length);
            //Console.WriteLine(value.ToList().Select(l => l % 2 == 1));
            //Console.WriteLine(123321);
            //Console.WriteLine();


            //another way
            //string path2 = "../../../text file.txt";
            //StreamReader reader2 = new StreamReader(path2);
            //var count = File.ReadLines(path2).Count();
            ////Console.WriteLine(count);
            //var arrayOfTextInLine = File.ReadLines(path2).Take(count).ToArray();
            
            //int countSame = 0, countDiff = 0;

            //for (int i = 1; i < count; i++)
            //{
            //    if (arrayOfTextInLine[i] == arrayOfTextInLine[i - 1])
            //    {
            //        ++countSame;
            //    }
            //}
            //countDiff = count - countSame;
            //Console.WriteLine("all line are {0}", count);
            //Console.WriteLine("same line are {0} \ndifferent line are {1}", countSame, countDiff);


            int n = 0, same = 0;

            using (StreamReader input1 = new StreamReader("../../../text file.txt"))
            using (StreamReader input2 = new StreamReader("../../../numbers.txt"))
                for (string line1, line2; (line1 = input1.ReadLine()) != null && (line2 = input2.ReadLine()) != null; n++)
                    if (line1 == line2) same++;

           
            Console.WriteLine("same - {0} \ndifferent - {1}", same, n - same);

        }
    }
}
