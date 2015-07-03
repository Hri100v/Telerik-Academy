/*Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
  <head><title>News</title></head>
  <body><p><a href="http://academy.telerik.com">Telerik
    Academy</a>aims to provide free real-world practical
    training for young people who want to turn into
    skilful .NET software engineers.</p></body>
</html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _25_Problem___Extract_text_from_HTML
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";

            foreach (Match text in Regex.Matches(str, "(?<=>).*?(?=<)"))
                if (!String.IsNullOrWhiteSpace(text.Value)) Console.WriteLine(text);


            /*
            string html = @"<html><head><title>News</title></head><body><p><a href=""http://academy.telerik.com"">TelerikAcademy</a>aims to provide free real-world practicaltraining for young people who want to turn into skillful .NET software engineers.</p></body></html>";
            MatchCollection matches = Regex.Matches(html, @">(.*?)<");
            foreach (Match match in matches)
            {
                string str = match.ToString();
                str = str.Substring(1, str.Length - 2);
                if (str.Length > 0)
                {
                    Console.WriteLine(str);
                }
            }
             */
        }
    }
}
