/*Problem 5. Parse tags

You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ProblemParseTags
{
    class ParseTags
    {
        static void Main()
        {


            //string line = "hello World.";
            //var result = line.ToUpper();
            //Console.WriteLine(result);

            ////localize markers
            //string startWord = "<upcase>";
            //int lenStartWord = startWord.Length;
            //string endWord = "</upcase>";
            //             //01234567890123
            //string test = "in a <upcase>yellow submarine</upcase>.";    //"<upcase>"; IndexOf == 0  < equal   .... IndexOf == -1 (Do not have that index)
            //var indexStart = test.IndexOf(startWord) + lenStartWord;
            //Console.WriteLine(indexStart);

            ////Console.WriteLine(test.IndexOf(startWord));

            //StringBuilder newLine = new StringBuilder();
            ////newLine.AppendLine(test);
            ////Console.WriteLine(newLine);
            ////newLine.Replace("<upcase>", "");
            ////Console.WriteLine(newLine);

            //int index = 0;
            //for (int i = 0; i < test.Length; i++)
            //{
            //    //when find <upcase>
            //    //if (test.IndexOf(startWord) > 0)
            //    //{
            //    //    newLine.Append(test[indexStart],)
            //    //}
            //    int lenExprToUp = test.IndexOf(startWord) + test.IndexOf(endWord);
            //    if (test.IndexOf(startWord) > 0)
            //    {
            //        index = test.IndexOf(startWord);
            //        string tempStr = test.Substring(indexStart, lenExprToUp).ToUpper();
            //        test.Replace(startWord, "");
            //        test.Replace(endWord, "");
            //        //newLine.Insert(index,)
            //    }

            //    //else > append char[] to newLine
            //}

            //var newResult = test.Substring(test.IndexOf("<upcase>"));
            //Console.WriteLine(newResult);

            //string subExprUp = Regex.Replace(test, "<upcase>(.*?)</upcase>", delegate(Match match)
            //    {
            //        string current = match.ToString().ToUpper();
            //        return Regex.Replace(current, @"<[^>]*>", String.Empty);
            //    });

            //Console.WriteLine(subExprUp);


            //easy way

            string text = Console.ReadLine();
            var newTextUp = Regex.Replace(text, "<upcase>(.*?)</upcase>", word => word.Groups[1].Value.ToUpper());
            Console.WriteLine(newTextUp);
        }
    }
}
