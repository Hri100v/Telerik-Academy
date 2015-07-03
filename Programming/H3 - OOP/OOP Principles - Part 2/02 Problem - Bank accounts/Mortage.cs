using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemBankAccounts
{
    class MortageAccount : Account
    {
        private string fullName;
        private string firstName;
        private string lastName;
        private string name;
        private EnumCustomerType customer;
        private decimal interestRate;
        private int months;

        public MortageAccount(string name, EnumCustomerType customer, int months)
            : base(customer)
        {
            if (customer.Equals(EnumCustomerType.Company))
                this.FullName = name;

            if (customer.Equals(EnumCustomerType.Individual))
            {
                var splitted = name.Split(' ');
                this.FirstName = splitted[0];
                this.LastName = splitted[1];
            }

        }

        public string FullName { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set ; }

        public override void DepositMoney()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            if (base.customer.Equals(EnumCustomerType.Company))
                Console.WriteLine("Company - {0}: Deposit Money!", this.FullName);
            if (base.customer.Equals(EnumCustomerType.Individual))
            {
                Console.WriteLine("{0} {1}: Deposit Money!", this.FirstName, this.LastName);
            }
            Console.ForegroundColor = ConsoleColor.Gray;
        }

        public override decimal CalcInterestAmount()
        {
            Console.WriteLine("MortageA");
            return 5;
        }
    }
}
