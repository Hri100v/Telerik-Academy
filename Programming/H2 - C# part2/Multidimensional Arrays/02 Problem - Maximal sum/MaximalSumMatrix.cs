/*Problem 2. Maximal sum

Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
that has maximal sum of its elements.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Problem___Maximal_sum
{
    class MaximalSumMatrix
    {
        static void Main()
        {
            int n = 6;
            int m = 4;
            
            //search sum of matrix 3x3 in (K x K)
            int k = 3;
            #region matrixEntry
            //matrix size N x M (rectengular n != m)
            //int[,] firstMatrix = new int[3, 4] {    
            //                                        { 1, 2, 7, 8 }, 
            //                                        { 300, 4, 9, 1056 }, 
            //                                        { 5, 6, 11, 12 } 
            //                                   };

            //if platform of maxsum is KxK and searching in rectangular matrix NxM
            // => (n + k) != (m + k);
            /*
            while (n == m)
            {
                while (n < k)
                {
                    Console.WriteLine("Write correct N = ");
                    n = int.Parse(Console.ReadLine());
                }
                while (m < k)
                {
                    Console.WriteLine("Write correct M = ");
                    m = int.Parse(Console.ReadLine());
                }
            } */
            #endregion

            // filling matrix N x M only for example
            int[,] firstMatrix = new int[n, m];     //secondMatrix
            for (int rowN = 0; rowN < n; rowN++)
            {
                for (int colM = 0; colM < m; colM++)
                {
                    firstMatrix[rowN, colM] = rowN * m + colM * n;
                }
            }
            //firstMatrix[0, 0] = 1000;
            Console.WriteLine("Matrix: ");
            PrintMatrix(firstMatrix);

            long bestSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;
            int width = firstMatrix.GetLength(1);
            int height = firstMatrix.GetLength(0);

            //long sum = 0;

            for (int row = 0; row < height - k + 1; row++)
            {
                for (int col = 0; col < width - k + 1; col++)
                {
                    long sum = 0;
                    for (int platformRow = row; platformRow < row + k; platformRow++)
                    {
                        for (int platformCol = col; platformCol < col + k; platformCol++)
                        {
                            sum += firstMatrix[platformRow, platformCol];
                        }
                    }
                    if (bestSum < sum)
                    {

                        bestSum = sum;
                        bestRow = row;
                        bestCol = col;
                    }

                    
                }
                Console.WriteLine();
            }
            
            //print best sum matrix 3x3
            Console.WriteLine("Best sum is {0}", bestSum);
            Console.WriteLine("Best Platform ({0} x {0}) is: ", k);
            for (int platformRow = bestRow; platformRow < bestRow + k; platformRow++)
            {
                for (int platformCol = bestCol; platformCol < bestCol + k; platformCol++)
                {
                    Console.Write("{0,2} ", firstMatrix[platformRow, platformCol]);
                }
                Console.WriteLine();
            }
            
            //PrintMatrix(firstMatrix);
            Console.WriteLine();
        }

        private static void PrintMatrix(int[,] MatrixPrinting)
        {

            Console.WriteLine();

            for (int row = 0; row < MatrixPrinting.GetLength(0); row++)
            {
                for (int col = 0; col < MatrixPrinting.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", MatrixPrinting[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string('-', 15));

        }
    }
}
