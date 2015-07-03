using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemAnimalHierarchy
{
    class Kitten : Cat
    {
        private string color;
        private EnumSex sex = EnumSex.female;

        public Kitten(int age, string name, string breed) 
            : base(age, name, breed) 
        { this.Sex = EnumSex.female; }

        public Kitten(int age, string name, EnumSex sex, string breed, string color)
            : this(age, name, breed)
        {
            this.Sex = EnumSex.female;
            this.Color = color;
        }

        public string Color { get; set; }

    }
}
