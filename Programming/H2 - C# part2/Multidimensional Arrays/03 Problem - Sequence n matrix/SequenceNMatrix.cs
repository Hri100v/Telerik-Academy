/*Problem 3. Sequence n matrix

We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
Example:

matrix	                result		            matrix	result
ha	fifi   ho	hi      ha, ha, ha              
fo	ha	   hi	xx
xxx	ho	   ha	xx
 * 
 *
 * 
matrix	                result
 s	qq	s               s, s, s
pp	pp	s
pp	qq	s
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Problem___Sequence_n_matrix
{
    class SequenceNMatrix
    {
        static void Main()
        {
            //string[,] sequenceMatr = new string[3,4];
            string[,] sequenceMtr = {   
                                        {"ha",  "fifi", "ho", "hi"},
                                        {"fo",  "ha",   "hi", "xx"},
                                        {"xxx", "ho",   "ha", "xx"}
                                    };

            //string[,] sequenceMtr = {   
            //                            {"ha",  "fifi",   "ho", "hi"},
            //                            {"fo",  "fo",     "fo", "fo"},
            //                            {"xxx", "fifi",   "ha", "xx"}
            //                        };

            //string[,] sequenceMtr = {   
            //                            {"ha",  "fifi",   "ho", "hi"},
            //                            {"fo",  "fifi",   "hi", "xx"},
            //                            {"xxx", "fifi",   "ha", "xx"}
            //                        };

            /*
            Console.Write("Please enter the dimension N of matrix (N, M): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Please enter the dimension M: ");
            int m = int.Parse(Console.ReadLine());
            string[,] sequenceMtr = new string[n, m];
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Matrix [{0},{1}]", row, col);
                    sequenceMtr[row, col] = Console.ReadLine();
                }
            }
            /**/
            Console.WriteLine();

            for (int row = 0; row < sequenceMtr.GetLength(0); row++)
            {
                for (int col = 0; col < sequenceMtr.GetLength(1); col++)
                {
                    Console.Write("{0,4} ", sequenceMtr[row, col]);
                }
                Console.WriteLine();
            }
            
            int width = sequenceMtr.GetLength(1);
            int height = sequenceMtr.GetLength(0);
            int diagonal;
            int counterDiagonal = 0;
            string str = "";
            int countD = 0;
            if (width > height)     // M > N
            {
                diagonal = height;
                for (int col = 0; col < width - height + 1; col++)
                {
                    counterDiagonal = 0;
                    for (int i = 0; i < diagonal; i++)
                    {
                        if (sequenceMtr[0, col] == sequenceMtr[i, col + i])
                        {
                            counterDiagonal++;
                            
                        }
                        else
                        {
                            break;
                        }

                        if (counterDiagonal >= height)
                        {
                            str = sequenceMtr[0, col];
                            countD = counterDiagonal;
                        }
                    }
                }

                for (int col = width - 1; col > height - 1; col--)
                {
                    counterDiagonal = 0;
                    for (int i = 0; i < diagonal; i++)
                    {
                        if (sequenceMtr[0, col] == sequenceMtr[i, col - i])
                        {
                            counterDiagonal++;
                        }
                        else
                        {
                            counterDiagonal--;
                            break;
                        }

                        if (counterDiagonal >= height)
                        {
                            str = sequenceMtr[0, col];
                            countD = counterDiagonal;
                        }
                    }
                }
                //Console.WriteLine(countD);
            }
            else if (width < height)    // M < N
            {
                diagonal = width;
                for (int row = 0; row < height - width + 1; row++)
                {
                    counterDiagonal = 0;
                    for (int i = 0; i < diagonal; i++)
                    {
                        if (sequenceMtr[row, 0] == sequenceMtr[row + i, i])
                        {
                            counterDiagonal++;
                            
                        }
                        else
                        {
                            break;
                        }

                        if (counterDiagonal >= width)
                        {
                            str = sequenceMtr[row, 0];
                            countD = counterDiagonal;
                        }
                    }
                }

                for (int row = height - 1; row > width - 1; row--)
                {
                    counterDiagonal = 0;
                    for (int i = 0; i < diagonal; i++)
                    {
                        if (sequenceMtr[row, 0] == sequenceMtr[row - i, i])
                        {
                            counterDiagonal++;
                        }
                        else
                        {
                            counterDiagonal--;
                            break;
                        }

                        if (counterDiagonal >= height)
                        {
                            str = sequenceMtr[row, 0];
                            countD = counterDiagonal;
                        }
                    }
                }
            }
            //Console.WriteLine(str);

            int checkRow = 1;
            int checkCol = 1;
            

            int counter = 1;
            int countRow = 0;
            string strRow = "";
            //Longest sequesnse in row
            while (checkRow < height)
            {
                //Console.WriteLine("row {0}", checkRow);
                checkCol = 0;
                while (checkCol < width - 1)
                {
                    if (sequenceMtr[checkRow, checkCol] == sequenceMtr[checkRow, ++checkCol])
                    {
                        //strRow = sequenceMtr[checkRow, checkCol];
                        ++counter;
                        if (counter > countRow)
                        {
                            strRow = sequenceMtr[checkRow, checkCol];
                            countRow = counter;
                        }
                        //++countRow;
                    }
                    else break;
                    //++checkCol;
                    
                }

                ++checkRow;
            }
            //Console.WriteLine(strRow);
            //Console.WriteLine(countRow);

            //Longest sequesnse in col
            int countCol = 0;
            string strCol = "";
            counter = 1;
            while (checkCol < width)
            {
                //Console.WriteLine("col {0}", checkCol);
                checkRow = 0;
                while (checkRow < height - 1)
                {
                    if (sequenceMtr[checkRow, checkCol] == sequenceMtr[++checkRow, checkCol])
                    {
                        ++counter;
                        if (counter > countCol)
                        {
                            strCol = sequenceMtr[checkRow, checkCol];
                            countCol = counter;
                        }
                        
                    }
                    else break;
                }

                ++checkCol;
            }
           //Console.WriteLine(strCol);
           //Console.WriteLine(countCol);
            int[] arrayCounters = new int[3];
            arrayCounters[0] = countD;
            arrayCounters[1] = countRow;
            arrayCounters[2] = countCol;
            //Array.TrueForAll()
            int maxValue = arrayCounters.Max();
            int index = Array.IndexOf(arrayCounters, maxValue);
            Console.WriteLine(index);

            Console.WriteLine();
            
            switch (index)
            {
                case 0:
                    for (int i = 0; i < countD; i++)
                    {
                        Console.Write("{0} ", str);
                    }
                    break;
                case 1:
                    for (int i = 0; i < countRow; i++)
                    {
                        Console.Write("{0} ", strRow);
                    }
                    break;
                case 2:
                    for (int i = 0; i < countCol; i++)
                    {
                        Console.Write("{0} ", strCol);
                    }
                    break;
                default:
                    break;
            }

            //Console.WriteLine("The Longest Sequense.");
            //if (countRow > countCol && countCol > countD)
            //{
            //    Console.WriteLine(countRow);
            //    for (int i = 0; i < countRow; i++)
            //    {
            //        Console.Write("{0} ", strRow);
            //    }
            //}
            //else if (countCol > countRow && countRow > countD)
            //{
            //    Console.WriteLine(countCol);
            //    for (int i = 0; i < countCol; i++)
            //    {
            //        Console.Write("{0} ", strCol);
            //    }
            //}
            //else if (countD > countRow && countRow > countD)
            //{
            //    Console.WriteLine(countD);
            //    for (int i = 0; i < countD; i++)
            //    {
            //        Console.Write("{0} ", str);
            //    }
            //}

            
            /**/

            Console.WriteLine();
        }
    }
}
