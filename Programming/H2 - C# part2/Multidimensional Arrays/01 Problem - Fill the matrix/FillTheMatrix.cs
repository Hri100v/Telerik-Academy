/*Problem 1. Fill the matrix

Write a program that fills and prints a matrix of size (n, n) as shown below:
Example for n=4:

a)	                b)	                c)	                d)*
1	5	9	13      1	8	9	16      7	11	14	16      1	12	11	10
2	6	10	14      2	7	10	15      4	8	12	15      2	13	16	9
3	7	11	15      3	6	11	14      2	5	9	13      3	14	15	8
4	8	12	16      4	5	12	13      1	3	6	10      4	5	6	7
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Problem___Fill_the_matrix
{
    class FillTheMatrix
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the size N of matrix (N, N): ");
            //int n = int.Parse(Console.ReadLine());
            //
            int n = 5;
            int[,] arrayA = new int[n, n];
            int[,] arrayB = new int[n, n];
            int[,] arrayC = new int[n, n];
            int[,] arrayD = new int[n, n];
            Console.WriteLine("N = " + n);

            var k = 1;
            var l = 0;

            //  Matrix A    - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            int up = 1;
            for (int row = 0; row < n; row++)
            {
                //k = row + 1;
                for (int col = 0; col < n; col++)
                {
                    //l = col * 4;
                    arrayA[col, row] = up++;      //arrayA[row, col] = k + (l != 0 ? l += 1 : l += 0);
                }
            }
            Console.WriteLine();

            Console.WriteLine(new string('_', 13));
            Console.WriteLine("Matrix A");
            PrintArray(arrayA);


            //  Matrix B    - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            
            for (int row = 0; row < arrayB.GetLength(0); row++)
            {
                k = row + 1;
                for (int col = 0; col < arrayB.GetLength(1); col++)
                {
                    //l = col + 1;
                    if (col % 2 != 0) 
                    {
                        arrayB[row, col] = col * n + n - row;         
                    }
                    else           
                    {
                        arrayB[row, col] = k + col * n;   
                    }

                    //arrayB[row, col] = k + l;
                }
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 18));
            Console.WriteLine("Matrix B");
            PrintArray(arrayB);

/**/
            //  Matrix C    - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            int dimRow, dimCol;
            //dimCol = dimRow = n;
            int marker = 1;
            for (int row = n - 1; row >=0 ; row--)
            {
                dimRow = row;
                dimCol = 0;
                while (dimRow < (n) && dimCol < (n))        //(dimRow < (n - 1) && dimCol < (n - 1)) 
                {
                    arrayC[dimRow++, dimCol++] = marker++;
                }
            }

            for (int col = 1; col < n; col++)
            {
                dimRow = 0;
                dimCol = col;
                while (dimRow < (n) && dimCol < (n))    //(dimRow < (n - 1) && dimCol < (n - 1))
                {
                    arrayC[dimRow++, dimCol++] = marker++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 18));
            Console.WriteLine("Matrix C");
            PrintArray(arrayC);

            //  Matrix D    - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - 
            up = 1;
            int rowD = 0;
            int colD = 0;
            while (arrayD[rowD, colD] == 0)
            {
                while (rowD < n && arrayD[rowD, colD] == 0)
                {
                    arrayD[rowD, colD] = up++;
                    rowD++;
                }
                rowD--;
                colD++;

                //right
                while (colD < n && arrayD[rowD, colD] == 0)
                {
                    arrayD[rowD, colD] = up++;
                    colD++;
                }
                rowD--;
                colD--;

                //up
                while (rowD >= 0 && arrayD[rowD, colD] == 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Cyan;
                    arrayD[rowD, colD] = up++;
                    rowD--;
                }
                rowD++;
                colD--;

                //left
                while (colD >= 0 && arrayD[rowD, colD] == 0)
                {
                    //Console.ForegroundColor = ConsoleColor.Green;
                    arrayD[rowD, colD] = up++;
                    colD--;
                }
                rowD++;
                colD++;

            }

            Console.WriteLine();
            Console.WriteLine(new string('_', 18));
            Console.WriteLine("Matrix D");
            PrintArray(arrayD);


            Console.WriteLine();
        }


//- - - - - - - - - - - - - - - - - - - - - - - - - - - - Print Method - - - - - - - - - - - - - - - - - - - - - - -\\
        private static void PrintArray(int[,] someArray)
        {
            
            Console.WriteLine();
            
            for (int row = 0; row < someArray.GetLength(0); row++)
            {
                for (int col = 0; col < someArray.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", someArray[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(new string ('-', 13));

        }
    }
}
