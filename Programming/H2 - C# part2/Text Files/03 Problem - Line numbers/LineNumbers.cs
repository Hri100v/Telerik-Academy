/*Problem 3. Line numbers

Write a program that reads a text file and inserts line numbers in front of each of its lines.
The result should be written to another text file.
 */

using System;
using System.Linq;
using System.IO;

namespace ProblemLineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string path = "../../../num1.txt";
            StreamReader reader = new StreamReader(path);
            var res = reader.ReadToEnd();
            Console.WriteLine("number of digits - {0}", res.Count(char.IsDigit)); //number of digits
            Console.WriteLine("length (number of all symbols) - {0}", res.Length); //length
            Console.WriteLine();
            Console.WriteLine("-- Text Content --");
            Console.WriteLine(res);


            int n = 1;

            using (StreamReader input = new StreamReader("../../../numbers2.txt"))
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                for (string line; (line = input.ReadLine()) != null; n++)
                    output.WriteLine("{0} - {1}", n, line);

            //var newReader = new StreamReader("../../../numbers2.txt");
            //string pathToWrite = "../../text.txt";
            //StreamWriter writeToFile = new StreamWriter(@"../../text.txt");

            //Console.WriteLine(newReader.ReadLine());
            //newReader.Close();

            //int i = 1;
            //using (writeToFile)
            //{
            //    for (string line; (line = newReader.ReadLine()) != null; i++)
            //    {
            //        writeToFile.WriteLine("{0,3} - {1}", i, line);
            //    }
            //}
            

            //Console.WriteLine("File is written.");
            
        }
    }
}
