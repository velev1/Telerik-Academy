/*
Problem 7. Replace sub-string

Write a program that replaces all occurrences of the sub-string start with the sub-string finish in a text file.
Ensure it will work with large files (e.g. 100 MB).
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// пробвах го и със 200MB текст, работи като пушка :)

class ReplaceSubString
{
    static void Main()
    {
        var originalText = File.OpenText("..\\..\\text.txt");
        var edditedText = new StreamWriter("..\\..\\Edditedtext.txt");

        string line;
        while ((line=originalText.ReadLine()) != null )
        {
            line = line.Replace("start", "finish");
            edditedText.WriteLine(line);
        }

        originalText.Close();
        edditedText.Close();
    }
}
