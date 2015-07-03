/*Problem 3. English digit

Write a method that returns the last digit of given integer as an English word.

 * Examples:
input	output
512	    two
1024	four
12309	nine
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Problem___English_digit
{
    class SayLastDigit
    {
        static void Main(string[] args)
        {
            //string str = "12309";
            Console.WriteLine("Write some number: ");
            string str = Console.ReadLine();
            SayLastSymbol(str);
            
            //SayLastSymbol(TakeLastSymbol(str));
        }
        static char TakeLastSymbol(string someString)
        {
            char lastSymbol = ' ';
            lastSymbol = someString.Last();
            return lastSymbol;
        }
        public static void SayLastSymbol(string symbol)     //changed from char to string
        {
            char lastS = TakeLastSymbol(symbol);
            Dictionary<char, string> nameOfSymbol = new Dictionary<char, string>    {
                                                                                       {'0', "zero"},
                                                                                       {'1', "one"},
                                                                                       {'2', "two"},
                                                                                       {'3', "three"},
                                                                                       {'4', "four"},
                                                                                       {'5', "five"},
                                                                                       {'6', "six"},
                                                                                       {'7', "seven"},
                                                                                       {'8', "eight"},
                                                                                       {'9', "nine"},
                                                                                    };
            string theName = string.Empty;
            if (nameOfSymbol.TryGetValue(lastS, out theName))   //change symbol -> lastS
            {
                Console.WriteLine("The last digit is {0}", theName);
            }
            else Console.WriteLine("Do not have that digit");
            Console.WriteLine();
        }
    }

}
