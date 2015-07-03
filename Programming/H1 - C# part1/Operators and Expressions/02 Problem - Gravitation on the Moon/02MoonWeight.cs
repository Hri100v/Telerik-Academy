/*Problem 2. Gravitation on the Moon

The gravitational field of the Moon is approximately 17% of that on the Earth.
Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
Examples:

weight	weight on the Moon
86	    14.62
74.6	12.682
53.7	9.129
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Problem___Gravitation_on_the_Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please write weight (in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double moonW = weight * 0.17;
            Console.WriteLine(moonW);
            Console.WriteLine("This {0} kg weight in the Moon will be {1} kg.", weight, moonW);
        }
    }
}
