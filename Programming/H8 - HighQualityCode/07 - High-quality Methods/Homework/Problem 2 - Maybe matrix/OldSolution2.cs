//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem_2___Maybe_matrix
//{
//    class CatEatBooks
//    {
//        static void Main(string[] args)
//        {
//            // read
//            int numT = int.Parse(Console.ReadLine());
//            string textTrue = "True";
//            string textFalse = "False";

//            string[] inpLine = new string[numT];
//            for (int i = 0; i < numT; i++)
//            {
//                inpLine[i] = Console.ReadLine();
//            }

//            // read all numT line and find absolute value
//            if (numT >= 4 && numT <= 10)
//            {
//                foreach (var item in inpLine)
//                {

//                    var arr = TransformToArray(item);
//                    if (arr.Length >= 2 && arr.Length <= 20)
//                    {
//                        if (DecreasingSequence(arr))
//                        {
//                            Console.WriteLine("True");
//                        }
//                        else
//                        {
//                            Console.WriteLine("False");
//                        }
//                    }
//                    else
//                    {
//                        Console.WriteLine("False");
//                    }
//                    //DecreasingSequence(arr);
//                    // “True” or “False”

//                }
//            }



//        }

//        private static bool DecreasingSequence(int[] array)
//        {
//            bool isDecreas = false;

//            for (int i = 1; i < array.Length; i++)      //((array[i - 1] - array[i]) == 0 || (array[i - 1] - array[i]) == 1))
//            {
//                if (array[i - 1] >= array[i] && (array[i - 1] - array[i]) <= 1)
//                {
//                    isDecreas = true;
//                }
//                else
//                {
//                    isDecreas = false;
//                    break;
//                }
//            }

//            return isDecreas;
//        }

//        private static int[] TransformToArray(string line)
//        {
//            var lineArr = line.Split(' ').Select(x => int.Parse(x)).ToArray();
//            int[] arrAbs = new int[lineArr.Length - 1];

//            for (int i = 0; i < lineArr.Length - 1; i++)
//            {
//                int big = Math.Max(lineArr[i], lineArr[i + 1]);
//                int small = Math.Min(lineArr[i], lineArr[i + 1]);
//                arrAbs[i] = big - small;
//            }

//            return arrAbs;
//        }
//    }
//}
