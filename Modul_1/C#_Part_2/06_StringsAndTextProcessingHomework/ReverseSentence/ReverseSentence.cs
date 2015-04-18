//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	output
//C# is not C++, not PHP and not Delphi!	Delphi not and PHP, not C++ not is C#!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseSentence
{
    static void Main()
    {
        string input = "C# is not C++, not PHP and not Delphi!";
        string[] allWords = input.Split(new char[] { ' ', ',', '!', '?', ';', ':', '"','\'', '\t'}, StringSplitOptions.RemoveEmptyEntries);
        StringBuilder tempSent = new StringBuilder();
        tempSent.Append(input);
        int nextIndex = 0;
        int nextLastIndex = input.Length;

        for (int i = 0; i < allWords.Length / 2; i++)
        {
            tempSent.Replace(allWords[i], allWords[allWords.Length - i - 1], nextIndex, allWords[i].Length);
            nextIndex += allWords[allWords.Length - i - 1].Length + 1;
            tempSent.Replace(allWords[allWords.Length - i - 1], allWords[i], nextLastIndex - allWords[i].Length - 1, allWords[allWords.Length - i - 1].Length);
            nextLastIndex -=  allWords[i].Length + 1;
        }

        Console.WriteLine(tempSent);
    }
}
