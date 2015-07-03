/*Problem 8. Binary short

Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Problem___Binary_short
{
    class BinaryShort
    {
        
        static void Main()
        {
            Console.WriteLine("Please write some number.");
            ushort number = ushort.Parse(Console.ReadLine());
            
            string binary = String.Empty;

            for (int i = 0; i < 16; i++)
            {
                binary = (number >> i & 1) + binary;
            }

            Console.WriteLine("Binary representation in 16-bit \nsigned integer -> {0}", binary);

        }
    }
}
