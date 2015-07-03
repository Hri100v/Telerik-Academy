/*Problem 1. Allocate array

Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
Print the obtained array on the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Array20Mult5
    {
        static void Main()
        {
            //int [] arrMult = new int[20];

            //for (int i = 0; i < arrMult.Length; i++)
            //{
            //    arrMult[i] = i + 1;
            //    //Console.WriteLine(i + 1);
            //}
            //Console.WriteLine("");
            //Console.WriteLine("Time to Print array container (multiplied by 5).");
            //Console.WriteLine();
            //for (int k = 0; k < arrMult.Length; k++)
            //{
            //    Console.Write("{0} -> ", k + 1);
            //    Console.WriteLine(arrMult[k] * 5);

            //}

            //second edition
            int[] myArray = new int[20];

            for (int i = 0; i < 20; i++)
            {
                myArray[i] = i * 5;
            }
            int length = myArray.Length;

            for (int i = 0; i < length; i++)
            {
                Console.Write("{0} -> ", i);
                Console.WriteLine(myArray[i]);
            }
            Console.WriteLine();

            //int[] myNewArray = new int[length];
            //for (int i = length - 1; i >= 0; i--)
            //{
            //    myNewArray[i] = myArray[length - i - 1];
            //    Console.WriteLine(myNewArray[i]);
            //}
        }
    }