/*
 * Problem 11. Bank Account Data
    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
    bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and 
    descriptive names.
 * 
 * Bulgaria IBAN:  22an/lenght   example - BG80BNBG96611020345678       >BG 80 BNBG 96611020345678<
 */

using System;
using System.Text.RegularExpressions;
using System.Text;

    class bankAcoountData
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Salute!");
            Console.WriteLine();


            //first name
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();

            //middle name
            Console.Write("Enter middle name: ");
            string middleName = Console.ReadLine();

            //last name
            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine();

            //available amount of money (balance)
            //work with current regional settings
            decimal amountMoney = 52000.15M;        // # = 52000.15M this is only for task
            //Console.WriteLine("{0,10:C3}", amountMoney);


            //bank name
            Console.WriteLine();
            Console.Write("Write Bank Name: ");
            string bankName = Console.ReadLine();

  
            //correct IBAN
            //@"^[\-\w]+\.)+[a-zA-Z]{2,4}$      condition  for IBAN ( REGEX )
            Console.Write("Enter IBAN: ");
            string numIBAN;
            string crrCompare = "^[A-Z]{2}[0-9]{2}[A-Z]{4}[0-9]{14}$";    //BG 80 BNBG 96611020345678
            Regex crrctIBAN = new Regex(crrCompare);
            bool trueFalseIBAN = false;
            do
            {
                numIBAN = Console.ReadLine();
                //crrctNum = byte.TryParse(numAccTxT, out numAcc);

                Console.Write("Enter correct IBAN: ");
                if (crrctIBAN.IsMatch(numIBAN))
                {
                    Console.WriteLine("OK");
                    trueFalseIBAN = true;
                }
                else
                {
                    Console.WriteLine("{0} it is not correct IBAN", numIBAN);
                    trueFalseIBAN = false;
                }
            } while (!trueFalseIBAN);
            

            //3 credit cards
            Console.WriteLine();
            //Console.Write("Enter first credit card: ");
            string stringAcc1 = "4 5507 4312 1819";//Console.ReadLine();

            //Console.Write("Enter second credit card: ");
            string stringAcc2 = "4 5507 4323 7277";//Console.ReadLine();

            //Console.Write("Enter third credit card: ");
            string stringAcc3 = "4 5507 4331 9625";//Console.ReadLine();




            //number of credit cards
            //Console.Write("Number of credit cards: ");
            //byte numAcc;
            //string stringAcc = Console.ReadLine();

            /* numAcc = Convert.ToByte(stringAcc);       //for time that I have more time :)
             //string[] mas = new int[numAcc];

             for (int i = 0; i < numAcc; i++)
             {
                 Console.Write("Enter the {0}: ", i+=1);
                 //mas[i] = Console.ReadLine();
                 Console.WriteLine();
             }*/

            //Console.Clear;
            Console.WriteLine(@"First name - {0}, middle name - {1} and last name - {2}, 
    available amount of money (balance) - {3,10:c}, 
    bank name - {4}, IBAN - {5}, 3 credit card - {6},{7},{8}", firstName, middleName, lastName, amountMoney, numIBAN, bankName, stringAcc1, stringAcc2, stringAcc3);
        }
    }