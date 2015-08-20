//Problem 5. Parse tags

//You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
//The tags cannot be nested.
//Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

//The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{

    static void Main()
    {
        List<int> startIndex= new List<int>();
        List<int> endIndex = new List<int>();

        string text = ("We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.");
        string start = "<upcase>";
        string end = "</upcase>";

        FindeIndex(text, start, startIndex);
        FindeIndex(text, end, endIndex);
        string ChangedText = ChaneToUpper(text, startIndex, endIndex, start, end);
        Console.WriteLine(ChangedText);
        Console.WriteLine();
    }

    static string ChaneToUpper(string text, List<int> startIndex, List<int> endIndex, string changerStart, string changerEnd)
    {
        if (endIndex.Count != startIndex.Count)
        {
            throw new ArgumentException("Invalid changers!\n\n");
        }

        StringBuilder result = new StringBuilder();

        for (int i = 0; i < startIndex.Count; i++)
        {
            if (i == 0)
            {
                result.Append(text.Substring(0, startIndex[i]));
                result.Append(text.Substring(startIndex[i] + changerStart.Length, endIndex[i] - (startIndex[i] + changerStart.Length)).ToUpper()); //
            }
            else
            {
                result.Append(text.Substring(endIndex[i - 1] + changerEnd.Length, startIndex[i] - (endIndex[i-1] + changerEnd.Length)));
                result.Append(text.Substring(startIndex[i] + changerStart.Length, endIndex[i] - (startIndex[i] + changerStart.Length)).ToUpper()); //
            }
            if (i == startIndex.Count - 1)
            {
                result.Append(text.Substring(endIndex[i] + changerEnd.Length, text.Length - (endIndex[i] + changerEnd.Length)));
            }
        }

        return result.ToString();
    }

    static void FindeIndex(string text, string subStr, List<int> changer)
    {
        int index = -1;

        while (true)
        {
            index = text.IndexOf(subStr, index + 1);
            if (index == -1)
            {
                break;
            }

            changer.Add(index);
        }
    }
}

