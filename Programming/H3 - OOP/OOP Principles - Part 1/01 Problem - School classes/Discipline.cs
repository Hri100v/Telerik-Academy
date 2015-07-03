using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSchool
{
    internal class Discipline
    {
        // Disciplines have a name, number of lectures and number of exercises.
        private string name;
        private int numLecture;
        private int numEx;

        public Discipline(string name, int numberLecture, int numberExercises)
        {
            this.Name = name;
            this.NumLecture = numberLecture;
            this.NumEx = numberExercises;
        }
        
        public string Name { get; private set; }

        public int NumLecture
        {
            get { return numLecture; }
            set { numLecture = value; }
        }

        public int NumEx
        {
            get { return numEx; }
            set { numEx = value; }
        }

        public override string ToString()
        {
            return String.Format("\t{0} - number of lecture: {1}, number of exercises: {2}", this.Name, this.NumLecture, this.NumEx);
        }

    }
}
