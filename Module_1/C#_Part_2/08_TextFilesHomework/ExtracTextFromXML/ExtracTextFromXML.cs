//Problem 10. Extract text from XML

//Write a program that extracts from given XML file all the text without the tags.
//Example:

//<?xml version="1.0"><student><name>Pesho</name><age>21</age><interests count="3"><interest>Games</interest><interest>C#</interest><interest>Java</interest></interests></student>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ExtracTextFromXML
{
    static void Main()
    {
        string text;
        using (var file = File.OpenText("..\\..\\file.txt"))
        {
            text = file.ReadToEnd();
        }

        string extractedTex = ExtracFromXML(text);
        Console.WriteLine(text);
        Console.WriteLine();
        Console.WriteLine(extractedTex);
        Console.WriteLine();
    }

    static string ExtracFromXML(string text)
    {
        string result = text;

        int indexLeftBr = -1;
        int indexRightBr = -1;

        while (true)
        {
            indexLeftBr = result.IndexOf("<");
            indexRightBr = result.IndexOf(">");
            if (indexLeftBr == -1)
            {
                break;
            }
            result = result.Remove(indexLeftBr, indexRightBr - indexLeftBr + 1);
            if (result.IndexOf(">") < result.Length - 1 && 
                (result.IndexOf(">") > 0 && 
                result[(result.IndexOf(">")+ 1)] != '<'))
            {
                result = result.Insert(result.IndexOf("<") , " ");
            }
        }

        ;
        return result.Trim();
    }
}

