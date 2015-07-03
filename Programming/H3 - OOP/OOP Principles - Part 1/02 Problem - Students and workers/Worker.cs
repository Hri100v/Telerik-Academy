using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemStudentsAndWorkers
{
    class Worker : Human
    {
        // new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour()
        private string firstName;
        private string lastName;
        private int weekSalary;
        private int workHoursPerDay;
        public readonly int minSalaryPWeek = 75;
        public readonly int maxHourPDay = 18;



        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        //public string FirstName
        //{
        //    get { return this.firstName; }
        //    private set
        //    {
        //        if (value.Length < 3)
        //            throw new ArgumentException("Incorect name (is less than 2 symbols)");
        //        this.firstName = value;
        //    }
        //}

        //public string LastName
        //{
        //    get { return this.lastName; }
        //    private set
        //    {
        //        if (value.Length < 4)
        //            throw new ArgumentException("Incorect name (is less than 3 symbols)");
        //        this.lastName = value;
        //    }
        //}

        public int WeekSalary 
        {
            get { return this.weekSalary;}
            set
            {
                if (value < minSalaryPWeek)
                {
                    throw new ArgumentException(string.Format("Salary can not be less than {0}.", minSalaryPWeek));
                }
                this.weekSalary = value;
            }
            
        }

        public int WorkHoursPerDay
        {
            get { return this.workHoursPerDay; }
            set
            {
                if (value > maxHourPDay)
                {
                    throw new ArgumentException(string.Format("Work hours is maximum {0}.", maxHourPDay));
                }
                this.workHoursPerDay = value;

            }
        }

        public double MoneyPerHour()
        {
            // throw new Exception("MUST BE IMPLEMENT");
            double hourSalary = this.WeekSalary / (this.WorkHoursPerDay * 5);

            return hourSalary;
        }


    }
}
