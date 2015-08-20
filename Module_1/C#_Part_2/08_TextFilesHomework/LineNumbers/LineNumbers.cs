//Problem 3. Line numbers

//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.IO;


class LineNumbers
{
    static void Main()
    {
        StreamReader reader = new StreamReader("..\\..\\test.txt");
        StreamWriter writeResult = new StreamWriter("..\\..\\result.txt");
           
        int line = 1;

        while (true)
        {
            string currLine  = reader.ReadLine();
            if (currLine == null) break;
            writeResult.WriteLine(line.ToString() + " - " + currLine);
            line++;
        }

        reader.Close();
        writeResult.Close();
    }
}
