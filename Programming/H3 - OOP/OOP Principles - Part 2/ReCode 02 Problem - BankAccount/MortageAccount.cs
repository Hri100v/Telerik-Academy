namespace BankAccount
{
    using System;

    class MortageAccount : Account
    {
        public MortageAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is CompanyCustomer)   // && months <= 12      return (0.5M * base.CalculateInterest(months));
                return base.CalculateInterest(Math.Min(months, 12) / 2 + Math.Max(months - 12, 0));

            if (this.Customer is IndividualCustomer)
                return base.CalculateInterest(months - 6);

            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return base.ToString("Mortage Account!");
        }
    }
}
