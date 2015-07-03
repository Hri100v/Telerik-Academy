/*Problem 18. Extract e-mails

Write a program for extracting all email addresses from given text.
All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _18_Problem___Extract_e_mails
{
    class ExtractEMails
    {
        static void Main(string[] args)
        {
            string email = "some e-mails ident@mail.com and one more academy@telerik.com.";

            Regex regex = new Regex(@"\w+@\w+\.\w+");
            MatchCollection matches = regex.Matches(email);
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
