/*Problem 3. Check for a Play Card

Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. 
 * 
Examples:
character	Valid card sign?
5	        yes
1	        no
Q	        yes
q	        no
P	        no
10	        yes
500	        no
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _03_Problem___Check_for_a_Play_Card
{
    class CheckPlayCard
    {
        static void Main()
        {
            Console.Write("Salute The Player!");
            Console.WriteLine();
            Console.Write("What is your card - ");
            string playerCard = Console.ReadLine();
            string checkCardSign = @"[2-9JQKA]";      //check for 10 maybe in ASCII table ;)
            Regex correctC = new Regex(checkCardSign);
            if (correctC.IsMatch(playerCard))
            {
                Console.WriteLine("yes");
            }
            else if ("10" == playerCard)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

            Console.WriteLine("Let`s play again?!");

        }
    }
}
