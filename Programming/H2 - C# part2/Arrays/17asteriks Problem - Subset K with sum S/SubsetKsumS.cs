/*Problem 17.* Subset K with sum S

Write a program that reads three integer numbers N, K and S and an array of N elements from the console.
Find in the array a subset of K elements that have sum S or indicate about its absence.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17asteriks_Problem___Subset_K_with_sum_S
{
    class SubsetKsumS
    {
        static void Main(string[] args)
        {
            int n;          // represent numbers in array of N el
            int k;          // represent numbers K elements that have sum S
            int s;          // represent sum S of K numbers

            int[] arrayN = {11, 1, 4, 8, 2, 3, 9, 7, 6, 5, 1, 2, 1 };
            foreach (var item in arrayN)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine(); Console.WriteLine();
            int sumS = 25;
            int elK = 7;
            //how make to start from position ---> remove all elements before
            int startPos = 4;
            Console.WriteLine("Start position is " + "[{0}] = {1}", startPos, arrayN[startPos]);
            
            List<int> listIndex = new List<int>();
            listIndex.Add(1);
            //Console.WriteLine(listIndex[0]);
            List<int> usedNum = new List<int>();
            List<int> UNusedNum = new List<int>();
            UNusedNum = arrayN.ToList();

            if (startPos == 0)
            {
                usedNum.Add(arrayN[0]);
                
                UNusedNum.RemoveAt(0);
            }
            else
            {
                usedNum.Add(arrayN[startPos]);
                for (int i = 0; i <= startPos; i++)
                {
                    UNusedNum.RemoveAt(0);
                }
            }
            int checkSum = usedNum.Sum();


            while (sumS != checkSum)   // || elK != listIndex.Sum()         f || f = F    f || t = T   <><><><><><>  t && t = T    f && t = F  --> while stop now
            {
                if (sumS > checkSum)
                {
                    usedNum.Add(UNusedNum[0]);
                    listIndex.Add(1);       //count +1 
                    UNusedNum.RemoveAt(0);
                    checkSum = usedNum.Sum();
                }
                else        //sumS > checkSum
                {
                    UNusedNum.Add(usedNum[usedNum.Count - 1]);
                    usedNum.RemoveAt(usedNum.Count - 1);
                    listIndex.RemoveAt(0);
                    checkSum = usedNum.Sum();
                }
            }

            if (elK != listIndex.Sum() && sumS == checkSum)
            {
                Console.WriteLine("There was that sum = {0}", checkSum);
                Console.WriteLine("Different number of elemnts (K = {0}) but elements are {1}", elK, listIndex.Sum());
                PrintSome(usedNum);
            }
            else if (elK == listIndex.Sum() && sumS == checkSum)
            {
                Console.WriteLine("The sum = {0} of K = {1}", checkSum, listIndex.Sum());
                PrintSome(usedNum);
            }
            else
            {
                PrintSome(usedNum);
            }

            //PrintSome(usedNum);
            Console.WriteLine();
        }

        private static void PrintSome(List<int> array)
        {
            Console.Write("( ");
            foreach (var element in array)
            {
                Console.Write("{0} ", element);
            }
            Console.WriteLine(")");
        }
    }
}
