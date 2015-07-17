using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string courseName, string teacherName = "", IList<string> students = null)
            : base(courseName, teacherName, students)
        {
            return;
        }

        public override string ToString()
        {
            return this.ToStringHelper(new KeyValuePair<string, string>("Town", this.Town));
        }
    }
}
