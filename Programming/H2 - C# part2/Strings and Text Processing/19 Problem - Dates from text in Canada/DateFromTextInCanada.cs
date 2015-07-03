/*Problem 19. Dates from text in Canada

Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
Display them in the standard date format for Canada.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Globalization;

namespace _19_Problem___Dates_from_text_in_Canada
{
    class DateFromTextInCanada
    {
        static void Main(string[] args)
        {

            string input = "let take one date - 22.10.2001";
            DateTime date;
            MatchCollection matches = Regex.Matches(input, @"\b\d{2}.\d{2}.\d{4}\b");

            foreach (Match match in matches)
            {
                date = DateTime.ParseExact(match.ToString(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA")));
            }

        }
    }
}
