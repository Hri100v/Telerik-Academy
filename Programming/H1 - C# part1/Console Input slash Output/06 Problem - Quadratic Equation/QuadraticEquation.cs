/*Problem 6. Quadratic Equation

Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it 
(prints its real roots).
 * 
Examples:

a	b	c	roots
2	5	-3	x1=-3; x2=0.5
-1	3	0	x1=3; x2=0
-0.5	4	-8	x1=x2=4
5	2	8	no real roots
 */

using System;
using System.Text;
    class QuadraticEquation
    {
        static void Main()
        {
            Console.WriteLine("Salute!");
            Console.WriteLine();
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("ax2 + bx + c = 0");
            double a;
            do
            {
                Console.Write("Please write 'a ≠ 0': ");
                a = Convert.ToDouble(Console.ReadLine());
            } while (!(a != 0));

            Console.Write("Please write 'b': ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please write 'c': ");
            double c = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            double D = Math.Pow(b, 2) - 4*a*c;
            
            if (D < 0)
            {
                Console.WriteLine("Quadratic Equation do not have real roots");
            }
            else if (D == 0)
            {
                Console.WriteLine("Quadratic Equation have one root - 'x = {0}'", -(b/2*a));
            }
            else
            {
                Console.WriteLine("Quadratic Equation have two roots - 'x1 = {0:0.00} and x2 = {1:0.00}'", ((-b + Math.Pow(D, 0.5)) / (2 * a)),
                                                                                       ((-b - Math.Pow(D, 0.5)) / (2 * a)) );
            }

        }
    }