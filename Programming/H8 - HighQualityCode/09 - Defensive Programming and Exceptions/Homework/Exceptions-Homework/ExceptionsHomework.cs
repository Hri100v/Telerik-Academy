using System;
using System.Collections.Generic;
using System.Text;

class ExceptionsHomework
{
    public static T[] Subsequence<T>(T[] arr, int startIndex, int count)
    {
        if (arr == null || arr.Length == 0)
            throw new ArgumentException("Array cannot be null or empty!");

        if (startIndex < 0 || arr.Length <= startIndex)
            throw new ArgumentOutOfRangeException(
                String.Format("StartIndex must be in range [0 - {0}]!", arr.Length - 1));

        if (count < 0)
            throw new ArgumentException("Count cannot be negative!");

        List<T> result = new List<T>();
        for (int i = startIndex; i < startIndex + count; i++)
        {
            result.Add(arr[i]);
        }

        return result.ToArray();
    }

    public static string ExtractEnding(string str, int count)
    {
        if (String.IsNullOrEmpty(str))
            throw new ArgumentException("String cannot be null or empty!");

        if (count > str.Length)
            throw new ArgumentOutOfRangeException("Invalid count! Count can not be greater than string lenth - " + str.Length);

        StringBuilder result = new StringBuilder();
        for (int i = str.Length - count; i < str.Length; i++)
        {
            result.Append(str[i]);
        }
        return result.ToString();
    }

    public static string CheckPrime(int number)
    {
        for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
        {
            if (number % divisor == 0)
            {
                return number + " is not prime.";
            }
        }

        return number + " is prime.";
    }

    static void Main()
    {
        var substr = Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(String.Join(" ", subarr));

        var allarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(String.Join(" ", allarr));

        var emptyarr = Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(String.Join(" ", emptyarr));

        Console.WriteLine(ExtractEnding("I love C#", 2));
        Console.WriteLine(ExtractEnding("Nakov", 4));
        Console.WriteLine(ExtractEnding("beer", 4));

        // This row - will throw - error  ;}
        //Console.WriteLine(ExtractEnding("Hi", 100));

        Console.WriteLine(CheckPrime(23));
        //try
        //{
        //    CheckPrime(23);
        //    Console.WriteLine("23 is prime.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("23 is not prime");
        //}

        Console.WriteLine(CheckPrime(33));
        //try
        //{
        //    CheckPrime(33);
        //    Console.WriteLine("33 is prime.");
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine("33 is not prime");
        //}

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        double peterAverageResult = peter.CalcAverageExamResultInPercents();
        Console.WriteLine("Average results = {0:p0}", peterAverageResult);
    }
}
