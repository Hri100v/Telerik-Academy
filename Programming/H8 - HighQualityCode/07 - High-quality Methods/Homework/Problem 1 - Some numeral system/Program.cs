using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1SomenumeralSystem
{
    class EnigmaCat
    {
        public const int SIZE_CAT_ALPH = 21;
        public const int SIZE_HUMAN_ALPH = 26;


        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            int inputLength = words.Length;
            string[] newMessage = new string[inputLength];

            for (int i = 0; i < inputLength; i++)
            {
                newMessage[i] = NumberToHumanAlph(WordToDecimal(words[i]));
            }

            Console.WriteLine(string.Join(" ", newMessage));
        }

        private static char[] TakeAlphabetaArray(int size)
        {
            if (size < 1 || 26 < size)
                throw new ArgumentOutOfRangeException("Size of Alphabeta must be between 0 and 26");

            char[] alphabetaArray = new char[size];
            for (int i = 0; i < size; i++)
                alphabetaArray[i] = (char)('a' + i);

            return alphabetaArray;
        }

        private static string NumberToHumanAlph(ulong number)
        {
            char[] arrayHumanAlph = TakeAlphabetaArray(SIZE_HUMAN_ALPH);
            string result = string.Empty;
            ulong decimalNumber = number;
            string convertedWord = "";
            ulong numBase = SIZE_HUMAN_ALPH;

            while (decimalNumber > 0)
            {
                ulong digit = decimalNumber % numBase;
                convertedWord = arrayHumanAlph[digit] + convertedWord;
                decimalNumber /= numBase;
            }
            return convertedWord;


        }

        private static ulong WordToDecimal(string word)
        {
            char[] arrayCatAlphabeta = TakeAlphabetaArray(SIZE_CAT_ALPH);
            ulong decNumber = 0;
            int wordLength = word.Length;
            int indexLetter = -1;
            for (int i = 0; i < wordLength; i++)
            {
                indexLetter = Array.IndexOf(arrayCatAlphabeta, word[i]);
                decNumber += (ulong)indexLetter * (ulong)Math.Pow(SIZE_CAT_ALPH, wordLength - i - 1);
            }

            return decNumber;
        }
    }
}
