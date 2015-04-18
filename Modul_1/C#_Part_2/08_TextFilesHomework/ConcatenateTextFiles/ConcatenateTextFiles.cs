//Problem 2. Concatenate text files

//Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class ConcatenateTextFiles
{
    static void Main()
    {
        StreamReader textOne = new StreamReader("..\\..\\text1.txt");
        StreamReader textTwo = new StreamReader("..\\..\\text2.txt");
        StreamWriter resultText = new StreamWriter("..\\..\\resultText.txt");
        resultText.WriteLine(textOne.ReadToEnd() + " " + textTwo.ReadToEnd());
        textOne.Close();
        textTwo.Close();
        resultText.Close();
    }
}

