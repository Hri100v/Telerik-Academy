/*Problem 2. Compare arrays

Write a program that reads two integer arrays from the console and compares them element by element.
 */

using System;
using System.Text;
using System.Threading;

    class CompareArrays
    {
        static void Main()
        {
            char notEqual = '≠';
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Enter two consecutively arrays.");
            Console.Write("Enter first array. First enter how big is: ");
            int n = int.Parse(Console.ReadLine());
            int[] arrayN = new int[n];
            for (int i = 0; i < n; i++)
            {
                arrayN[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter second array. Now enter how big is: ");
            int s = int.Parse(Console.ReadLine());
            int[] arrayS = new int[s];
            Console.WriteLine("Now enter consecutively all containd numbers: ");
            for (int j = 0; j < s; j++)
            {
                Console.Write("Enter array element {0}: ", j + 1);
                arrayS[j] = int.Parse(Console.ReadLine());
            }

            Console.Clear();
            Console.WriteLine("Comparing of the arras.");
            byte lenN = (byte)arrayN.Length;
            byte lenS = (byte)arrayS.Length;

            for (int l = 0; l < lenN; l++)
            { 
                for (int m = 0; m < lenS; m++)
                {
                    if (arrayN[l] == arrayS[m])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("first array '{0} element' --> {1} is = {2} <-- '{3} element' from second array",l+1, arrayN[l], arrayS[m], m+1);
                        Thread.Sleep(1000);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.WriteLine("first array '{0} element' --> {1} is {2} {3} <-- '{4} element' from second array", l + 1, arrayN[l],notEqual, arrayS[m], m + 1);
                    }
                    
                }
            }
            
            Console.WriteLine();
        }
    }
