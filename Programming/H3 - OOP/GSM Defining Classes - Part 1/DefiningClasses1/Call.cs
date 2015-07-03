/*Problem 8. Calls

Create a class Call to hold a call performed through a GSM.
It should contain date, time, dialled phone number and duration (in seconds).
 */

using System;
using System.Collections.Generic;

namespace DefiningClasses1
{
    public class Call
    {
        // date, time, dialled phone number and duration (in seconds).
        private DateTime time;
        private string dialledPhone = null;
        private TimeSpan duration = TimeSpan.Zero;

        // constr
        public Call(string dialledPhone, int durationInSec)
        {
            this.DialledPhone = dialledPhone;
            this.Duration = TimeSpan.FromSeconds(durationInSec);

            this.Time = DateTime.Now;
        }

        public Call(DateTime time, string dialledPhone, int durationInSec)
        {
            this.DialledPhone = dialledPhone;
            this.Duration = TimeSpan.FromSeconds(durationInSec);

            this.Time = time;
        }

        // prop
        public DateTime Time
        { get; private set; }

        public string DialledPhone
        {
            get { return this.dialledPhone; }

            private set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Dialled phone can not be null!");
                }

                this.dialledPhone = value;
            }
        }

        public TimeSpan Duration
        {
            get { return this.duration; }

            private set
            {
                //if (value.Equals(TimeSpan.Zero))
                //    throw new ArgumentNullException("Duration can not be zero!");

                this.duration = value;
            }

        }

        // method
        public override string ToString()
        {
            List<string> infoCalls = new List<string>();
            infoCalls.Add("Time: " + this.Time);
            infoCalls.Add("Dialled Phone: " + this.DialledPhone);
            infoCalls.Add(string.Format("Duration: {0}min {1}sec", this.Duration.Minutes, this.Duration.Seconds));

            return String.Join(", ", infoCalls);
        }

    }   // end of class Call
}
