/*Problem 7. Encode/decode

Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first 
letter of the string with the first of the key, the second – with the second, etc. 
When the last key character is reached, the next is the first.
 */

using System;
using System.Linq;
using System.Text;

namespace ProblemEncodeDecode
{
    class EncodeDecode
    {
        

        static void Main()
        {
            Console.WriteLine("Write some word (that will be use for chiper).");
            string keyChiper = Console.ReadLine();
            
            Console.WriteLine("Write text for cryptic.");
            string text = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Let`s enrypting process begin.");
            var encode = EncodingDecoding(keyChiper, text);
            var decode = EncodingDecoding(keyChiper, encode);

            Console.WriteLine("Encode > {0}", encode);
            Console.WriteLine();
            Console.WriteLine("Decode > {0}", decode);

            //test
            /*
            var t1 = "c";
            var t2 = "v";
            Console.WriteLine((char)((t1[0] ^ t2[0]) * 12));
            Console.WriteLine((char)(t1[0] ^ t2[0]));
            */
        }

        private static string EncodingDecoding(string key, string text)
        {
            StringBuilder builder = new StringBuilder();
                                                        // 0123     
            for (int i = 0; i < text.Length; i++)       // word > 4(letters)        > i=5  % 4(len) => 1 ... i=8 %4 => 0 ...>...
            {
                builder.Append((char)(text[i] ^ key[i % key.Length]));
            }

            return builder.ToString();
        }

    }
}
