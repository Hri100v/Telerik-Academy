/*Problem 11. Format number

Write a program that reads a number and prints it as a 
 * decimal number, 
 * hexadecimal number, 
 * percentage and 
 * in scientific notation.
Format the output aligned right in 15 symbols.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Problem___Format_number
{
    class FormatNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write number.");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Decimal: \n{0,15}", num);
            Console.WriteLine("Hexadecimal: \n{0,15:x}", num);
            Console.WriteLine("Percentage: \n{0,15:p}", num /100M);
            Console.WriteLine("Scientific notation: \n{0,15:e}", num / 100M);
        }
    }
}
