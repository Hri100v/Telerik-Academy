using System;

namespace Methods
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string OtherInfo { get; set; }

        //public Student(string firstName, string lastName, DateTime birhtDate, string otherInfo)
        //    : this()
        //{
        //    this.FirstName = firstName;
        //    this.LastName = lastName;
        //    this.BirthDate = birhtDate;
        //    this.OtherInfo = otherInfo;
        //}

        public bool IsOlderThan(Student other)
        {
            return this.BirthDate > other.BirthDate;
        }
    }
}
