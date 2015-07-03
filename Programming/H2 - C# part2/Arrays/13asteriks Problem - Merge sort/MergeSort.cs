/*Problem 13.* Merge sort

Write a program that sorts an array of integers using the Merge sort algorithm.
 */

using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstTry
{
		 
	
    class MergeSort
    {
        //static void Main()
        //{
        //    //Console.WriteLine("Enter numbers: ");
        //    //int[] numbers = Console.ReadLine()
        //    //                                    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        //    //                                    .Select(x => int.Parse(x))
        //    //                                    .ToArray();
        //    //

        //    //int[] someArray = { 64, 25, 12, 22, 11, 1, 4, 8, 2, 3, 9, 7, 6, 5 };

        //}
        
        //learn recursive method
        //                 L                    mid                   R
        //                 0   1   2   3   4  5  6  7  8  9 10 11 12 13
        //              { 64, 25, 12, 22, 11, 1, 4, 8, 2, 3, 9, 7, 6, 5 }
        //                                            0=64      7=8      13=5
        static public void DoMerge(int[] numbers, int left, int mid, int right)
        {
            int[] temp = new int[25];
            int i, left_end, num_elements, tmp_pos;
            //             5=1
            left_end = (mid - 1);
            tmp_pos = left; // 0=64     
                            //  13-0+1=14
            num_elements = (right - left + 1);

            while ((left <= left_end) && (mid <= right))
            {           //64      <=    //8
                if (numbers[left] <= numbers[mid])
                    temp[tmp_pos++] = numbers[left++];  
                else
                    temp[tmp_pos++] = numbers[mid++];   //temp[tmp_pos] = 8
            }

            while (left <= left_end)
                temp[tmp_pos++] = numbers[left++];

            while (mid <= right)
                temp[tmp_pos++] = numbers[mid++];

            for (i = 0; i < num_elements; i++)
            {
                numbers[right] = temp[right];
                right--;
            }
        }

        static public void MergeSort_Recursive(int[] numbers, int left, int right)
        {
            int mid;

            if (right > left)
            {
                mid = (right + left) / 2;
                MergeSort_Recursive(numbers, left, mid);
                MergeSort_Recursive(numbers, (mid + 1), right);

                DoMerge(numbers, left, (mid + 1), right);
            }
        }


        static void Main(string[] args)
        {
            //Console.WriteLine("Enter numbers: ");
            //int[] numbers = Console.ReadLine()
            //                                    .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            //                                    .Select(x => int.Parse(x))
            //                                    .ToArray();
            //
            //                 L                    mid                   R
            //                 0   1   2   3   4  5  6  7  8  9 10 11 12 13
            int[] numbers = { 64, 25, 12, 22, 11, 1, 4, 8, 2, 3, 9, 7, 6, 5 };

            //int[] numbers = { 3, 8, 7, 5, 2, 1, 9, 6, 4 };
            int len = numbers.Length;

            Console.WriteLine("Sort element by 'MergeSort'");
            MergeSort_Recursive(numbers, 0, len - 1);
            for (int i = 0; i < len; i++)
                Console.WriteLine(numbers[i]);

            //Console.WriteLine(numbers[i]);

        }
        
    }
}