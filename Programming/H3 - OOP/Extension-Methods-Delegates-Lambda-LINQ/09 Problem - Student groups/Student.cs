using System;
using System.Collections.Generic;

namespace _09_Problem___Student_groups
{
    class Student
    {
        // properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber
        private string firstName;
        private string lastName;
        private int fn;
        private int tel;
        private string email;
        public List<int> marks;
        private int groupNumber;

        public Student(string firstName, string lastName, int fn, int tel, string email, List<int> allMarks, int groupNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Tel=tel;
            this.Email = email;
            this.Marks = allMarks;
            this.GroupNumber = groupNumber;
        }

        public Student()
        {
            // TODO: Complete member initialization
        }

        public string FirstName
        {
            get { return firstName; }
            private set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                firstName = value; 
            }
        }

        public string LastName
        {
            get { return lastName; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty");
                }
                lastName = value;
            }
        }

        public int FN
        {
            get { return fn; }
            private set { fn = value; }
        }

        public int Tel
        {
            get { return tel; }
            set { tel = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public List<int> Marks
        {
            get { return this.marks; }
            private set { this.marks = value; }
        }
        public int GroupNumber
        {
            get { return groupNumber; }
            set { groupNumber = value; }
        }
        
        
    }
}
