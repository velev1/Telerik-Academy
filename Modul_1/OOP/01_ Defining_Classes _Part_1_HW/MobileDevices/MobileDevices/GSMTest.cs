namespace MobileDevices
{
    using System;
    using System.Collections.Generic;
    using MobileDevices;
    
    public class GSMTest
    {
        // Little mess - just for educational purposes :)
        public static void Main()
        {
            // Initialize a list of GSM instances
            List<GSM> gsmList = new List<GSM>();

            // Adding some GSM instances to the list
            gsmList.Add(new GSM("Mi3", Manufacturers.XIAOMI, 200, "Ivko", 
                new Battery("mi3fj", Manufacturers.XIAOMI, BatteryTypes.Li_Pol, 160, 5), 
                new Display("AK47", Manufacturers.LG, 16000000, 5.0M)));

            gsmList.Add(new GSM("Lumia935", Manufacturers.NOKIA));

            gsmList.Add(new GSM("Vibe2", Manufacturers.LENOVO, 500, "Pesho", 
                new Battery("ultraPower4000", Manufacturers.SAMSUNG), 
                new Display("AK47", Manufacturers.SHARP)));

            // Here I'm try the static method to add the "iBulshit"
            gsmList.Add(GSM.Iphone4S);

            // Printing all info for each one GSM in the list - It's possibe thanks to the overide the ToString() method (check at GSM class)
            foreach (var gsm in gsmList)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
            }

            // Redirecting the program to GSMCallHistoryTests
            GSMCallHistoryTest.StarCallHistoryTests();
        }
    }
}
