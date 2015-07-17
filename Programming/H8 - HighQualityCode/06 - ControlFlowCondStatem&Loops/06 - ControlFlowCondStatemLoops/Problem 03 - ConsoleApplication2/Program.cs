using System;
using System.Collections.Generic;
using System.Numerics;


namespace Problem03ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            BigInteger productResult = 1;
            List<string> inputArray = ReadInputInArray();
            for (int i = 0; i < inputArray.Count; i++)
            {
                if (i % 2 == 0)
                {
                    productResult *= ProductOfDigitsInNumber(inputArray[i]);
                }
            }

            Console.WriteLine(productResult);
        }

        private static BigInteger ProductOfDigitsInNumber(string number)
        {
            BigInteger product = 1;
            int currentDigit = 1;

            foreach (char digit in number)
            {
                currentDigit = int.Parse(digit.ToString());
                if (currentDigit == 0)
                    currentDigit = 1;

                product *= currentDigit;
            }

            return product;
        }
        
        private static List<string> ReadInputInArray()
        {
            bool isEnd = false;
            List<string> stringInput = new List<string>();
            
            do
            {
                string input = Console.ReadLine();
                
                if (input == "END")
                {
                    break;
                }

                stringInput.Add(input);

            } while (true);
            
            return stringInput;
        }

        private static void PrintList(List<string> inputArray)
        {
            foreach (var item in inputArray)
            {
                Console.WriteLine(item);
            }
        }

    }
}


/*
 namespace Problem_3___ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger numBig;
            bool isEnd = false;
            int count = 0;
            BigInteger product = 1;
            BigInteger productResult = 1;

            while (!isEnd)
            {
                string strExpres = Console.ReadLine();
                //Console.WriteLine(1);

                foreach (char item in strExpres)
                {
                    
		 
                        if (Char.IsDigit(item))
                        {
                            //tempNum = Convert.ToInt32(symbol);
                            string str1 = item.ToString();
                            product = int.Parse(str1);
                            //Console.WriteLine(product + 1);
                            //Console.WriteLine("*");
                            product *= product;
                        }
                        else if (item == ',')
                        {
                            ++count;
                            continue;
                            //Console.WriteLine("*");
                        }

                    if (count % 2 == 0)
                    {
                        productResult *= product;
                    }
                    else
                    {
                        product = 1;
                    }

                    //Console.WriteLine(item);
                }

                //ConsoleKeyInfo key = Console.ReadKey();

                Console.WriteLine(productResult);

                if (strExpres == "END")
                {
                    isEnd = true;
                }
                //++count;
            }

        }
    }
}

 */