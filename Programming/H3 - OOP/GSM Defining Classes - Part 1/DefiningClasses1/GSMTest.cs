/*Problem 7. GSM test

Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses1
{
    class GSMTest
    {
        public static void TestedGSM()
        {
            ClassGSM Nokia = new ClassGSM("6303i classic", "Nokia", 50,"One Favorite", new Battery(BatteryType.Li_Ion, "BL-5CT", 515, 8), new Display(2.2, 16*1000*1000));
            ClassGSM Panasonic = new ClassGSM("VS3", "Panasonic", 35,"Another Favorite", new Battery(BatteryType.Li_Ion, "Standart", 210, 4.5), new Display(2.3, 16*1000*1000));
            ClassGSM Nexus = new ClassGSM("6", "Motorola", 1040, "Some ONe", new Battery(BatteryType.LiPo, "Non-removable", 330, 24), new Display(5.96, 16*1000*1000));
            
            ClassGSM[] gsmArray = new ClassGSM[] {Nokia, Panasonic, Nexus};

            var size = gsmArray.Length;
            var builder = new StringBuilder();

            for (int i = 0; i < size; i++)
            {
                //Console.WriteLine(gsmArray[i]);
                //Console.WriteLine(new string('*', 25));

                builder.AppendLine(gsmArray[i].ToString());
                builder.AppendLine(new string('*', 25));

            }

            builder.AppendLine(ClassGSM.IPhone4S.ToString());

            Console.WriteLine(builder.ToString());

        }
    }
}
