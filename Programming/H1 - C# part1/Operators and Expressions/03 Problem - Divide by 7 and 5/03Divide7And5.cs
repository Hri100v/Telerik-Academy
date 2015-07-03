/*Problem 3. Divide by 7 and 5

Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

 * Examples:

n	Divided by 7 and 5?
3	false
0	false
5	false
7	false
35	true
140	true
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Problem___Divide_by_7_and_5
{
    class Divide7And5
    {
        static void Main(string[] args)
        {
            Console.Write("Can be divide on 7 and 5 in same time or no. Please enter some correct number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool boolCheck = false;

            if (((num % 7) == 0) && ((num % 5) == 0))
            {
                boolCheck = true;
                Console.WriteLine(boolCheck);
            }
            else
            {
                
                Console.WriteLine(boolCheck);
            }
        }
    }
}
