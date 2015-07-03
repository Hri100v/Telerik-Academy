/*Problem 2. Bank accounts

A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. Customers could be individuals or companies.
All accounts have customer, balance and interest rate (monthly based).
 - Deposit accounts are allowed to deposit and with draw money.
 - Loan and mortgage accounts can only deposit money.
All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated as follows: number_of_months * interest_rate.
Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
Deposit accounts have no interest if their balance is positive and less than 1000.
Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
Your task is to write a program to model the bank system by classes and interfaces.
You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the interest functionality through overridden methods.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemBankAccounts
{
    class Program
    {
        static void Main()
        {
            //Customer c = new Customer();
            //c.Name = "Pepo";
            //Console.WriteLine(c.Name);

            ////DepositAcc d = new DepositAcc();
            ////d.Name = "Gita";
            ////d.IndivOrComp = 1;
            ////d.Text = "Customer with individual account.";

            ////Console.WriteLine(d.Name + "!" + d.IndivOrComp + "!" + d.Text);

            //Person person1 = new Person("Stanimir Belomyjev");
            //Console.WriteLine("SSki: {0}", person1.LastName);
            //Console.WriteLine(person1.FirstName);

            //DepositAccount depNewPerson = new DepositAccount("Ivelin Kovachev", EnumCustomerType.Individual, 6.5M, 3);
            //DepositAccount depNewCompany = new DepositAccount("Magestic Resource", EnumCustomerType.Company, 5, 4);
            //DepositAccount testDeposit = new DepositAccount("Pavel Banev", EnumCustomerType.None, 45, 12);

            DepositAccount depNewPerson = new DepositAccount("Ivelin Kovachev", EnumCustomerType.Individual, 12);
            DepositAccount depNewCompany = new DepositAccount("Magestic Resource", EnumCustomerType.Company, 4);
            DepositAccount testDeposit = new DepositAccount("Pavel Banev", EnumCustomerType.None, 12);
            
            depNewCompany.DepositMoney();
            depNewPerson.DepositMoney();

            Console.WriteLine(depNewPerson.CalcInterestAmount());
            Console.WriteLine(depNewCompany.CalcInterestAmount());


            //LoanAccount newLoanAccount = new LoanAccount("Po PPPo", EnumCustomerType.Individual, 3);
            //MortageAccount newMortageAccount = new MortageAccount("Filcho Filov", EnumCustomerType.Individual, 3);
            //var r1 = depNewCompany.CalcInterestAmount();
            //Console.WriteLine(r1);

            //var r2 = newLoanAccount.CalcInterestAmount();
            //Console.WriteLine(r2);

            //var r3 = newMortageAccount.CalcInterestAmount();
            //Console.WriteLine(r3);


        }
    }

    class Customer
    {
        public string Name { get; set; }
    }

    //abstract class Account : Customer
    //{
    //    public int IndivOrComp { get; set; }
    //    public string Name { get; set; }
    //}

    //class DepositAcc : Account
    //{
    //    public string Text { get; set; }
    //}

    class Person
    {
        private string lastName;

        public Person()
        {

        }

        public Person(string name)
        {
            var splitted = name.Split(' ');
            this.FirstName = splitted[0];
            this.LastName = splitted[1];

        }

        public string FirstName { get; private set; }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
    }
}
