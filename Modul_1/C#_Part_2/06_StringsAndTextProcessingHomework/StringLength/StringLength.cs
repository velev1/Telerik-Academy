//Problem 6. String length

//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Text;

class StringLength
{
    static void Main()
    {
        Console.Write("Enter some text (less or equa to 20 symbols incl spaces): ");
        string text = Console.ReadLine();
        StringBuilder fullText = new StringBuilder();
        if (text.Length < 20)
        {
            fullText.Append(text);

            for (int i = text.Length; i < 20; i++)
            {
                fullText.Append("*");
            }
            Console.WriteLine(fullText);
        }
        else
        {
            Console.WriteLine(text);
        }
    }
}

