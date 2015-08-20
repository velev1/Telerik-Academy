//Problem 23. Series of letters

//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//Example:

//input	                    output
//aaaaabbbbbcdddeeeedssaa	abcdedsa

using System;
using System.Text;

class SeriesOfLetters
{
    static void Main()
    {
        Console.Write("Enter some string: ");
        string text = Console.ReadLine();  //"aaaaabbbbbcdddeeeedssaa";
        char[] textTocharArray = text.ToCharArray();
        StringBuilder output = new StringBuilder();

        for (int i = 0; i < text.Length - 1; i++)
        {
            if (text[i] != text[i + 1])
            {
                output.Append(text[i]);
            }
            if (i == (text.Length - 2) && text[i] != (text.Length - 1))
            {
                output.Append(text[text.Length - 1]);
            }
        }

        Console.WriteLine(output);
    }
}

