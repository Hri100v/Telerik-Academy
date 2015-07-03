/*Problem 2. Binary to decimal

Write a program to convert binary numbers to their decimal representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Problem___Binary_to_decimal
{
    class BinToDec
    {
        static void Main()
        {
            Console.WriteLine("Enter some (binary) number.");
            string inputStr = Console.ReadLine();

            Console.WriteLine("to decimal --> {0}",BinaryToDecimal(inputStr));
        }

        static long BinaryToDecimal(string binaryNumber)
        {
            long decimalNumber = 0;

            for (int i = 0; i < binaryNumber.Length; i++)
            {
                int digit = binaryNumber[i] - '0';    //== '1' ? 1 : 0 
                int position = binaryNumber.Length - 1 - i;
                decimalNumber += digit * (long)Math.Pow(2, position);
            }

            return decimalNumber;
        }
    }
}
