/*Problem 10. Odd and Even Product

You are given n integers (given in a single line, separated by a space).
Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
Examples:

numbers	             result
2 1 1 6 3	         yes
product = 6	
3 10 4 6 5 1	     yes
product = 60	        
4 3 2 5 2	         no
odd_product = 16	
even_product = 15
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class OddEvenProduct
{
    static void Main(string[] args)
    {
        
        char spaceCond = ' ';
        int oddNum = 1;
        int evenNum = 1;
        int count = 1;
        int product = 1;
        
        //Version 1                     //can NOT work with two digits numbers
        //foreach (var item in strNum)
        //{
        //    
        //    if (item != spaceCond)
        //    {
        //    
        //        if (count % 2 != 0)
        //        {
        //            oddNum = oddNum * (int.Parse(item.ToString()));
        //            Console.WriteLine("odd {0}", item);
        //        }
        //        else
        //        {
        //            evenNum = evenNum * (int.Parse(item.ToString()));
        //            Console.WriteLine("even {0}", item);
        //        }
        //
        //        ++ count;
        //    }
        //    //Console.WriteLine("!");
        //
        //}
        //
        //
        //if (evenNum == oddNum)
        //{
        //    product = evenNum;
        //    Console.WriteLine("product = {0}", product);
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("product_even = {0}", evenNum);
        //    Console.WriteLine("product_odd = {0}", oddNum);
        //    Console.WriteLine("No");
        //}


        //Version 2  
      
        byte counter = 1;

        string strN1;
        string strN2;
        string composite;
        int compNum;
       
        do
        {
            ConsoleKeyInfo key = Console.ReadKey();
            ConsoleKeyInfo keyNext;

            if ((int)key.Key == 13)   //key "Enter" = 13
            {
                break;
            }

            if ((int)key.Key != 32)
            {
                keyNext = Console.ReadKey();
                if ((int)keyNext.Key != 32)     //check second key is a number
                {
                    if (counter % 2 != 0)   //check number odd or even
                    {
                        strN1 = key.KeyChar.ToString();
                        strN2 = keyNext.KeyChar.ToString();
                        composite = strN1 + strN2;
                        compNum = int.Parse(composite);
                        oddNum = oddNum * compNum;
                    }
                    else    //even
                    {
                        strN1 = key.KeyChar.ToString();
                        strN2 = keyNext.KeyChar.ToString();
                        composite = strN1 + strN2;
                        compNum = int.Parse(composite);
                        evenNum = evenNum * compNum;
                    }
                    

                    ++counter;
                    if ((int)keyNext.Key == 13)   //key "Enter" = 13
                    {
                        break;
                    }
                }
                else
                {
                    if (counter % 2 != 0)   //odd
                    {
                        strN1 = key.KeyChar.ToString();
                        oddNum = oddNum * (int.Parse(strN1));
                    }
                    else                    //even
                    {
                        strN1 = key.KeyChar.ToString();
                        evenNum = evenNum * (int.Parse(strN1));
                    }
                    ++counter;
                }


            }
            else
            {
               
                continue;
            }
            
        } while (true);

        Console.Clear();
        if (oddNum == evenNum)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
        //Console.WriteLine("Odd {0}", oddNum);
        //Console.WriteLine("Even {0}", evenNum);
        
        //Console.WriteLine("Exit from Loop");

    }
}