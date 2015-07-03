/*Problem 5. Maximal increasing sequence

Write a program that finds the maximal increasing sequence in an array.
Example:

input	                result
3, 2, 3, 4, 2, 2, 4	    2, 3, 4
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxIncrSequence
{
    static void Main()
    {                           //It is not Enlgish, but what... 
        int[] intArrHardcore = { 3, 2, 3, 4, 2, 2, 4 };       // ot tuk zapochvam   -->   shte gi sravnqvam posledovatelno index < index + 1 + i ...
        //int[] input = new int[];    //tuk shte si napravq Console.ReadLine() za po posle sled kato go izmislq po zadaden masiv
        
        int size = intArrHardcore.Length;

        int count = 1;
        int taskCount = 0;
        int index = 0;
        
        int[] checkArr = intArrHardcore;
        for (int i = 0; i < size; i++)
        {
            if (i == size - 1)
            {
                Console.Write("{0}.", intArrHardcore[i]);
                continue;
            }
            Console.Write("{0}, ", intArrHardcore[i]);
        }
        //foreach (var item in intArrHardcore)
        //{
        //    Console.Write("{0} ", intArrHardcore[item]);
        //}

        //Console.WriteLine(index);

        for (int i = 1; i < size; i++)
        {
            //3, 2, 3, 4, 2, 2, 4
            //Console.WriteLine("How compare {0} with {1}",checkArr[i - 1], checkArr[i]);
            if (checkArr[i - 1] < checkArr[i])
            {
                //Console.WriteLine("count {0}", count);
                count++;
            }
            else
            {
                count = 1;
                continue;
            }

            if (taskCount < count)
            {
                index = Array.IndexOf(checkArr, checkArr[i]);
                taskCount = count;
            }
        }
        Console.WriteLine();
        //Console.WriteLine(index);

        Console.WriteLine();
        for (int k = taskCount - 1; k >= 0; k--)
        {
            if (k == 0) { Console.Write("{0}", checkArr[index - k]); continue; }
            
            Console.Write("{0}, ",checkArr[index - k]);
        }
        Console.WriteLine();



        //for (int k = 0; k < taskCount; k++)
        //{
        //    Console.WriteLine(checkArr[index - k]);
        //}
        

/*
        for (int i = 0; i < size - 1; i++)
        {
            Console.WriteLine();
            for (int j = 1; j < size; j++)
            {
                //Console.WriteLine(intArrHardcore[j]);
                if (checkArr[i] < intArrHardcore[j])
                {
                    count++;
                }
                else
                {
                    count = 1;
                    index = Array.IndexOf(intArrHardcore, intArrHardcore[j]);
                    Console.WriteLine(index);
                }
            }
        }
*/       


        //I try, I try.....
    }
}