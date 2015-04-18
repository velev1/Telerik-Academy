//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;

class Program
{
    static void Main()
    {
        DateTime date = DateTime.Now;
        Console.WriteLine("Today's day of the week is: {0}!", date.DayOfWeek);
    }
}

