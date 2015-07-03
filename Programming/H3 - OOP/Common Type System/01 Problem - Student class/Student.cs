/*
 * Problem 2. IClonable
Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type Student.

 * Problem 3. IComparable
Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) 
and by social security number (as second criteria, in increasing order).
 */


using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentClass
{
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }

        // social security number
        public string SSN { get; private set; }
        public string PermanentAddress { get; private set; }
        public string MobilePhone { get; private set; }
        public string EMail { get; private set; }
        public string CourseSpeciality { get; private set; }

        public Specialties Specialties { get; private set; }
        public Faculties Faculties { get; private set; }
        public Universities Universities { get; private set; }

        public Student(string firstName, string middleName, string lastName, string socialSN, string permanentAddress, string mobilePhone, string mail,
                        string courseSpeciality, Specialties specialties, Faculties faculties, Universities universities)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = socialSN;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.EMail = mail;
            this.CourseSpeciality = courseSpeciality;
            this.Specialties = specialties;
            this.Faculties = faculties;
            this.Universities = universities;
        }

        // Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        public override bool Equals(object obj)
        {
            return this.Equals(obj as Student);
        }

        public bool Equals(Student other)
        {
            // check for null
            if (ReferenceEquals(other, null))
                return false;

            // check for same reference
            if (ReferenceEquals(this, other))
                return true;

            // check for same attributes
            // first, middle and last name, SSN, permanent address, 
            // mobile phone, e-mail, course, specialty,
            // university, faculty
            return (FirstName == other.FirstName && MiddleName == other.MiddleName
                    && LastName == other.LastName && SSN == other.SSN
                    && PermanentAddress == other.PermanentAddress && MobilePhone == other.MobilePhone
                    && EMail == other.EMail && CourseSpeciality == other.CourseSpeciality
                    && Specialties == other.Specialties && Universities == other.Universities
                    && Faculties == other.Faculties);

        }

        public override string ToString()
        {
            //repr One Student
            List<string> infoList = new List<string>();
            infoList.Add(string.Empty);
            var newLine = Environment.NewLine;
            infoList.Add("\tSTUDENT: "); infoList.Add(String.Format("\n{0} {1} {2}", this.LastName.ToUpper(), this.FirstName, this.MiddleName));
            infoList.Add(newLine);
            infoList.Add("Social Security Number: \n"); infoList.Add(this.SSN);
            infoList.Add("Address: "); infoList.Add(this.PermanentAddress);
            infoList.Add(String.Format("\nPhone: {0}; e-mail: {1}", this.MobilePhone, this.EMail));
            infoList.Add("\n");
            infoList.Add(String.Format("\n{1} Faculties - {0}, \n\tSpecialties - {2}", this.Faculties, this.Universities, this.Specialties));

            infoList.Add(newLine);

            return string.Join(" ", infoList);
        }

        public override int GetHashCode()
        {
            int hash = 1;

            if (FirstName != null)
                hash = (hash * 17) + FirstName.GetHashCode();

            if (MiddleName != null)
                hash = (hash * 17) + MiddleName.GetHashCode();

            if (LastName != null)
                hash = (hash * 17) + LastName.GetHashCode();

            if (PermanentAddress != null)
                hash = (hash * 17) + PermanentAddress.GetHashCode();

            if (MobilePhone != null)
                hash = (hash * 17) + MobilePhone.GetHashCode();

            if (EMail != null)
                hash = (hash * 17) + EMail.GetHashCode();

            if (CourseSpeciality != null)
                hash = (hash * 17) + CourseSpeciality.GetHashCode();

            if (Specialties != null)
                hash = (hash * 17) + Specialties.GetHashCode();

            if (Universities != null)
                hash = (hash * 17) + Universities.GetHashCode();

            if (Faculties != null)
                hash = (hash * 17) + Faculties.GetHashCode();

            return hash;
            //return base.GetHashCode();
        }

        //public static bool operator ==(Student student1, Student student2)
        //{
        //    if (object.ReferenceEquals(student1, null))
        //        return object.ReferenceEquals(student2, null);

        //    return ReferenceEquals(student1, student2); ;
        //}

        public static bool operator ==(Student student1, Student student2)
        {
            return student1.Equals(student2);
        }

        public static bool operator !=(Student student1, Student student2)
        {
            return !student1.Equals(student2);
        }


        //public object Clone()
        //{
        //    return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.PermanentAddress, this.MobilePhone,
        //                        this.EMail, this.CourseSpeciality, this.Specialties, this.Faculties, this.Universities);
        //}

        public object Clone()
        {
            return this.MemberwiseClone();
        }


        public int CompareTo(Student other)
        {
            if (this.Equals(other)) return 0;

            return Student.Equals(
                new Student[] {this, other}
                    .OrderBy(student => student.FirstName)
                    .ThenBy(student => student.MiddleName)
                    .ThenBy(student => student.LastName)
                    .ThenBy(student => student.SSN)
                    .First()
                , this)
                ? -1
                : 1;
        }
    }
}
