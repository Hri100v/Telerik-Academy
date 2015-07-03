/*Problem 8. Number as array

Write a method that adds two positive integer numbers represented as arrays of digits 
(each array element arr[i] contains a digit; the last digit is kept in arr[0]).
Each of the numbers that will be added could have up to 10 000 digits.
 */

namespace Problem8NumberAsArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    class NumberAsArray
    {
        static void Main()
        {
            string line = "    10 123";
            line = line.Trim();
            Console.WriteLine(line);
            var output = line.Select(x => x).ToArray();
            //var array = line
            //                .Trim()
            //                .Select(x => int.Parse(x))
            //                .ToArray();
            Console.WriteLine();
            string[] strLine = new string[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                strLine[i] = line[line.Length - 1 - i].ToString();
            }
            PrintArrStr(strLine);
            Console.WriteLine();

            string num1 = "99";
            string num2 = "1";
            var byteArr1 = num1.Where(n => Char.IsDigit(n)).ToArray();
            foreach (var item in byteArr1)
            {
                Console.WriteLine(item);
            }
            //PrintArrStr(ListByteAdd(byteArr1))
            //Print(newArr);

            Console.WriteLine();
        }
        static List<int> ListByteAdd(byte[] arrNum1, byte[] arrNum2)
        {
            var result = new List<int>(Math.Max(arrNum1.Length, arrNum2.Length));

            // arrNum1 >  9 9 0         arrNum2 >  1 0 0
            int carry = 0;
            for (int i = 0; i < result.Count; i++)
            {
                int currentDigit = (i < arrNum1.Length ? arrNum1[i] : 0) + (i < arrNum2.Length ? arrNum2[i] : 0) + carry;

                carry = currentDigit / 10;
                result.Add(currentDigit % 10);
                
            }

            return result;
        }
 
        private static void PrintArrStr(string[] strLine)
        {
            foreach (var item in strLine)
            {
                Console.Write(item + "! ");
            }
        }

        static void Print(int[] someArray)
        {
            foreach (var item in someArray)
            {
                Console.Write(item + " ");
            }
        }
    }
}
