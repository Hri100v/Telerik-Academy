/*Problem 3. Decimal to hexadecimal

Write a program to convert decimal numbers to their hexadecimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Problem___Decimal_to_hexadecimal
{
    class DecToHex
    {
        static void Main()
        {
            Console.WriteLine("Enter some number.");
            string inputStr = Console.ReadLine();
            long decimalN = Convert.ToInt64(inputStr);

            Console.WriteLine("to hexdecimal --> {0}", DecimalToHexadecimal(decimalN));
        }
        static string DecimalToHexadecimal (long decimalNum)
        {
            string hex = "";

            while (decimalNum > 0)
            {
                long digit = decimalNum % 16; // >> 0-9 - 10-15
                if (digit > 0 && digit < 9)
                {
                    hex = (char)(digit + '0') + hex;
                }
                else if (digit >= 10 && digit <= 15)
                {
                    hex = (char)(digit -10 + 'A') + hex;
                }
                decimalNum /= 16;
            }

            return hex;
        }
    }
}
