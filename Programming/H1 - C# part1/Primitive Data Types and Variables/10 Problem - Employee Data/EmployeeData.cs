/*
 * Problem 10. Employee Data

    A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
    Use descriptive names. Print the data at the console.
 */

using System;
//using System.Linq;
//using System.Object;
using System.Text.RegularExpressions;

class EmployeeData
    {
        static void Main()
        {
            Console.WriteLine("SALUTE");
            Console.WriteLine();

            Console.WriteLine("Describe Employee.");
            Console.WriteLine();

  /*          string xVar = Console.ReadLine();
            Console.WriteLine(xVar);
            bool contLetter = Regex.IsMatch(xVar, "^[a-zA-Z]+$");
            if (contLetter)
            {
                Console.WriteLine("SALUTE");
            }
            else
            { 
                Console.WriteLine("WronG");
            }*/
            
         //first name
         string firstName;
         bool contLetterF;
         do
         {
             Console.Write("Enter first name: ");
             firstName = Console.ReadLine();
             contLetterF = Regex.IsMatch(firstName, "^[a-zA-Z]+$");
             Console.WriteLine();
         } while (!contLetterF);

         //last name
         string lastName;
         bool contLetterL;
         do 
         {
             Console.Write("Enter last name: ");
             lastName = Console.ReadLine();
             contLetterL = Regex.IsMatch(lastName, "^[a-zA-Z]+$");
             Console.WriteLine();
         } while (!contLetterL);
                     
         //age
         byte personAge;
         Console.Write("Enter age: ");
         string ageTXT;
         byte ageX;
         bool correctAge;

         do
         {
             ageTXT = Console.ReadLine();
             correctAge = byte.TryParse(ageTXT, out ageX);
                
             if (correctAge)
             {
                 //Console.WriteLine("Ok.");
             }
             else
             {
                 Console.WriteLine("NO. {0} is not correct", ageTXT);
             }
             Console.WriteLine();
         } while (!correctAge);

            
         //gender
         string personGender;
         do
         {
                
             Console.Write("Enter gender (m or f): ");
                
             personGender = Console.ReadLine();
             Console.WriteLine();
                
         } while (!(personGender.Equals("m") || personGender.Equals("f")));  

           

         //id
         Console.Write("Enter personal ID: ");
         string idTXT;
         long idX;
         bool correctID = false;
         long ad1;

         do
         {
             idTXT = Console.ReadLine();
             idX = long.Parse(idTXT);
             //Regex xy = new Regex.IsMatch(idX, "^{0,22}[a-z0-9]+$");
             //variation regex >>> "^{0,4}[0-9]+$";  no '-' "^?<=[0-9]+$";
             string crrctRegex = "[0-9]{10}"; //with range 10
             Regex rgx = new Regex(crrctRegex);


             if ((rgx.IsMatch(idTXT)) && (idX > 0))
             {
                 //Console.WriteLine("Ok.");
                 correctID = true;
             }
             else
             {
                 Console.WriteLine("NO. '{0}' is not correct", idTXT);
                 correctID = false;
             }

             Console.WriteLine();
         } while (!correctID);

              

         //employee number

         Console.Write("Enter personal number: ");
         string numTXT;
         long numX;
         bool correctENum = false;
         

         do
         {
             numTXT = Console.ReadLine();
             numX = long.Parse(numTXT);
             //Regex xy = new Regex.IsMatch(idX, "^{0,22}[a-z0-9]+$");
             //variation regex >>> "^{0,4}[0-9]+$";  no '-' "^?<=[0-9]+$";
             string crrctRegexN = "[0-9]{8}"; //with range 10
             Regex rgnum = new Regex(crrctRegexN);


             if ((rgnum.IsMatch(numTXT)) && (numX > 27560000) && (numX <= 27569999))
             {
                 Console.WriteLine("Ok.");
                 correctENum = true;
             }
             else
             {
                 Console.WriteLine("NO. '{0}' is not correct", numTXT);
                 correctENum = false;
             }

             Console.WriteLine();
         } while (!correctENum);


         Console.WriteLine("First name is {0}; last name is {1}; age: {2}; gender: {3}; ID: {4}; personal number: {5}", firstName, lastName, ageX, personGender, idX, numX);
        }
    }