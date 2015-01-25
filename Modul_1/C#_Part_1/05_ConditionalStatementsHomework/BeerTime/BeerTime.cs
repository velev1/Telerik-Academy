//Problem 10.* Beer Time

//A beer time is after 1:00 PM and before 3:00 AM.
//Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.
//Examples:

//time	result
//1:00 PM	beer time
//4:30 PM	beer time
//10:57 PM	beer time
//8:30 AM	non-beer time
//02:59 AM	beer time
//03:00 AM	non-beer time
//03:26 AM	non-beer time


namespace BeerTime
{
    using System;
    using System.Globalization;

    class BeerTime
    {

        static void Main()
        {

            CultureInfo timeFormat = CultureInfo.InvariantCulture;

            DateTime pm = DateTime.ParseExact("01:00 PM", "hh:mm tt", timeFormat);
            DateTime am = DateTime.ParseExact("03:00 AM", "hh:mm tt", timeFormat);
            Console.Write("Enter time in format \"hh:mm tt\" :");
            DateTime time;
            string timeValue = Console.ReadLine();
            bool timeParseOK = DateTime.TryParseExact(timeValue, "hh:mm tt", timeFormat, DateTimeStyles.None, out time);

            if (timeParseOK == false)
            {
                Console.WriteLine("Invalid Time format");
            }
            else if ((time > pm) && (time > am))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time ");
            }

        }
        
    }
}
