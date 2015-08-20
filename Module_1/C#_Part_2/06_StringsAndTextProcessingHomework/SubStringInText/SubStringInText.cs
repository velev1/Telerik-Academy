//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter text to check in: ");
        string text = Console.ReadLine();
        Console.Write("\nEnter the substring to check for: ");
        string subStr = Console.ReadLine();

        int index = -1;
        int subRepeat = 0;

        while (true)
        {
            index = text.IndexOf(subStr, index + 1);
            if (index == -1)
            {
                break;
            }

            subRepeat++;
        }

        Console.WriteLine("\n\"{0}\" is reperated {1} times in the text!\n ", subStr, subRepeat);
    }
}
    
