using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    class DefClasses
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;

            GSMTest.TestedGSM();
            Console.WriteLine();
            GSMCallHistoryTest.TestCalls();

            Console.WriteLine();
        }
    }
}













/*
            Call proba = new Call("0887771234", 50); //
            Console.WriteLine(proba.ToString());

            ClassGSM phone = new ClassGSM("N97Mini", "Nokia", 199.98, "SomeOne", new Battery(BatteryType.NiMH, "standart"), new Display(4.5));
            Call currentCall = new Call(DateTime.Now.AddDays(1), "0887654321", 58);
            phone.AddCall(currentCall);

            currentCall = new Call(DateTime.Now.AddDays(3), "0887654321", 155);
            phone.AddCall(currentCall);

            foreach (var item in phone.callHistory)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(phone.TotalCostCalls());
 */



/*
 * 
 *          //ClassGSM probenGSM = new ClassGSM("Nokia", "Norway",345, "Kamen", new Battery(BatteryType.NiCd, "standart", 24, -1), new Display(4.5, 32));
            //Console.WriteLine(probenGSM.ToString());

            //ClassGSM testGSM = new ClassGSM("Motorola", "USA", 199.34, "Some Person - Peter", new Battery(BatteryType.Li_Ion, "standart", 16, 8), new Display(4.5, 24));
            //Console.WriteLine(testGSM.ToString());

            //Console.WriteLine(ClassGSM.IPhone4S.ToString());
 * 
ClassGSM firstGSM = new ClassGSM();
            //firstGSM.Model = "Nokia";
            //firstGSM.Manufacturer = "Germany";

            //Console.WriteLine("{0} made in {1}!", firstGSM.Model, firstGSM.Manufacturer);

            // will use this example
            ClassGSM probenGSM = new ClassGSM("Nokia", "Norway",345, "Kamen", new Battery(BatteryType.NiCd, "standart", 24, -1), new Display(4.5, 32));
            Console.WriteLine(probenGSM.ToString());

            ClassGSM testGSM = new ClassGSM("Motorola", "USA", 199.34, "Some Person - Peter", new Battery(BatteryType.Li_Ion, "standart", 16, 8), new Display(4.5, 24));
            Console.WriteLine(testGSM.ToString());

            Console.WriteLine(ClassGSM.IPhone4S.ToString());
            //ClassGSM secondGSM = new ClassGSM();
            //secondGSM.Battery.TypeBattery = BatteryType.Li_Ion;
            //Console.WriteLine(secondGSM.Battery.TypeBattery);
*/