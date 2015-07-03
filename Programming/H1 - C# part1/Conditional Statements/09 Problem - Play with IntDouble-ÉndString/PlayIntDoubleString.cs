/*Problem 9. Play with Int, Double and String

Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.
Example 1:

program	user
Please choose a type:	
1 --> int	
2 --> double	
3 --> string	3
Please enter a string:	hello
hello*	
Example 2:

program	user
Please choose a type:	
1 --> int	
2 --> double	2
3 --> string	
Please enter a double:	1.5
2.5	
 */

using System;
using System.Threading;

    class PlayIntDoubleString
    {
        static void Main()
        {
            bool isFalse = true;
            do
            {
                Console.WriteLine("Please choose a type:");
                Console.WriteLine("1 --> int");
                Console.WriteLine("2 --> double");
                Console.WriteLine("3 --> string");
                string type = Console.ReadLine();

                switch (type)
                {
                    case "1":
                        Console.Write("Please enter a int: ");
                        int num = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("{0}",num + 1);
                        isFalse = false;
                        break;
                    case "2":
                        Console.Write("Please enter a double: ");
                        double dec = double.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("{0}",dec + 1.00);
                        isFalse = false;
                        break;
                    case "3":
                        Console.Write("Please enter a string: ");
                        string str = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("{0}*",str);
                        isFalse = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Not correct choose.");
                        isFalse = true;
                        Thread.Sleep(1000);
                        Console.Clear();
                        break;

                }
                
            } while (isFalse);
        }
    }