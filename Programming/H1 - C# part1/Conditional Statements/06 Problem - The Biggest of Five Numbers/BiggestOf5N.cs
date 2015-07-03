/*Problem 6. The Biggest of Five Numbers

Write a program that finds the biggest of five numbers by using only five if statements.
Examples:

a	b	c	d	e	biggest
5	2	2	4	1	5
-2	-22	1	0	0	1
-2	4	3	2	0	4
0	-2.5	0	5	5	5
-3	-0.5	-1.1	-2	-0.1	-0.1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Problem___The_Biggest_of_Five_Numbers
{
    class BiggestOf5N
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());
            Console.Write("d = ");
            float d = float.Parse(Console.ReadLine());
            Console.Write("e = ");
            float e = float.Parse(Console.ReadLine());
            

            if (a > b && a > c && a > d && a > e)   //a is biggest
            {
                Console.WriteLine("Boggest is a = {0}", a);
            }
            else if (b > c && b > d && b > e)       //b is biggest
            {
                Console.WriteLine("Boggest is b = {0}", b);
            }
            else if (c > d && c > e)                //c is biggest
            {
                Console.WriteLine("Boggest is c = {0}", c);
            }
            else if (d > e)                         //d is biggest
            {
                Console.WriteLine("Boggest is d = {0}", d);
            }
            else                                    //e is biggest
            {
                Console.WriteLine("Boggest is e = {0}", e);
            }



            
        }
    }
}
