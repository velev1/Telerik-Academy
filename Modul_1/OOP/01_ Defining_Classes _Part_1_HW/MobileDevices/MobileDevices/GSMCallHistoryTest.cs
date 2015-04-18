namespace MobileDevices
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class GSMCallHistoryTest
    {
        // The bigger mess :)
        public static void StarCallHistoryTests()
        {
            // initialize new GSM instance (using the built-in iShit)
            GSM newPhone = GSM.Iphone4S;

            // initialize list to store the call, this is not the call histori, just to automate the proces of making calls
            List<Call> callsList = new List<Call>();

            // random generator for multiple purposes
            Random rnd = new Random();

            // let's start calling
            for (int i = 0; i < 10; i++)
            {
                // making some numbers
                string number = String.Format
                    ("+3598{0}{1}{2}{3}{4}{5}{6}{7}{8}",
                    rnd.Next(0, 10), 
                    rnd.Next(0, 10), 
                    rnd.Next(0, 10), 
                    rnd.Next(0, 10),
                    rnd.Next(0, 10), 
                    rnd.Next(0, 10), 
                    rnd.Next(0, 10), 
                    rnd.Next(0, 10),
                    rnd.Next(0, 10));

                // initialize Call instance
                Call currCall = new Call(DateTime.Now.AddMinutes((double)(rnd.Next(10, 50000))), number, rnd.Next(0, 1000));

                // Adding the new call to the list of call, still not to the call history
                callsList.Add(currCall);
            }

            // new list of call - sorted by time of call because the time of call is ramdom but it is normal the call to be sorted by time of call
            var callListSortedBytimeOfCall = callsList.OrderBy(x => x.DateOfCall);

            // now our call from the list are added to the phon's call history
            foreach (var call in callListSortedBytimeOfCall)
            {
                newPhone.AddCall(call);
            }

            // printing call history (from GSM )
            Console.WriteLine(newPhone.ShowCallHistory());

            // printing the bill
            Console.WriteLine("Total amount from call histori is {0}\n", newPhone.CalculeteTotalPriceOfCalls());

            // every time that index must be different because of the random character of the call history
            Console.Write("Enter the index of the longest call: ");
            int index = int.Parse(Console.ReadLine());

            // deleting the longest call (if you enter the correct index, else other than the longest call will be delited)
            newPhone.DeliteCall(index);
            Console.WriteLine("\nTotal amount from call histori is {0}\n", newPhone.CalculeteTotalPriceOfCalls());

            // chech again the call history to see that the delited call is no longer in the history
            Console.WriteLine(newPhone.ShowCallHistory());

            // clear all call from the history (the call in the list are still there)
            newPhone.ClearCallHistory();

            // check again the history to confirm that it is empty
            Console.WriteLine(newPhone.ShowCallHistory());
        }
    }
}
