using System;
using System.Collections.Generic;

namespace School
{
    public class Course
    {
        private const int MaxStudentsCount = 30;

        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get { return this.name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    throw new ArgumentNullException("course name", "Course name cannot be null or empty!");

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public Course AddStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException("studetn", "Student cannot be null!");

            if (!(this.students.Count < Course.MaxStudentsCount))
                throw new ArgumentOutOfRangeException("Course is full!");

            if (this.students.Contains(student))
                throw new InvalidOperationException("This student already has joined the class!");

            this.students.Add(student);

            return this;
        }

        public Course RemoveStudent(Student student)
        {
            if (student == null)
                throw new ArgumentNullException("studetn", "Student cannot be null!");

            if (!this.students.Contains(student))
                throw new InvalidOperationException("The student does not attend this class!");

            this.students.Remove(student);

            return this;
        }

    }
}
