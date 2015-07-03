/*Problem 5. Maximal area sum

Write a program that reads a text file containing a square matrix of numbers.
Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
The first line in the input file contains the size of matrix N.
Each of the next N lines contain N numbers separated by space.
The output should be a single number in a separate text file.
Example:

input	        output
4 
2 3 3 4         
0 2 3 4         
3 7 1 2         
4 3 3 2	        17
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _05_Problem___Maximal_area_sum
{
    class MaximalAreaSum
    {
        static void Main(string[] args)
        {
            SaveToFile(MaxSum(GetMatrix()));
            Console.WriteLine("File is written!");
            Console.WriteLine("Max Sum - {0}",File.ReadAllText("output.txt"));
        }

        static int[,] GetMatrix()
        {
            string pathInput = "input.txt";
            using (StreamReader reader = new StreamReader(pathInput))
            {
                int sizeM = int.Parse(reader.ReadLine());
                int[,] matrix = new int[sizeM, sizeM];

                for (int i = 0; i < sizeM; i++)
                {
                    string[] numbersLByL = reader.ReadLine().Split(' ');

                    for (int j = 0; j < sizeM; j++)
                    {
                        matrix[i, j] = int.Parse(numbersLByL[j]);
                    }
                }

                return matrix;
            }

        }

        static int MaxSum(int[,] matrix)
        {
            int maxSum = int.MinValue;

            //platform 2x2
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    maxSum = Math.Max(maxSum, matrix[i, j] + matrix[i + 1, j] + matrix[i, j + 1] + matrix[i + 1, j + 1]);
                }
            }

            return maxSum;
        }

        static void SaveToFile(int maxSum)
        {
            using (StreamWriter output = new StreamWriter("output.txt")) 
                output.WriteLine(maxSum);
        }

    }
}

