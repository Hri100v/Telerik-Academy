/*Problem 4. Download file

Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
Find in Google how to download files in C#.
Be sure to catch all exceptions and to free any used resources in the finally block.
 */

using System;
using System.Net;

namespace ProblemDownloadFile
{
    class DownloadFile
    {
        static void Main(string[] args)
        {
            string webPath = "http://telerikacademy.com/Content/Images/news-img01.png";
            string logo = "logo.png";
            //Console.WriteLine(webPath);

            using (WebClient webClient = new WebClient())
            {
                try
                {
                    webClient.DownloadFile(webPath, logo);
                }

                catch (WebException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }

                catch (NotSupportedException ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
        }
    }
}
