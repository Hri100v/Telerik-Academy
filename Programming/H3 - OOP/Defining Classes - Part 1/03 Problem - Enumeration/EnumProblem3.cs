/*Problem 3. Enumeration

Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
 */

using System;
using System.Linq;

namespace Problem3Enumeration
{
    // const string bTypeLiIon = "Li-Ion";

    // BatteryType (Li-Ion, NiMH, NiCd, …)
    enum BatteryType
    {
        LiIon, 
        NiMH, 
        NiCd,
        Alkaline,
        Lithium
    }

    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        private Display display = new Display();
        private Battery battery = new Battery();

        #region def constructors
        // Default constructor
        public GSM()
        {
            this.Model = "[unknown]";
            this.Manufacturer = "[no data for country]";
            this.Price = 0.00M;
            this.Owner = "[Unnamed]";
        }

        // part constr
        public GSM(Battery battery, Display display)
        {
            this.BatteryPr = battery;
            this.DisplayPr = display;
        }

        // another part constr
        public GSM(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        // constructor
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery) //, Display display
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            //this.DisplayPr = display; // ? can do this without this settings ? how ? what is differences ?
            this.BatteryPr = battery;
        }
        #endregion

        #region properties definition
        // properties
        // pr Model
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        // pr Manuf
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        // pr Price
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        // pr Owner
        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        // pr Display
        public Display DisplayPr
        {
            get { return this.display; }
            set { this.display = value; }
        }

        // pr Battery
        public Battery BatteryPr
        {
            get { return this.battery; }
            set { this.battery = value; }
        }
        #endregion

    }

    public class Battery
    {
        private string modelBattery;
        private ushort hoursIDLE;
        private ushort hoursTalk;
        private BatteryType batteryType;

        // def constr        
        public Battery()
        { }

        public Battery(BatteryType batteryType, ushort hoursIDLE)
        {
            this.batteryType = batteryType;
            this.hoursIDLE = hoursIDLE;
        }

        public Battery(string modelBattery)
        {
            this.modelBattery = modelBattery;
        }

        // constr        
        public Battery(string modelBattery, ushort hoursIDLE, ushort hoursTalk)
        {
            this.ModelBattery = modelBattery;
            this.hoursIDLE = hoursIDLE;
            this.HoursTalk = hoursTalk;
        }

        // properties
        // Li-Ion, NiMH, NiCd, [unknown]
        public BatteryType BatteryType
        {
            get { return this.batteryType; }
            set { this.batteryType = value; }
        }

        public string ModelBattery
        {
            get { return this.modelBattery; }
            set { this.modelBattery = value; }
        }

        public ushort HoursIDLE
        {
            get { return this.hoursIDLE; }
            set { this.hoursIDLE = value; }
        }

        public ushort HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

    }

    public class Display
    {
        // display characteristics (size and number of colors)
        private double size;
        private byte numberColor;

        public Display() { }

        public Display(double size)
        {
            this.size = size;
        }

        public Display(double size, byte numberColor)
        {
            this.size = size;
            this.numberColor = numberColor;
        }

        public double Size
        {
            get { return this.size; }
            set { this.size = value; }
        }

        public byte NumberColor
        {
            get { return this.numberColor; }
            set { this.numberColor = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            #region problem1
            GSM firstGSM = new GSM();
            firstGSM.Model = "Nokia";
            firstGSM.Manufacturer = "Germany";
            firstGSM.Price = 105.95M;
            firstGSM.Owner = "Peter";
            GSM secondGSM = new GSM();

            Console.WriteLine("\"{0}\" this is first model made in {2}, price - {3:C}, Owner - {4} \nand this \"{1}\" is second model.", firstGSM.Model, secondGSM.Model, firstGSM.Manufacturer, firstGSM.Price, firstGSM.Owner);

            Battery test = new Battery("NiCd", 14, 12);
            Console.WriteLine(test.ModelBattery + " - " + test.HoursIDLE + " - " + test.HoursTalk);
            GSM prob = new GSM();
            prob.DisplayPr.Size = 12;
            prob.DisplayPr.NumberColor = 32;
            prob.BatteryPr.HoursTalk = 10;

            Console.WriteLine("size - {0}, number of color(s) - {1}", prob.DisplayPr.Size, prob.DisplayPr.NumberColor);
            Console.WriteLine("Talk time {0} hour(s)", prob.BatteryPr.HoursTalk);
            Console.WriteLine();
            #endregion

            #region problem2
            // Problem 2
            Console.WriteLine("===== - Problem 2 - =====");
            double price = 199.90D;
            GSM problem2 = new GSM("Alcatel", 250);
            Console.WriteLine("New model of {0} cost {1} BGN", problem2.Model, problem2.Price);

            // second test2
            Battery batteryT2 = new Battery("Li-Ion");
            Display displayT2 = new Display(12.5);
            string nameT2 = "Motorola";
            GSM gsmT2 = new GSM(batteryT2, displayT2);
            Console.WriteLine("GSM {0}. Have battery - '{1}' and display - '{2}'.", nameT2, batteryT2.ModelBattery, displayT2.Size);
            Console.WriteLine();
            #endregion

            // problem 3
            #region problem3
            Console.WriteLine("===== - Problem 3 - =====");
            // BatteryType (Li-Ion, NiMH, NiCd, …)
            // BatteryType batteryT2 = new BatteryType();
            //Battery batteryT3 = new Battery(BatteryType.NiMH);
            //Console.WriteLine(batteryT3);
           // Display displayT3 = new Display(5);
           // GSM gsmT3 = new GSM(batteryT3, displayT3);
           // Console.WriteLine(gsmT3.BatteryPr.BatteryType);

            Console.WriteLine();
            #endregion

        }
    }
}
