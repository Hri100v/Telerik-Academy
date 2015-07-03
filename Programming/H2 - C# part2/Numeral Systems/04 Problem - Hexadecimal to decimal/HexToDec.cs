/*Problem 4. Hexadecimal to decimal

Write a program to convert hexadecimal numbers to their decimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Problem___Hexadecimal_to_decimal
{
    class HexToDec
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some (hexadecimal) number.");
            string inputStr = Console.ReadLine();

            Console.WriteLine("to decimal --> {0}", HexadecimalToDecimal(inputStr));
        }

        static long HexadecimalToDecimal(string hexNumber)
        {
            long decimalNumber = 0;

            for (int i = 0; i < hexNumber.Length; i++)
            {
                int digit = 0;
                if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
                {
                    digit = hexNumber[i] - '0';
                }
                else if (hexNumber[i] >= 'A' && hexNumber[i] <= 'F')
                {
                    digit = hexNumber[i] - 'A' + 10;
                }

                decimalNumber += digit * (long)Math.Pow(16, hexNumber.Length - 1 - i);
            }

            return decimalNumber;
        }
    }
}
