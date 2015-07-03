
namespace BankAccount
{
    using System;
    using System.Collections.Generic;

    abstract class Account
    {
        public Customer Customer { get; protected set; }
        public decimal Balance { get; protected set; }
        public decimal InterestRate { get; protected set; }

        // All accounts have customer, balance and interest rate (monthly based).
        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Account Withdraw(decimal amount)
        {
            this.Balance -= amount;
            return this;
        }

        public virtual decimal CalculateInterest(decimal months)
        {
            if (!(months > 0))
                return 0;

            return this.Balance*this.InterestRate*months;
        }

        public string ToString(string type)
        {
            List<string> infoAboutCustomer = new List<string>();

            infoAboutCustomer.Add(string.Empty);
            infoAboutCustomer.Add("Type: " + type);
            infoAboutCustomer.Add(this.Customer.ToString());
            infoAboutCustomer.Add("Balance:" + this.Balance);
            infoAboutCustomer.Add("Interest Rate: " + this.InterestRate);

            return String.Join(Environment.NewLine, infoAboutCustomer);
        }
    }
}
