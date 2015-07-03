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

namespace BankAccount
{
    class Program
    {
        static void Test(Account account, int months = 12)
        {
            Console.WriteLine(account.Customer);

            for (int i = 1; i < months; i++)
                Console.WriteLine(account.CalculateInterest(i));

            Console.WriteLine();
            
        }

        static void Main()
        {
            {
                Console.WriteLine("Test #Bank system OOP");

                Console.WriteLine(
                    new Bank("First Investment Bank")
                        .AddAccount(
                            new DepositAccount(
                                new CompanyCustomer("HP"), 0, 0.068M)
                                .Deposit(275)
                                .Withdraw(15),

                            new LoanAccount(
                                new IndividualCustomer("Tsving Vey"), 100, 0.058M)
                                .Withdraw(10),

                            new MortageAccount(
                                new IndividualCustomer("PepiTo"), 0, 0.06M)
                        )
                    );
            }


            {
                Console.WriteLine("# Calculate Loan account interest");

                Test(new LoanAccount(
                    new IndividualCustomer("Nakov"), 100, .1M
                ));

                Test(new LoanAccount(
                    new CompanyCustomer("Telerik"), 100, .1M
                ));
            }

            {
                //Console.WriteLine("# Calculate Deposit account interest");

                //TestInterest(new DepositAccount(
                //    new IndividualCustomer("Nakov"), 1000, .1M
                //));

                //TestInterest(new DepositAccount(
                //    new CompanyCustomer("Telerik"), 100, .1M
                //));
            }

            {
                //Console.WriteLine("# Calculate Mortgage account interest");

                //TestInterest(new MortgageAccount(
                //    new IndividualCustomer("Nakov"), 100, .1M
                //));

                //TestInterest(new MortgageAccount(
                //    new CompanyCustomer("Telerik"), 100, .1M
                //), months: 15);
            }

        }
    }
}
