/*Problem 3. Animal hierarchy

Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. 
Dogs, frogs and cats are Animals. All animals can produce sound (specified by the ISound interface). 
Kittens and tomcats are cats. All animals are described by age, name and sex. 
Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method 
(you may use LINQ).
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemAnimalHierarchy
{

    static class Program
    {
        private static Random rnd = new Random();

        static void Main()
        {
            var newAn = new Dog(12, "Toto", EnumSex.male);
            newAn.Voice();

            var kitten1 = new Kitten(6, "Maca", "Siamska");
            Console.WriteLine(kitten1.Sex);
            kitten1.Voice();

            string name = CreateName();
            Console.WriteLine(name);

            //var cats = FillArrCat();
            //foreach (var item in cats)
            //{
            //    Console.WriteLine(item.Name + "!" +item.Sex);
            //}
            Console.WriteLine();
            var r = new Cat(rnd.Next(0, 17), CreateName(), (EnumSex)rnd.Next(0, 2));

            
        }

        public static Cat[] FillArrCat()
        {
            var catArr = new Cat[rnd.Next(3, 16)];
            for (int i = 0; i < catArr.Length; i++)
            {
                catArr[i] = new Cat(rnd.Next(0, 17), CreateName(), (EnumSex)rnd.Next(0, 2));
            }
            return catArr;
        }

        private static bool IsVowel(this char c)
        {
            string vowel = "aeiou";
            return vowel.IndexOf(c) >= 0;
        }

        private static string CreateName()
        {
            // A - Z [65 - 90]
            var name = new StringBuilder();
            char temp;
            name.Append((char)rnd.Next(65, 91));
            for (int i = 1; i < rnd.Next(3, 8); i++)
            {
                
                // a - z [97 - 122]
                if (i == 1)
                {
                    temp = name.ToString()[0];
                }
                else
                {
                    temp = name.ToString()[i - 1];
                }
                
                char symb = (char)rnd.Next(97, 123);
                if (IsVowel(temp)) // letter is vowel 
                {
                    // add consonant [съгласна]
                    name.Append(IsVowel(symb) ? (char)((int)symb + rnd.Next(1, 4)) : symb);
                }
                else // consonant
                {
                    // add vowel                     v -is posible be consonant- v
                    name.Append(IsVowel(symb) ? symb : "aeiou"[rnd.Next(0, 6)]);
                    // a b c d e f g h i j k l m n o p q r s t u v w x y z
                }

                if (rnd.Next(0, 8) == 1)
                    name.Append("bcdfghjklmnpqrstvwxz"[rnd.Next(0, 20)]);
                    //name.Append((char)rnd.Next(98, 123));
                
            }

            return name.ToString();
        }

    }
}
