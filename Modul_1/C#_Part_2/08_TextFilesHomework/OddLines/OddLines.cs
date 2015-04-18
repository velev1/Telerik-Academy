//Problem 1. Odd lines

//Write a program that reads a text file and prints on the console its odd line

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Приемам, че редовере започват от 1, а не от 0

class OddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\test.txt");

        using (reader)
        {
            string currLine = reader.ReadLine();
            int line = 1;
            do
            {
                currLine = reader.ReadLine();
                if (line % 2 == 1)
                {
                    Console.WriteLine(currLine);
                }
                ++line;
            } while (currLine != null);
        }
    }
}

