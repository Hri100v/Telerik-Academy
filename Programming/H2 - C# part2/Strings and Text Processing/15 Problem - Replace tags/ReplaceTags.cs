/*Problem 15. Replace tags

Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

input	                                                                            output
<p>Please visit <a href="http://academy.telerik. com">our site</a>                  <p>Please visit [URL=http://academy.telerik. com]our site[/URL] 
to choose a training course. Also visit                                             to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] 
<a href="www.devbg.org">our forum</a> to discuss the courses.</p>                   to discuss the courses.</p>
 */

using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _15_Problem___Replace_tags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {
            string html = "<p>Please visit <a href=\"http://academy.telerik.com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";

            Console.WriteLine(Regex.Replace(html, "<a href=\"(.*?)\">(.*?)</a>", "[URL=$1]$2[/URL]"));
            Console.WriteLine();
        }
    }
}
