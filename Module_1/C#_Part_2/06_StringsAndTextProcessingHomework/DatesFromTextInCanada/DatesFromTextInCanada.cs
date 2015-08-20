//Problem 19. Dates from text in Canada

//Write a program that extracts from a given text all dates that match the format DD.MM.YYYY.
//Display them in the standard date format for Canada.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class DatesFromTextInCanada
{
    static void Main()
    {
        string text = string.Format("Today is {0:dd.MM.yyyy}, tommorow is {1:dd.MM.yyyy}, \nthe day after tommorow is a move. \nYestarday was {2:dd.MM.yyyy} but doesn't matter. ANng just to check a fake date 29.02.2009", 
                        DateTime.Now, DateTime.Now.AddDays(1), DateTime.Now.AddDays(-1));
        string[] allWords = text.Split(new [] {" ", ";", ",", ". ", "!", "?", ":"}, StringSplitOptions.RemoveEmptyEntries);
        List<string> dateCandidates = new List<string>();
        var dates = new List<DateTime>();
        string cultire = "ca-CA";
        FindeDates(allWords, dateCandidates);
        ParseRealDates(dateCandidates, dates, cultire);
    }

    static void ParseRealDates(List<string> dateCandidates, List<DateTime> dates, string culture)
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(culture);
        CultureInfo timeFormat = CultureInfo.CreateSpecificCulture(culture);

        foreach (var day in dateCandidates)
        {
            DateTime Date;
            bool TryParse = DateTime.TryParseExact(day, "dd.MM.yyyy", timeFormat, DateTimeStyles.None, out Date);

            if (TryParse)
            {
                dates.Add(Date);
            }
        }

        foreach (var day in dates)
        {
            Console.WriteLine("{0}", day.ToShortDateString());
        }
    }

    static void FindeDates(string[] words, List<string> dates)
    {
        foreach (var word in words)
        {
            int countOfDots = 0;
            int index = -1;

            while (true)
            {
                index = word.IndexOf(".", index + 1);
                if (index > - 1)
                {
                    ++countOfDots;
                }
                else
                {
                    break;
                }
            }

            if (countOfDots == 2)
            {
                int day;
                bool parseDay = int.TryParse(word.Remove(2), out day);
                if (parseDay) 
                {
                    parseDay = (day > 0 && day <= 31);
                }

                int month;
                bool parseMonth = int.TryParse(word.Substring(3, 2), out month);
                if (parseMonth)
                {
                    parseMonth = (month > 0  &&  month <= 12);
                }

                int year;
                bool parseYear = int.TryParse(word.Substring(6, 4), out year);
                if (parseYear)
                {
                    parseYear = (year >= 0 && year <= 9999);
                }

                if (parseDay && parseMonth && parseYear )
                {
                    dates.Add(string.Format("{0}.{1}.{2}", day.ToString().PadLeft(2, '0'), 
                        month.ToString().PadLeft(2, '0'),
                        year.ToString().PadLeft(4, '0')));
                }
            }
        }
    }
}
