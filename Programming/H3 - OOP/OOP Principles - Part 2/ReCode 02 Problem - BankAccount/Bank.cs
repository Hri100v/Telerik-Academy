

namespace BankAccount
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Bank
    {
        private readonly List<Account> accounts = new List<Account>();

        public string Name { get; private set; }

        public Bank(string name)
        {
            this.Name = name;
        }

        public Bank AddAccount(params Account[] accounts)
        {
            foreach (Account account in accounts)
            {
                this.accounts.Add(account);
            }

            return this;
        }

        public Bank RemoveAccount(Account account)
        {
            this.accounts.Remove(account);

            return this;
        }

        public override string ToString()
        {
            StringBuilder infoBuilder = new StringBuilder();

            infoBuilder.Append("Bank: " + this.Name);

            foreach (Account account in accounts)
                infoBuilder.Append(account.ToString());

            return infoBuilder.ToString();
        }
    }
}
