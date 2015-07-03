using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemAnimalHierarchy
{
    class Frog : Animals, ISound
    {
        private string kind;

        public Frog(int age, string name, EnumSex sex)
            :base(age, name, sex)
        {

        }

        public Frog(int age, string name, EnumSex sex, string kind)
            : base(age, name, sex)
        {
            this.Kind = kind;
        }


        public string Kind 
        {
            get { return this.kind; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("It is not correct. [can not be empty]");
                }
                this.kind = value;
            }
        }

        public void Voice()
        {
            Console.WriteLine("Kuak");
        }
    }
}
