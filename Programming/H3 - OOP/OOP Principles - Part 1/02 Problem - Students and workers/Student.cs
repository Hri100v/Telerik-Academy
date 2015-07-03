using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemStudentsAndWorkers
{
    class Student : Human
    {
        private string firstName;
        private string lastName;
        private char grade;

        public Student(string firstName, string lastName, char grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public char Grade 
        {
            get { return this.grade; }
            set 
            {
                // A, B, C, D [posibles]
                if ((int)value < (int)'A' && (int)'D' < (int)value )
                {
                    throw new ArgumentOutOfRangeException("Grade have to be A[excellent] - D[poor].");
                }
                this.grade = value;
            } 
        }
    }
}
