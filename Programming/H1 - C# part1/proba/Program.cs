using System;
using System.Linq;
using System.Collections.Generic;
//using System.Collections.Generic.List;

class ProgramProba
{
    static void Main()
    {
        //int[] numbers = { 6, 4, 5, 1 };     //{ 6, 4, 5, 7, 9, 1, 2, 12, 13, 21, 65, 3 };
        string inputArrayOne = Console.ReadLine();
        char[] delimiter = new char[] { ',', ' ' };
        string[] inputOne = inputArrayOne.Split(delimiter, StringSplitOptions.RemoveEmptyEntries);


        int[] arrSort = new int[inputOne.Length];
        for (int i = 0; i < inputOne.Length; i++)
        {
            arrSort[i] = int.Parse(inputOne[i]);
        }
        arrSort = MergeSorting(arrSort);
        Console.WriteLine();
        foreach (var item in arrSort)
        {
            Console.WriteLine(item);
            Console.WriteLine(" ");
        }
    }

    static int[] MergeSorting(int[] arrNum)
    {
        return (MergeSortList(arrNum.ToList<int>())).ToArray<int>();
    }

    static List<int> MergeSortList(List<int> toSortList)
        {
            if (toSortList.Count <= 1)
	        {
		        return toSortList;
	        }

            List<int> left = new List<int>();
            List<int> right = new List<int>();
            List<int> result = new List<int>();

            int mid = toSortList.Count / 2;
            for (int i = 0; i < mid; i++)
			{
			    left.Add(toSortList[i]);
			}

            for (int i = mid; i < toSortList.Count; i++)
			{
			    right.Add(toSortList[i]);
			}

            left = MergeSortList(left);
            right = MergeSortList(right);
            result = MakeMegre(left, right);
            return result;
        }

    static List<int> MakeMegre(List<int> left, List<int> right)
    {
        List<int> result = new List<int>();

        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    result.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    result.Add(right[0]);
                    right.RemoveAt(0);
                }
            }
            else if (left.Count > 0)
            {
                result.Add(left[0]);
                left.RemoveAt(0);
            }
            else if (right.Count > 0)
            {
                result.Add(right[0]);
                right.RemoveAt(0);
            }

            return result; 
        }

    }
}

//PS: za da se startira *.exe kato [duma vtora -.exe] > trqbva da se napishe s "" v cdm (DOS) > [ "duma vtora -.exe" ]
//tova e probnotoo