/*Problem 9. Sum of n Numbers

Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
Note: You may need to use a for-loop.
Examples:

numbers	    sum
3	        90
20	        
60	        
10	        
5	        6.5
2	        
-1	        
-0.5        	
4	        
2	        
1	        1
1	        
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SumNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Salute.");

            Console.WriteLine("Sum of 'n' numbers");
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            float sum = 0F;
            for (int i = 1; i <= n; i++)
            {
                Console.Write("number {0}: ", i);
                sum += float.Parse(Console.ReadLine());
            }
            Console.WriteLine("Sum of {0} numbers is {1}", n, sum);
        }
    }
