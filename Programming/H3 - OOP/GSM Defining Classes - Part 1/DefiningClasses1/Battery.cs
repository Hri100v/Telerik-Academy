using System;

namespace DefiningClasses1
{
    public enum BatteryType
    { Li_Ion, NiMH, NiCd, LiPo, unknown }

    public class Battery
    {
        // battery characteristics (model, hours idle and hours talk)
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType typeBattery;

        // constructors
        public Battery()
        { }

        public Battery(BatteryType typeBattery, string model)
        {
            this.model = model;
            this.TypeBattery = typeBattery;
        }

        public Battery(BatteryType typeBattery, string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.TypeBattery = typeBattery;
            this.hoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }
        // properties
        public BatteryType TypeBattery
        {
            get { return this.typeBattery; }
            set { this.typeBattery = value; }
        }

        public string Model
        {
            get;
            set;
        }

        public double HoursIdle
        {
            get { return this.hoursIdle; }
            set
            {
                if (value <= 0)
                {
                    //throw new ArgumentNullException("It is imposible hours battery Idle work time.");
                    Console.WriteLine("It is imposible hours battery Idle work time.");
                }
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get { return this.hoursTalk; }
            set
            {
                if (value <= 0)
                {
                    //throw new ArgumentNullException("It is imposible hours to talk.");
                    Console.WriteLine("It is imposible hours to talk.");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        // methods
        public override string ToString()
        {
            return String.Format("Type - {0}; \n\t\tModel - {1}; \n\t\tIDLE work time - {2} hours; \n\t\tTalk time - {3} hours;", this.TypeBattery, this.Model, this.HoursIdle, this.HoursTalk);
        }
    }
}
