using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemAnimalHierarchy
{
    class Cat : Animals, ISound
    {
        private string breed;

        public Cat(int age, string name) : base(age, name) { }

        public Cat(int age, string name, EnumSex sex) : base(age, name, sex) { }

        public Cat(int age, string name, string breed)
            : base(age, name)
        {
            this.Breed = breed;
        }


        public string Breed 
        {
            get { return this.breed; }
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("It is not correct. [can not be empty]");
                }
                this.breed = value;
            }
        }

        public void Voice()
        {
            Console.WriteLine("Miau");
        }
    }
}
