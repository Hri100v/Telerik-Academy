namespace ProblemBankAccounts
{
    using System;

    public interface ICustomer
    {
        string Name { get; set;}

        EnumCustomerType Customer { get; set; }

    }
}
