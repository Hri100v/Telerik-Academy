/*
 Problem 1. Define class

Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
 * battery characteristics (model, hours idle and hours talk) and 
 * display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

 */

/*
 Problem 9. Call history

Add a property CallHistory in the GSM class to hold a list of the performed calls.
Try to use the system class List<Call>.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    public class ClassGSM
    {
        
        // problem 6 static field
        private static readonly ClassGSM iPhone4S = new ClassGSM(
            "IPhone4S", "Apple", 1050.00, "Nikodim", 
            new Battery(BatteryType.Li_Ion, "Apple", 200, 8), 
            new Display(3.5, 16*1000*1000));

        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        public List<Call> callHistory = new List<Call>();
        public const double pricePM = 0.37D;

        // constructors
            // default
        public ClassGSM() { }
       
        public ClassGSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
        }

        public ClassGSM(string model, string manufacturer, Battery battery)
            :this (model, manufacturer)
        {
            this.Battery = battery;
        }

        public ClassGSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
            : this(model, manufacturer)
        {
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
        }

        // properties
        public static ClassGSM IPhone4S
        {
            get { return iPhone4S; }
        }

        // Call History prop
        /**/
        public List<Call> CallHistory 
        {
            get 
            {
                return this.callHistory;
            }
            
            set 
            {
                if (!(value is List<Call>))
                {
                    throw new ArgumentException("The value should be of List<Cal> type!");
                }
                this.callHistory = value;
            } 
        }
        /**/

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Manufacturer
        {
            get { return this.manufacturer; }
            private set { this.manufacturer = value; }
        }

        public double Price
        {
            get { return this.price; }
            private set { this.price = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set 
            { 
                this.owner = value; 
            }
        }

        public Battery Battery
        {
            get { return this.battery; }
            private set { this.battery = value; }
        }

        public Display Display
        {
            get { return this.display; }
            private set { this.display = value; }
        }


        // methods
        public override string ToString()
        {
            Console.WriteLine(new string('=', 25));
            StringBuilder build = new StringBuilder();
            build.AppendLine("Mobile Phone: ");
            build.AppendLine(String.Format("\tModel - {0}", this.model));       // ("\tModel - {0}", this.model);
            build.AppendLine("\tManufacturer - " + this.Manufacturer);
            build.AppendLine(String.Format("\tThe price is {0} BGN; His owner is {1}", this.Price, this.Owner));
            build.AppendLine(String.Format("\tBattery: \n\t\t{0}", this.Battery.ToString()));
            build.AppendLine(String.Format("\tDisplay: \n\t\t{0}", this.Display.ToString() ?? "no info"));

            return build.ToString();     //String.Format("Battery: \n\t{0}", this.Battery.ToString());
        }


/*
 Problem 10. Add/Delete calls

Add methods in the GSM class for adding and deleting calls from the calls history.
Add a method to clear the call history.
*/ 
        public void AddCall(Call call)
        {
            callHistory.Add(call);
        }

        public void DeleteCall(Call call)
        {
            callHistory.Remove(call);
            // callHistory.RemoveAt() // use to delete concrete call
        }

        public void ClearCall()
        {
            callHistory.Clear();
        }

        // > Problem 12 add
        public Call GetLongestCall()
        {
            return this.callHistory.Max();
        }

        /*
        Problem 11. Call price

        Add a method that calculates the total price of the calls in the call history.
        Assume the price per minute is fixed and is provided as a parameter.
        */

        public double TotalCostCalls()
        {
            double total = 0D;
            double temp = 0D;

            foreach (var call in callHistory)
            {
                temp = call.Duration.TotalSeconds / 60;
                if (temp > 0)
                {
                    total += ((temp < 1 ? 1 : (int)Math.Ceiling(temp)) * pricePM);    
                }

            }

            return total;
        }

    }
}
