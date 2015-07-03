namespace BankAccount
{
    using System;

    abstract class Customer
    {
        public string Name { get; private set; }

        public Customer(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("Customer: \nName: {0}; Type: {1}", this.Name, this.GetType());
        }
    }
}
