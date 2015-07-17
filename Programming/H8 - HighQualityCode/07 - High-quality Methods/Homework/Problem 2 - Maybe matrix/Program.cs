using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2MaybeMatrix
{
    class CatEatBooks
    {
        static void Main(string[] args)
        {
            int numberTLines = int.Parse(Console.ReadLine());
            string[] stringArrayOfSequence = new string[numberTLines];
            for (int i = 0; i < numberTLines; i++)
            {
                stringArrayOfSequence[i] = Console.ReadLine();
            }

            for (int j = 0; j < numberTLines; j++)
            {
                var numberArrayOfSequence = SequenceToIntArray(stringArrayOfSequence[j]);
                var numberArrayOfAbsoluteDifference = AbsoluteDifferenceArray(numberArrayOfSequence);
                //Console.WriteLine("==========Test{0}==========", j);
                //Console.WriteLine(String.Join(" ", numberArrayOfSequence));
                //Console.WriteLine(String.Join(" ", AbsoluteDifferenceArray(numberArrayOfSequence)));
                Console.WriteLine(IsIncreasing(numberArrayOfAbsoluteDifference));
                //Console.WriteLine();
            }
            
        }

        private static long[] AbsoluteDifferenceArray(long[] parentArray)
        {
            long bigger = Int32.MinValue;
            long smaller = Int32.MaxValue;
            long absoluteDifference = 0;
            int length = parentArray.Length;
            long[] newArray = new long[length - 1];

            for (int k = 0; k < length - 1; k++)
            {
                bigger = Math.Max(parentArray[k], parentArray[k + 1]);
                smaller = Math.Min(parentArray[k], parentArray[k + 1]);
                absoluteDifference = bigger - smaller;
                newArray[k] = absoluteDifference;
            }

            return newArray;
        }

        private static bool IsIncreasing(long[] array)
        {
            if (array.Length <= 1)
            {
                return true;
            }

            bool isIncrease = false;
            long previousNumber = array[0];
            long nextNumber = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                previousNumber = array[i - 1];
                nextNumber = array[i];

                if (previousNumber <= nextNumber &&
                    (nextNumber - previousNumber) <= 1)
                {
                    isIncrease = true;
                }
                else
                {
                    isIncrease = false;
                    break;
                }
            }

            return isIncrease;
        }

        private static long[] SequenceToIntArray(string line)
        {
            long[] convertedArray = line.Split(' ').Select(x => long.Parse(x)).ToArray();
            
            return convertedArray;
        }

        private static void Print(long[] someArr)
        {
            Console.WriteLine(String.Join(" ", someArr));
        }
    }
}


/*
 Example input              Example output
 4
1 2 4 7 10                  True
-1 2 4 1 5                  False
-2 -2 -1 0 2 4 1 5          True
3 2 4 1 4                   True
 */




//var testArr = new long[] { 99, 113, 127, 114 };
//Print(testArr);
//var absArr = AbsoluteDifferenceArray(testArr);
//Print(absArr);
//var answer = IsIncreasing(absArr);
//Console.WriteLine(answer);