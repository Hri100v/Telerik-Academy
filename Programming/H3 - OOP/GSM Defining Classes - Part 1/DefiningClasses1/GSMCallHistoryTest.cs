/*
 Problem 12. Call history test

Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.
 */

using System;

namespace DefiningClasses1
{
    public class GSMCallHistoryTest
    {
        public static void TestCalls()
        {

            ClassGSM phone = new ClassGSM("N97Mini", "Nokia", 199.98, "SomeOne", new Battery(BatteryType.NiMH, "standart"), new Display(4.5));
            Call currentCall = new Call(DateTime.Now.AddDays(1), "0887654321", 58);
            phone.AddCall(currentCall);

            currentCall = new Call(DateTime.Now.AddMinutes(24D), "0887654321", 258);
            phone.AddCall(currentCall);

            currentCall = new Call(DateTime.Now.AddDays(3), "0887654321", 155);
            phone.AddCall(currentCall);


            PrintCallHistory(phone);
            // > end Call History


            // > price
            Console.WriteLine("Total cost: {0}EU", phone.TotalCostCalls());
            Console.WriteLine("[price of every started minutes is {0} EU/min]", ClassGSM.pricePM);
            Console.WriteLine();


            // > longest call
            int bestCall = -1;
            Call longestCall = new Call("000", 0);

            FindLongestCall(phone, ref bestCall, ref longestCall);
                // > > deleted
            phone.DeleteCall(longestCall);
            Console.WriteLine("The longest call is {0} seconds", bestCall);
            Console.WriteLine(longestCall.ToString());
            Console.WriteLine();
            Console.WriteLine("- TOTAL COST -");
            Console.WriteLine("Total cost: {0}EU", phone.TotalCostCalls());

            Console.WriteLine();
            PrintCallHistory(phone);

        } // end TestCalls()

        private static void PrintCallHistory(ClassGSM phone)
        {
            Console.WriteLine("Call History:");
            foreach (var item in phone.callHistory)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }

        private static void FindLongestCall(ClassGSM phone, ref int bestCall, ref Call longestCall)
        {
            foreach (var item in phone.callHistory)
            {
                if (bestCall < item.Duration.TotalSeconds)
                {
                    bestCall = (int)item.Duration.TotalSeconds;
                    longestCall = item;
                }
            }
        }


    } // end GSMCallHistoryTest
}
