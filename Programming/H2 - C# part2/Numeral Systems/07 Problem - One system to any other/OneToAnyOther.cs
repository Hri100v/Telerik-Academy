/*Problem 7. One system to any other

Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Problem___One_system_to_any_other
{
    class OneToAnyOther
    {
        static void Main()
        {
            Console.WriteLine("Converting from numeral system A to numeral system B.");
            Console.WriteLine("Convert from A to B. (2 ≤ A, B ≤ 16)");
            //Console.WriteLine("Please choose A: ");
            int s = -1;
            do
            {
                Console.Write("Please enter correct A: ");
                s = int.Parse(Console.ReadLine());
            } while (!(s >= 2) && !(s <= 16));
            
            int d = -1;
            do
            {
                Console.Write("Please enter correct B: ");
                d = int.Parse(Console.ReadLine());
            } while (!(d >= 2) && !(d <= 16));
            
            Console.WriteLine("Choose some number: ");
            string inputStr = Console.ReadLine();
            
            //s = A;    d = B;
            if (s == 10)    //convert dec --> base
            {
                int temp = int.Parse(inputStr);
                Console.WriteLine("convert to {0}", DecToBase(d, temp));
            }
            else if (d == 10)   //convert base --> dec
            {
                //int temp = int.Parse(inputStr);
                Console.WriteLine("convert to {0}", BaseToDec(s, inputStr));
            }
            else
            {
                long tempNumDec = BaseToDec(s, inputStr);
                Console.WriteLine("convert to {0}", DecToBase(d, tempNumDec));
            }

        }

        private static string DecToBase(int numBase, long decimalNum)
        {
            //decimal to base
            
            string convertNumber = "";

            while (decimalNum > 0)
            {
                long digit = decimalNum % numBase; // >> 0-9 - 10-15
                if (digit > 0 && digit < 9)
                {
                    convertNumber = (char)(digit + '0') + convertNumber;
                }
                else
                {
                    convertNumber = (char)(digit - 10 + 'A') + convertNumber;
                }
                decimalNum /= numBase;
            }
            return convertNumber;
        }

        private static long BaseToDec(int numBase, string number)
        {
            //base to decimal
            long decimalNumber = 0;
            
            for (int i = 0; i < number.Length; i++)
            {
                int digit = 0;
                if (number[i] >= '0' && number[i] <= '9')
                {
                    digit = number[i] - '0';
                }
                else
                {
                    digit = number[i] - 'A' + 10;
                }

                decimalNumber += digit * (long)Math.Pow(numBase, number.Length - 1 - i);
            }

            return decimalNumber;
        }
    }
}
