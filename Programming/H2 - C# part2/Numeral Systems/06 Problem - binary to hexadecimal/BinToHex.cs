/*Problem 6. binary to hexadecimal

Write a program to convert binary numbers to hexadecimal numbers (directly).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Problem___binary_to_hexadecimal
{
    class BinToHex
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some (binary) number.");
            string inputStr = Console.ReadLine();

            Console.WriteLine("to hexadecimal --> {0}", BinaryToHexadecimal(inputStr));
        }

        static string BinaryToHexadecimal(string bin)
        {
            string hex = "";
            Dictionary<string, string> matrixBinHex = new Dictionary<string, string>{
                                                                                        {"0", "0000"},
                                                                                        {"1", "0001"},
                                                                                        {"2", "0010"},
                                                                                        {"3", "0011"},
                                                                                        {"4", "0100"},
                                                                                        {"5", "0101"},
                                                                                        {"6", "0110"},
                                                                                        {"7", "0111"},
                                                                                        {"8", "1000"},
                                                                                        {"9", "1001"},
                                                                                        {"A", "1010"},
                                                                                        {"B", "1011"},
                                                                                        {"C", "1100"},
                                                                                        {"D", "1101"},
                                                                                        {"E", "1110"},
                                                                                        {"F", "1111"},
                                                                                    };

            // 0111 1001
            for (int i = 0; i < bin.Length; i += 4)
            {
                string temp = "";
                string digit = bin.Substring(i, 4);
                temp = matrixBinHex.FirstOrDefault(x => x.Value.Contains(digit)).Key;
                hex += temp;
            }

            return hex;
        }
    }
}
