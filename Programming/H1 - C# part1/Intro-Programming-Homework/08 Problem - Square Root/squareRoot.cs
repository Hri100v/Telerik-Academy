/*
 * Problem 8. Square Root

    Create a console application that calculates and prints the square root of the number 12345.
    Find in Internet “how to calculate square root in C#”.
 */
using System;

    class Program
    {
        static void Main()
        {
            //V1
            double rootSt;
            float varSt = 12345F;   //shte se prehvyrli tipa ot float kym double, zashtoto e ot malko kym golqmo
            rootSt = Math.Sqrt(varSt);

            Console.WriteLine(rootSt);

            //V2
            //consolata avtomatichno shte izcisli matematicheski izraz. tyi kato korenkvadraten e stepen 1/2 ot dadenoto chislo (st 0,5)
            Console.WriteLine(Math.Pow(12345, 0.5));
        }
    }
