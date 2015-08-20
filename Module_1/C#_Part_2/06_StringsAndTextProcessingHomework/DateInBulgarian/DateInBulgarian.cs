/*
Problem 17. Date in Bulgarian

Write a program that reads a date and time given in the format: day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;

class DateInBulgarian
{
    static void Main()
    {
        //02.02.2015 23:36:32
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("bg-BG");
        CultureInfo timeFormat = CultureInfo.CreateSpecificCulture("bg-BG");
        Console.Write("Enter first date in format \"dd.MM.yyyy HH:mm:ss\": ");
        string DateInput = Console.ReadLine();

        DateTime Date;
        bool TryParseFirst = DateTime.TryParseExact(DateInput, "d.MM.yyyy HH:mm:ss", timeFormat, DateTimeStyles.None, out Date);

        if (TryParseFirst == false)
        {
            Console.WriteLine("\nInvalid Date format!\n\n");
            Main();
        }
        else
        {
            Console.WriteLine("\nAfter 6 hours and 30 minutes: {0:(dddd) dd.MM.yyyy HH:mm:ss}\n ", Date.AddHours(6).AddMinutes(30));
        }
    }
}

