using System;
using System.Text;

namespace ProblemSchool
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        // no constructors
        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        
        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set { this.lastName = value; }
        }

        // method
        public override string ToString() //void?
        {
            StringBuilder txt = new StringBuilder();
            //txt.AppendLine("Person");
            
            //txt.AppendFormat("{0} {1}, age: {2}",this.LastName, this.FirstName, this.Age);
            txt.AppendFormat("{0} {1}", this.LastName, this.FirstName);


            return txt.ToString();
        }

    }
}
