/*Problem 5. 64 Bit array

Define a class BitArray64 to hold 64 bit values inside an ulong value.
Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem64BitArray
{
    class Program
    {
        static void Main()
        {
            BitArray64 visited = new BitArray64(18);
            Console.WriteLine(visited);

            int[] newTest = visited.Bits;
            for (int i = 0; i < newTest.Length; i++)
            {
                Console.Write(newTest[i]);
            }

            Console.WriteLine();

            foreach (var item in newTest)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            Console.WriteLine(newTest[0]);
            Console.WriteLine(newTest[62]);

        }
    }
}
