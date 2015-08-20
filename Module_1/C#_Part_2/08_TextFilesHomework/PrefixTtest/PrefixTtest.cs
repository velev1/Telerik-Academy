//Problem 11. Prefix "test"

//Write a program that deletes from a text file all words that start with the prefix test.
//Words contain only the symbols 0…9, a…z, A…Z, _.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

// в случая "test" е case insensitive, и ако е само "test" не го трие, поне така си мисля, че трябва да е. 
// За да е само за "test" с малки букви, трябва да се изтрие RegexOptions.IgnoreCase
// "test" в края или средата на думата не се трие! - защото няма да е префикс!

class PrefixTtest
{
    static void Main()
    {
        var reader = File.OpenText(@"..\..\text.txt");

        string  text = reader.ReadToEnd();
        reader.Close();
        Console.WriteLine("Text before: \n");
        Console.WriteLine(text);        
        string pattern = @"\btest\w+";

        MatchCollection matches = Regex.Matches(text, pattern, RegexOptions.IgnoreCase);

        foreach (var match in matches)
        {
            text = text.Replace(match.ToString(), "");
        }
        Console.WriteLine("\nText After: \n");
        Console.WriteLine(text.Trim());
    }
}
