namespace BankAccount
{
    using System;

    class LoanAccount : Account
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(decimal months)
        {
            if (this.Customer is IndividualCustomer)
                months -= 3;
            //{
            //    return base.CalculateInterest(months - 3);
            //}

            if (this.Customer is CompanyCustomer)
                months -= 2;
            //{
            //    return base.CalculateInterest(months - 2);
            //}
            return base.CalculateInterest(months);
        }

        public override string ToString()
        {
            return base.ToString("Loan Account!");
        }
    }
}
