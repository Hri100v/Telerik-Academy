/*Problem 1. Decimal to binary

Write a program to convert decimal numbers to their binary representation.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Problem___Decimal_to_binary
{
    class DecToBin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some number.");
            long decimalNumber = long.Parse(Console.ReadLine());
            //string inputStr = Console.ReadLine();
            //Console.WriteLine("{0} ", decimalNumber + 1);

            //string temp = "555";
            //long decimalNumber = long.Parse(temp);
            string binaryNumber = "";
            
            while (decimalNumber > 0)
            {
                var digit = decimalNumber % 2;
                binaryNumber = digit + binaryNumber;
                decimalNumber /= 2;
            }
            //var charNumToArray = binaryNumber.ToCharArray();
            //Array.Reverse(charNumToArray);
            //binaryNumber = new string(charNumToArray);

            //Console.WriteLine("Decimal number {0} --> {1} ", temp, binaryNumber);
            Console.WriteLine("Binary represent --> {0} ", binaryNumber);

        }
    }
}
