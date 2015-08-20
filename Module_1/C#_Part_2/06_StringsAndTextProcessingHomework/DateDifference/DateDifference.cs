/*
Problem 16. Date difference

Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
Example:

Enter the first date: 27.02.2006
Enter the second date: 3.03.2006
Distance: 4 days
 */

using System;
using System.Globalization;

class DateDifference
{
    static void Main()
    {
        CultureInfo timeFormat = CultureInfo.InstalledUICulture;
        Console.Write("Enter first date in format \"dd.MM.yyyy\": ");
        string firstDateInput = Console.ReadLine();
       
        Console.Write("Enter first date in format \"dd.MM.yyyy\": ");
        string secondtDateInput = Console.ReadLine();

        DateTime firstDate;
        bool TryParseFirst = DateTime.TryParseExact(firstDateInput, "dd.MM.yyyy", timeFormat, DateTimeStyles.None, out firstDate);

        DateTime secondDate;
        bool TryParseSecond = DateTime.TryParseExact(secondtDateInput, "dd.MM.yyyy", timeFormat, DateTimeStyles.None, out secondDate);


        if (TryParseFirst == false || TryParseSecond == false)
        {
            Console.WriteLine("\nInvalid Date format!\n\n");
            Main();
        }
        else
        {
            Console.WriteLine("\nDistance: {0} days\n ", Math.Abs((firstDate - secondDate.Date).Days));
        }
    }
}

