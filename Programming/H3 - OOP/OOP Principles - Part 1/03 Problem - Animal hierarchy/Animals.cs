using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemAnimalHierarchy
{
    public abstract class Animals //: ISound
    {
        // age, name and sex
        private int age;
        private string name;
        private EnumSex sex;

        public Animals(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public Animals(int age, string name, EnumSex sex)
            : this(age, name)
        {
            this.Sex = sex;
        }

        public EnumSex Sex
        {
            get { return this.sex; }
            protected set { this.sex = value; }
        }
        

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        

        public int Age
        {
            get { return age; }
            set { age = value; }
        }


        //public void Voice()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
