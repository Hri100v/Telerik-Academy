using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSchool
{
    class SchoolClass
    {
        private string identifier;
        private List<Teacher> teachers;
        private List<Student> students;

        // art class, architectural class, 
        public SchoolClass(string identifier, List<Teacher> setOfTeachers, List<Student> setOfStudents)
        {
            this.Identifier = identifier;
            this.Teachers = setOfTeachers;
            this.Students = setOfStudents;
        }


        public string Identifier 
        {
            get; 
            set; 
        }

        public List<Teacher> Teachers 
        {
            get; 
            set; 
        }

        public List<Student> Students 
        {
            get { return this.students; }
            set 
            {
                if (value.Count < 4)
                    throw new ArgumentException("Class with less than 3 students. It is not correct.");
                this.students = value;
            } 
        }

        public override string ToString()
        {
            StringBuilder represent = new StringBuilder();
            represent.AppendLine("REPRESENT CLASSES");  // (" -+- Represent class -+- ");
            represent.AppendLine();
            represent.AppendFormat("- - - \"{0}\" class - - -", this.Identifier);
            represent.AppendLine();
            represent.AppendLine(new string('.', 30));
            foreach (var item in Teachers)
            {
                represent.AppendLine(item.ToString());
            }
            //represent.AppendLine(Teachers.ToString());
            represent.AppendLine(new string('.', 30));
            foreach (var st in Students)
            {
                represent.AppendLine(st.ToString());
            }



            return represent.ToString();
        }

    }
}
