/*
 Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Example input:

program	user
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	2
Web site:	http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	25
Manager phone:	+359 2 981 981

 * Example output:

Telerik Academy
Address: 231 Al. Malinov, Sofia
Tel. +359 888 55 55 555
Fax: (no fax)
Web site: http://telerikacademy.com/
Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  
 */

using System;

    class PrintCompaniInformation
    {
        static void Main()
        {

            Console.WriteLine("Program user. Please write correct information.");
            Console.Write("Company name: ");
            string companyN = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Company phone number: ");
            string companyPNumber = Console.ReadLine();
            Console.Write("Fax number (If you do not have fax. Please enter n or N and continue): ");
            string fax = Console.ReadLine();
           
            Console.Write("Web site: ");
            string webSite = Console.ReadLine();
            Console.Write("Manager first name: ");
            string managerFirstN = Console.ReadLine();
            Console.Write("Manager last name: ");
            string managerLastN = Console.ReadLine();
            Console.Write("Manager age: ");
            string managerAge = Console.ReadLine();
            Console.Write("Manager phone number: ");
            string managerPhoneN = Console.ReadLine();

            Console.Clear();
/* */       Console.WriteLine("{0}", companyN);
            Console.WriteLine("Address: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", companyPNumber);
            if (fax == "n" || fax == "N")
            {
                Console.WriteLine("Fax: (no fax)");
            }
            else
            {
                Console.WriteLine("Fax: {0}", fax);
            }
            
            Console.WriteLine("Web site: {0}", webSite);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", managerFirstN, managerLastN, managerAge, managerPhoneN);
            Console.WriteLine();

            Console.WriteLine();
            

        }
    }
