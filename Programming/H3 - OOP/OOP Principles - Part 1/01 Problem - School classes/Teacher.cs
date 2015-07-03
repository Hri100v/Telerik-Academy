using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSchool
{
    class Teacher : Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private List<Discipline> disciplines; // = new List<Discipline>();

        // constructor
        public Teacher(string firstName, string lastName, int age, List<Discipline> setOfDisciplines) // List<Discipline>
            : base(firstName, lastName, age)
        {
            this.Disciplines = setOfDisciplines;
        }

        //public Teacher(string firstName, string lastName, int age, string comments)
        //    : this(firstName, lastName, age)
        //{
        //    this.Comments = comments;
        //}

        // properties
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

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public List<Discipline> Disciplines 
        {
            get { return this.disciplines; } 
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentOutOfRangeException("Disciplines can not be less than 1!");
                }
                this.disciplines = value;
            }
        }

        public string Comments { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("TEACHER: ");
            sb.AppendLine(base.ToString());
            if (Disciplines.Count > 0)
            {
                foreach (var item in Disciplines)
                {
                    sb.AppendLine(item.ToString());
                }
            }

            return sb.ToString();
        }

    }
}
