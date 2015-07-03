using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemAnimalHierarchy
{
    class Tomcat : Cat
    {
        private string color;
        private EnumSex sex;

        public Tomcat(int age, string name, string breed) 
            : base(age, name, breed) 
        { this.Sex = EnumSex.male; }

        public Tomcat(int age, string name, EnumSex sex, string breed, string color)
            : this(age, name, breed)
        {
            this.Sex = EnumSex.male;
            this.Color = color;
        }

        public string Color { get; set; }
    }
}
