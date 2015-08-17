using System;
using System.Collections.Generic;

namespace School
{
    public class Student : IComparable<Student>
    {
        private const int MinValidIdValue = 10000;
        private const int MaxValidIdValue = 99999;
        private string name;
        private int id;

        public Student(string name, int id)
        {
            this.Name = name;
            this.ID = id;
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("Name");

                this.name = value;
            }
        }

        public int ID
        {
            get { return this.id; }
            set
            {
                if (value < Student.MinValidIdValue || Student.MaxValidIdValue < value)
                    throw new ArgumentOutOfRangeException(
                        String.Format("Id must in range [{0}; {1}]", Student.MinValidIdValue, Student.MaxValidIdValue));

                this.id = value;
            }
        }

        public int CompareTo(Student other)
        {
            return this.ID.CompareTo(other.ID);
        }
    }
}
