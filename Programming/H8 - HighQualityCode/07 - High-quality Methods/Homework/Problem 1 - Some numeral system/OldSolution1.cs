//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem_1___Some_numeral_system
//{
//    class EnigmaCat
//    {
//        static void Main(string[] args)
//        {

//            // read
//            string[] input = Console.ReadLine().Split(' ');
//            //Console.WriteLine(string.Join(" ", input));
//            int inputLen = input.Length;
//            //Console.WriteLine(inputLen);

//            // TODO
//            // cat alphabeta
//            int size = 21;
//            char[] catAlpha = new char[size];

//            for (int i = 0; i < size; i++)
//            {
//                catAlpha[i] = (char)('a' + i);
//                //Console.WriteLine("{0} - {1}", i, (char)('a' + i));
//            }

//            // human alphabeta 
//            int alphSize = 26;
//            char[] humanAlpha = new char[alphSize];

//            for (int i = 0; i < alphSize; i++)
//            {
//                humanAlpha[i] = (char)('a' + i);
//                //Console.WriteLine("{0} - {1}", i, (char)('a' + i));
//            }

//            //var resDec = ToDecimal("miao", catAlpha);
//            //var result = ToEnglishAlph(61282, humanAlpha);

//            string[] newMessage = new string[inputLen];
//            for (int i = 0; i < inputLen; i++)
//            {
//                newMessage[i] = ToEnglishAlph(ToDecimal(input[i], catAlpha), humanAlpha);
//            }


//            // output
//            //if (input.Length >= 3 && input.Length <= 20)
//            //    {
//            //        newMessage[i] = ToEnglishAlph(ToDecimal(input[i], catAlpha), humanAlpha);
//            //    }
//            Console.WriteLine(string.Join(" ", newMessage));

//            //for (int i = 0; i < newMessage.Length; i++)
//            //{
//            //    if (newMessage.Length >= 3 && newMessage.Length <= 20)
//            //    {
//            //        Console.Write("{0} ", newMessage[i]);
//            //    }
//            //}

//        }

//        private static string ToEnglishAlph(ulong number, char[] array)
//        {
//            string result = string.Empty;
//            ulong decimalNum = number;
//            string convertNumber = "";
//            ulong numBase = 26;

//            while (decimalNum > 0)
//            {
//                ulong digit = decimalNum % numBase; // >> 0-9 - 10-15

//                convertNumber = array[digit] + convertNumber;

//                decimalNum /= numBase;

//                //if (digit > 0 && digit < 9)
//                //{
//                //    convertNumber = (char)(digit + '0') + convertNumber;
//                //}
//                //else
//                //{
//                //    convertNumber = (char)(digit - 10 + 'A') + convertNumber;
//                //}
//            }
//            return convertNumber;


//        }

//        private static ulong ToDecimal(string word, char[] array)
//        {
//            ulong decNum = 0;
//            int lenWord = word.Length;
//            // miao = 4
//            // 0123
//            int indexLetter = -1;
//            //int valueL = -1;
//            for (int i = 0; i < lenWord; i++)
//            {
//                indexLetter = Array.IndexOf(array, word[i]);

//                decNum += (ulong)indexLetter * (ulong)Math.Pow(17, lenWord - i - 1); ;    //decNum += indexLetter * (ulong)Math.Pow(numSys, lenWord - i - 1);
//            }
//            //  58956 + 2312 + 0 + 14 = 61282

//            return decNum;
//        }


//        // two methods 


//    }
//}
