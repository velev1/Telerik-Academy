//Problem 10. Unicode characters

//Write a program that converts a string to a sequence of C# Unicode character literals.
//Use format strings.
//Example:

//input	output
//Hi!	\u0048\u0069\u0021

using System;
using System.Text;

class UnicodeCharacters
{
    static void Main()
    {
        string text = "Hi!";
        var toCharLiterals = new StringBuilder();

        foreach (var symbol in text)
        {
            toCharLiterals.Append(string.Format("\\u{0:X4}", (int)symbol));
        }

        Console.WriteLine(toCharLiterals);
    }
}

