/*
Problem 5. Workdays

Write a method that calculates the number of workdays between today and given date, passed as parameter.
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.
*/

using System;
using System.Collections.Generic;
using System.Globalization;

class Workdays
{
    static List<DateTime> hollydays = new List<DateTime>();

    static void Main()
    {
        CultureInfo timeFormat = CultureInfo.InvariantCulture;
        Hollydays();
        Console.Write("Enter end date (hollydays included up to 31.12.2020) in format \"dd.MM.yyyy\": ");
        string timeValue = Console.ReadLine();
        DateTime endDate;
        bool timeParseOK = DateTime.TryParseExact(timeValue, "dd.MM.yyyy", timeFormat, DateTimeStyles.None, out endDate);
        if (timeParseOK == false)
        {
             Console.WriteLine("\nInvalid Date format!\n\n");
             Main();
        }
        else
        {
            Console.WriteLine("\nThe working days from today until {1:dd.MM.yyyy} (incl) are: {0}\n ", WorkDaysFromToday(endDate), endDate);
        }
    }

    static int WorkDaysFromToday(DateTime endDate)
    {
        DateTime currDate = DateTime.Now;

        int workDays = 0;
        for (DateTime j = currDate; j < endDate; j = j.AddDays(1))
        {
            if (j.DayOfWeek != DayOfWeek.Sunday && j.DayOfWeek != DayOfWeek.Saturday &&
                hollydays.Exists(x => x.DayOfYear == j.DayOfYear && j.Year == x.Year) == false)
            {
                ++workDays;
            }
        }
        return workDays;
    }

    static void Hollydays()
    {

        for (int i = (int)(DateTime.Now.Year); i <= 2020; i++)
        {
            // christmass
            hollydays.Add(new DateTime(i, 12, 24));
            hollydays.Add(new DateTime(i, 12, 25));
            hollydays.Add(new DateTime(i, 12, 26));
            // new year
            hollydays.Add(new DateTime(i, 01, 01));
            hollydays.Add(new DateTime(i, 12, 31));
            // 3-ti mart
            hollydays.Add(new DateTime(i, 03, 03));
            // 1 may
            hollydays.Add(new DateTime(i, 06, 01));
            // 6 may
            hollydays.Add(new DateTime(i, 06, 06));
            // independence day
            hollydays.Add(new DateTime(i, 09, 21));
            hollydays.Add(new DateTime(i, 09, 22));
        }

        // Easter 2015
        hollydays.Add(new DateTime(2015, 04, 10));
        hollydays.Add(new DateTime(2015, 04, 11));
        hollydays.Add(new DateTime(2015, 04, 12));
        hollydays.Add(new DateTime(2015, 04, 13));


        // Easter 2016
        hollydays.Add(new DateTime(2016, 04, 29));
        hollydays.Add(new DateTime(2016, 04, 30));
        hollydays.Add(new DateTime(2016, 05, 01));
        hollydays.Add(new DateTime(2016, 05, 02));

        // Easter 2017
        hollydays.Add(new DateTime(2017, 04, 14));
        hollydays.Add(new DateTime(2017, 04, 15));
        hollydays.Add(new DateTime(2017, 04, 16));
        hollydays.Add(new DateTime(2017, 04, 17));

        // Easter 2018
        hollydays.Add(new DateTime(2018, 04, 10));
        hollydays.Add(new DateTime(2018, 04, 11));
        hollydays.Add(new DateTime(2018, 04, 12));
        hollydays.Add(new DateTime(2018, 04, 13));

        // Easter 2019
        hollydays.Add(new DateTime(2019, 04, 26));
        hollydays.Add(new DateTime(2019, 04, 27));
        hollydays.Add(new DateTime(2019, 04, 28));
        hollydays.Add(new DateTime(2019, 04, 29));

        // Easter 2020
        hollydays.Add(new DateTime(2020, 04, 17));
        hollydays.Add(new DateTime(2020, 04, 18));
        hollydays.Add(new DateTime(2020, 04, 19));
        hollydays.Add(new DateTime(2020, 04, 20));
    }
}

