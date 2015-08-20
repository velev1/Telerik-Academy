/*
Problem 8. Replace whole word

Modify the solution of the previous problem to replace only whole words (not strings).
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// пробвах го и със 200MB текст, работи като пушка :)

class ReplaceWholeWord
{
    static void Main()
    {
        var originalText = File.OpenText("..\\..\\text.txt");
        var edditedText = new StreamWriter("..\\..\\Edditedtext.txt");

        string line;
        while ((line = originalText.ReadLine()) != null)
        {
            line = line.Replace(" start ", " finish ")
                .Replace(" Start ", " Finish ").Replace(" Start,", " Finish,")
                .Replace(" Start!", " Finish!").Replace(" Start?", " Finish?")
                .Replace(" start, ", " finish, ").Replace(" start.", " finish.")
                .Replace(" start! ", " finish! ").Replace(" start? ", " finish? ")
                .Replace(" start; ", " finish; ").Replace(" start: ", " finish: "); // И т.н......

            edditedText.WriteLine(line);
        }

        originalText.Close();
        edditedText.Close();
    }
}
