/*Problem 8. Prime Number Check

Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
Note: You should check if the number is positive
Examples:

n	Prime?
1	false
2	true
3	true
4	false
9	false
97	true
51	false
-3	false
0	false
 */

using System;

    class PrimeNumberCheck
    {
        static void Main()
        {
            Console.WriteLine("Write Prime Number ");

            int number = Convert.ToInt32(Console.ReadLine());
            bool IsTrue = true;
            bool IsFalse = false;

            // prime number without (0 & 1) are: integer -> can`t divide 2, 3, 5 and 7
            // to find prime number > !(n/2 = 0     n*=abc > a+b+c = m/3 = 0    n/5 = 0     n/7 = 0)
            // n <= 100
            
            //firstN
            int firstN = number % 1000;
            firstN /= 100;

            //secondN
            int secondN = number % 100;
            secondN /= 10;

            //thirdN
            int thirdN = number % 10;
            //thirdN /= 1;
            //Console.WriteLine(thirdN);


            //((checkN / checkN) == 1) && ((checkN / 1) == checkN) && ((checkN % 2 == 0) && ((firstN + secondN + thirdN) % 3 == 0) && (checkN % 5 == 0) && (checkN % 7 == 0)))
            if (number > 1)
            {
                int checkN = number;
                if ((checkN <= 100) && ((checkN % 2) != 0) && ((checkN % 3) != 0) && ((checkN % 5) != 0) && ((checkN % 7) != 0))
                {
                    Console.WriteLine(IsTrue);
                }
                else if ((checkN == 2))
                {
                    Console.WriteLine(IsTrue);
                }
                else if ((checkN == 3))
                {
                    Console.WriteLine(IsTrue);
                }
                else if ((checkN == 5))
                {
                    Console.WriteLine(IsTrue);
                }
                else if ((checkN == 7))
                {
                    Console.WriteLine(IsTrue);
                }
                else
                {
                    Console.WriteLine(IsFalse);
                }
            }
            else
            {
                Console.WriteLine(IsFalse);
            }

        }
    }
