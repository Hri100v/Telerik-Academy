/*Problem 3. Correct brackets

Write a program to check if in a given expression the brackets are put correctly.
Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemCorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            //string line = Console.ReadLine();
            string line1 = ")(a+b))";
            string line2 = "((a+b)/5-d)";
            CheckExpression(line1);

            Console.WriteLine();

            CheckExpression(line2);
        }

        private static void CheckExpression(string line)
        {
            bool isCorrectBr = true;
            int countBrackets = 0;
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == '(')
                {
                    countBrackets++;
                }

                if (line[i] == ')')
                {
                    countBrackets--;
                }

                if (countBrackets < 0)
                {
                    isCorrectBr = false;
                }
            }

            Console.Write("'{0}'", line);
            if (isCorrectBr)
            {
                Console.WriteLine(" is correct expression.");
            }
            else
            {
                Console.WriteLine(" is NOT correct expression.");
            }
        }
    }
}
