/*Problem 7. Selection sort

Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
find the smallest from the rest, move it at the second position, etc.
 */

using System;
using System.Collections.Generic;

    class SelSort
    {
        static void Main()
        {
            int[] someArray = { 64, 25, 12, 22, 11, 1, 4, 8, 2, 3, 9, 7, 6, 5 };
            int sizeOfArray = someArray.Length;
            foreach (var item in someArray)
            {
                Console.Write(" {0}",item);
            }
            Console.WriteLine();

            int[] testArrayThree = new int[3];
            int[] copyArray = new int[sizeOfArray];
            Array.Copy(someArray, copyArray, someArray.Length);
            Array.Copy(someArray, 3, testArrayThree, 0, 3);

            foreach (var item in testArrayThree)
            {
                Console.Write(" {0}",item);
            }
            Console.WriteLine();

            int[] newArraySorted = new int[sizeOfArray];
            int smallerNum = int.MaxValue;
            int tempNum = int.MaxValue;

            for (int i = 0; i < sizeOfArray; i++)
            {
                //tempNum = copyArray[i];
                //copyArray.SetValue();
                smallerNum = int.MaxValue;
                for (int k = 0; k < sizeOfArray; k++)
                {
                    if (smallerNum > copyArray[k])
                    {
                        smallerNum = copyArray[k];
                    }
                    //Array.Copy();
                    
                }
                //.Add   newArraySorted < smallerNum   ???
                int index = Array.IndexOf(copyArray, smallerNum);
                copyArray[index] = tempNum;
                newArraySorted[i] = smallerNum;
                smallerNum = tempNum;
            }
            Console.WriteLine();

            foreach (int smllN in newArraySorted)
            {
                Console.Write(" {0}", smllN);
            }
            Console.WriteLine();

            //Array.Sort(copyArray);
            //foreach (var item in copyArray)
            //{
            //    Console.Write("{0,3}", item);
            //}
            //Console.WriteLine();
        }
    }