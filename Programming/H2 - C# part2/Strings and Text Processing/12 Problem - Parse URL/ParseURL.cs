/*Problem 12. Parse URL

Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
Example:

URL	                                                        Information
http://telerikacademy.com/Courses/Courses/Details/212	    [protocol] = http 
                                                            [server] = telerikacademy.com 
                                                            [resource] = /Courses/Courses/Details/212
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemParseURL
{
    class ParseURL
    {
        static void Main(string[] args)
        {
                        //01234567890123456789012345
            string url = "http://telerikacademy.com/Courses/Courses/Details/212";
            Console.WriteLine(url);

            string protocol = FindProtocol(url);
            Console.WriteLine("[protocol] = {0}", protocol);

            string server = FindServer(url);
            Console.WriteLine("[server] = {0}", server);

            string resource = FindResource(url);
            Console.WriteLine("[resource] = {0}", resource);


            //int firstDot = url.IndexOf('.');
            //int finResIndex = url.IndexOf('/', firstDot);
            //Console.WriteLine(finResIndex);
        }

        static string FindProtocol(string url)
        {
            int indexFin = url.IndexOf(':');
            return url.Substring(0, indexFin);
        }

        private static string FindServer(string url)
        {
            string server = string.Empty;
            int finSlashI = url.IndexOf('/') + 2;
            int firstDot = url.IndexOf('.');
            int finResIndex = url.IndexOf('/', firstDot);
            server = url.Substring(finSlashI, finResIndex - finSlashI);

            return server;
        }

        private static string FindResource(string url)
        {
            string resource = string.Empty;
            int firstDot = url.IndexOf('.');
            int startIndex = url.IndexOf('/', firstDot);
            resource = url.Substring(startIndex);

            return resource;
        }
    }
}
