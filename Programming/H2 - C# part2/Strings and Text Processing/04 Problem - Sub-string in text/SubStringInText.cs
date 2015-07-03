/*Problem 4. Sub-string in text

Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
Example:

The target sub-string is _in_

The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
So we are drinking all the day. We will move out of it in 5 days.

The result is: 9
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSubStringInText
{
    class SubStringInText
    {
        static void Main()
        {
            StringBuilder input = new StringBuilder();
            input.Append(@"In We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.");
            string subString = "in";
            int lenSubStr = subString.Length;
            int counter = 0;
            
            for (int i = 0; i < input.Capacity - lenSubStr; i++)
            {
                if (string.Compare(input.ToString().Substring(i,lenSubStr), subString, true) == 0)
                {
                    counter++;
                }
            }

            Console.WriteLine("The result is: {0}", counter);
        }
    }
}
