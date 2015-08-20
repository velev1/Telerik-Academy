/*
Problem 9. Delete odd lines

Write a program that deletes from given text file all odd lines.
The result should be in the same file.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Приемам, че редовере започват от 1, а не от 0

class DeleteOddLines
{
   
    const string textPath = "..\\..\\text.txt";
    
    static void Main()
    {
        StreamReader reader = new StreamReader(textPath);

        List<string> newText = new List<string>();

        using(reader)
        {
            string currLine = reader.ReadLine();
            int line = 1;

            do
            {
                currLine = reader.ReadLine();
                if (!(line % 2 == 1))
                {
                    newText.Add(currLine);
                }
                ++line;
            } while (currLine != null);
        }

        using (var resultText = new StreamWriter(textPath))
        {
            foreach (var line in newText)
            {
                resultText.WriteLine(line);
            }
        }
     

    }
}

