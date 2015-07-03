/*Problem 5. Hexadecimal to binary

Write a program to convert hexadecimal numbers to binary numbers (directly).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Problem___Hexadecimal_to_binary
{
    class HexToBin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter some (hexadecimal) number.");
            string inputStr = Console.ReadLine();

            Console.WriteLine("to binary --> {0}", HexadecimalToBinary(inputStr));
        }

        static string HexadecimalToBinary(string hex)
        {
            string binary = "";
            Dictionary<string, string> matrixBinHex = new Dictionary<string, string>{
                                                                                        {"0", " 0000"},
                                                                                        {"1", " 0001"},
                                                                                        {"2", " 0010"},
                                                                                        {"3", " 0011"},
                                                                                        {"4", " 0100"},
                                                                                        {"5", " 0101"},
                                                                                        {"6", " 0110"},
                                                                                        {"7", " 0111"},
                                                                                        {"8", " 1000"},
                                                                                        {"9", " 1001"},
                                                                                        {"A", " 1010"},
                                                                                        {"B", " 1011"},
                                                                                        {"C", " 1100"},
                                                                                        {"D", " 1101"},
                                                                                        {"E", " 1110"},
                                                                                        {"F", " 1111"},
                                                                                    };
            
            
            for (int i = 0; i < hex.Length; i++)
            {
                string temp = "";
                string digit = hex[i].ToString();
                matrixBinHex.TryGetValue(digit, out temp);
                binary += temp;
            }
            
            return binary;
        }
    }
}
