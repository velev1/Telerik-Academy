//Problem 14. Word dictionary

//A dictionary is stored as a sequence of text lines containing words and their explanations.
//Write a program that enters a word and translates it by using the dictionary.
//Sample dictionary:

//input	        output
//.NET	        platform for applications from Microsoft
//CLR	        managed execution environment for .NET
//namespace	    hierarchical organization of classes

using System;
using System.Collections.Generic;

class WordDictionary
{
    static void Main()
    {
        var dict = new Dictionary<string, string>();
        AddToDict(dict);

        Console.WriteLine("Write somethin to check: ");
        string input = Console.ReadLine().ToString().ToUpper();

        if (dict.ContainsKey(input))
        {
            Console.WriteLine("{0} - {1}", input, dict[input]);
        }
        else
        {
            Console.WriteLine("Not found in this dictionary!");
        }
    }

    static void AddToDict(Dictionary<string, string> dict)
    {
        dict[".NET"] = "platform for applications from Microsoft";
        dict["CLR"] = "managed execution environment for .NET";
        dict["namespace".ToUpper()] = "hierarchical organization of classes";
    }
}

