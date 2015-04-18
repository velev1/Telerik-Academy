//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

class CompareTextFiles
{
    static void Main()
    {
        var textOne = new StreamReader("..\\..\\text1.txt");
        var textTwo = new StreamReader("..\\..\\text2.txt");

        int equalLines = 0;
        int notEqualLines = 0;

        while (true)
        {
            string first = textOne.ReadLine();
            string second = textTwo.ReadLine();

            if (first == null)
            {
                break;
            }

            if (first == second)
            {
                equalLines++;
            }
            else
            {
                notEqualLines++;
            }
        }

        textOne.Close();
        textTwo.Close();
        Console.WriteLine("Equal lines -> {0}", equalLines);
        Console.WriteLine("NoteEqual lines -> {0}", notEqualLines);
    }
}

