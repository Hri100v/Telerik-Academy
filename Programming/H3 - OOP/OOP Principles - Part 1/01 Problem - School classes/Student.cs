using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSchool
{
    class Student : Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private int uniqueN;

        // constructor
        public Student(string firstName, string lastName, int age, string uniqueN)
            : base(firstName, lastName, age)
        {
            this.UniqueN = uniqueN;
        }

        public Student(string firstName, string lastName, int age, string uniqueN, string comments)
            : this(firstName, lastName, age, uniqueN)
        {
            this.Comments = comments;
        }

        // properties
        public int Age
        {
            get { return this.age; }
            private set { this.age = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            private set 
            {
                if (value.Length < 2)
                    throw new ArgumentException("Incorect name (is less than 2 symbols)");
                this.firstName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            private set 
            {
                if (value.Length < 2)
                    throw new ArgumentException("Incorect name (is less than 2 symbols)");
                this.lastName = value; 
            }
        }

        public string UniqueN { get; private set; }
        
        public string Comments { get; set; }

        public override string ToString()
        {
            //Console.WriteLine("STUDENT: {0} {1}, age: {3}", this.FirstName, this.LastName, this.Age);
            var sb = new StringBuilder();
            sb.AppendLine("STUDENT: ");
            sb.AppendLine(string.Format("{0} \n\t{1} [unique class number]", 
                base.ToString(), this.UniqueN));
            if (!string.IsNullOrEmpty(this.Comments))
                sb.AppendLine(this.Comments);

            return sb.ToString();
        }

    }
}
