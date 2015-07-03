using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemAnimalHierarchy
{
    class Dog : Animals, ISound
    {
        private string breed;

        public Dog(int age, string name, EnumSex sex)
            :base(age, name, sex)
        {

        }

        public Dog(int age, string name, EnumSex sex, string breed)
            : base(age, name, sex)
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
            Console.WriteLine("Bau");
        }
    }
}
