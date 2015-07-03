/*Problem 1. Define class

Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
Define 3 separate classes (class GSM holding instances of the classes Battery and Display).
 */

using System;
using System.Threading;
//using ClassDisplay;

namespace ProblemDefineClass
{
    #region test and comment
    //internal class InformationMobile
    //{
    //    private string model;
    //    private string manufacturer;
    //    private decimal price;
    //    private string owner;
    //    private string batteryInfo;     // (model, hours idle and hours talk
    //    private string displayCharact;  // (size and number of colors)

    //    public class GSM
    //    {
    //        public string Model
    //        {
    //            get
    //            {
    //                // place from where take info
    //                return this.Model;
    //            }
    //            set
    //            {
    //                // place where set info
    //                this.Model = value;
    //            }
    //        }

    //        public GSM()
    //        {
    //            this.Model = "unknow";
    //        }

    //        public GSM(string model)
    //        {
    //            this.Model = model;
    //        }

    //    }

    //}

    // private string model;
    // private string manufacturer;
    // private decimal price;
    // private string owner;
    // private string batteryInfo;     // (model, hours idle and hours talk
    // private string displayCharact;  // (size and number of colors)
    #endregion
    
    public class GSM
    {
        private string model;
        private string manufacturer;
        private decimal price;
        private string owner;
        //private 
        private Display display = new Display();
        private Battery battery = new Battery();


        // Default constructor
        public GSM()
        {
            this.Model = "[unknown]";
            this.Manufacturer = "[no data for country]";
            this.Price = 0.00M;
            this.Owner = "[Unnamed]";
        }

        // constructor
        public GSM(string model, string manufacturer, decimal price, string owner, Battery battery) //, Display display
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            //if (price <= 0)
            //    Console.WriteLine("It is Not correct price.");
            this.Price = price;
            this.Owner = owner;
            //this.DisplayPr = display; // ? can do this without this settings ? how ? what is differences ?
            this.BatteryPr = battery;
        }

        // properties
        // pr Model
        public string Model
        {
            get
            {
                // place from where take info
                return this.model;
            }
            set
            {
                // place where set info
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
                //decimal check = 0M;
                //decimal typedVal = value;
                //if (typedVal <= 0)
                //{
                //    Console.WriteLine("_incorrect_price_");
                //}
                //else
                //{
                //    this.price = value; //typedVal;
                //}
                ////if (value <= 0)
                ////{
                ////    Console.WriteLine("incorrect price");
                ////}
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
        
    }

    public class Battery
    {
        //private DateTime hoursIDLE;
        //private DateTime hoursTalk;
        private string modelBattery;
        private ushort hoursIDLE;
        private ushort hoursTalk;

        // constr
        public Battery()
        { }

        // def constr
        public Battery(string modelBattery, ushort hoursIDLE, ushort hoursTalk)
        {
            this.ModelBattery = modelBattery;
            this.hoursIDLE = hoursIDLE;
            this.HoursTalk = hoursTalk;
        }

        // properties
        // Li-Ion, NiMH, NiCd, [unknown]
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
            GSM firstGSM = new GSM();
            firstGSM.Model = "Nokia";
            firstGSM.Manufacturer = "Germany";
            firstGSM.Price = 105.95M;
            firstGSM.Owner = "Peter";
            GSM secondGSM = new GSM();

            Console.WriteLine("\"{0}\" this is first model made in {2}, price - {3:C}, Owner - {4} \nand this \"{1}\" is second model.", firstGSM.Model, secondGSM.Model, firstGSM.Manufacturer, firstGSM.Price,firstGSM.Owner);

            Battery test = new Battery("NiCd", 14, 12);
            Console.WriteLine(test.ModelBattery + " - " + test.HoursIDLE + " - " + test.HoursTalk);
            GSM prob = new GSM();
            prob.DisplayPr.Size = 12;
            prob.DisplayPr.NumberColor = 32;
            prob.BatteryPr.HoursTalk = 10;

            Console.WriteLine("size - {0}, number of color(s) - {1}", prob.DisplayPr.Size, prob.DisplayPr.NumberColor);
            Console.WriteLine("Talk time {0}", prob.BatteryPr.HoursTalk);

        }
    }
}
