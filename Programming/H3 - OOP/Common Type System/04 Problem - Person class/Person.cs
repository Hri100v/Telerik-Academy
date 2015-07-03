using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemPersonClass
{
    class Person
    {
        //private string name;
        //private int age;

        //public Person(string name)
        //{
        //    this.Name = name;
        //}

        public Person(string name, int? age)
            //:this(name)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get; 
            private set;
        }

        public int? Age
        {
            get;
            private set;
        }

        public override string ToString()
        {
            StringBuilder infoBuilder = new StringBuilder();
            infoBuilder.AppendLine("- personal info -".ToUpper());
            infoBuilder.AppendFormat("Name: {0}", this.Name);
            infoBuilder.Append(Environment.NewLine);
            //infoBuilder.AppendFormat("Age: {0}", (this.Age ?? -1));
            if (this.Age == null)
            {
                infoBuilder.AppendFormat("Age: no data");
            }
            else
            {
                infoBuilder.AppendFormat("Age: {0}", this.Age);
            }
            infoBuilder.AppendLine();

            return infoBuilder.ToString();
        }
    }
}
