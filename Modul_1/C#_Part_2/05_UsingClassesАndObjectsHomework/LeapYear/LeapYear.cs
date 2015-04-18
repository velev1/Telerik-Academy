//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;

class LeapYear
{
    static void Main()
    {
        Console.Write("Ente year: ");
        int year = int.Parse(Console.ReadLine());
        bool isLeap = DateTime.IsLeapYear(year);
        Console.WriteLine("Is Leap?: {0}", isLeap);
    }
}

