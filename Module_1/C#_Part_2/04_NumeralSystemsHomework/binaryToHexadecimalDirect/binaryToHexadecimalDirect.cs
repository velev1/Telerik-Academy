using System;
using System.Collections.Generic;

class BinaryToHexadecimalDirect
{
    static void Main()
    {
        //Пробвам речника, ако някой не знае ето това чудо - тук: http://telerikacademy.com/Courses/LectureResources/Video/5910/%D0%92%D0%B8%D0%B4%D0%B5%D0%BE-16-%D1%84%D0%B5%D0%B2%D1%80%D1%83%D0%B0%D1%80%D0%B8-2015-%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE

        var binaryDict = new Dictionary<string, string>();
        binaryDict["0000"] = "0";
        binaryDict["0001"] = "1";
        binaryDict["0010"] = "2";
        binaryDict["0011"] = "3";
        binaryDict["0100"] = "4";
        binaryDict["0101"] = "5";
        binaryDict["0110"] = "6";
        binaryDict["0111"] = "7";
        binaryDict["1000"] = "8";
        binaryDict["1001"] = "9";
        binaryDict["1010"] = "A";
        binaryDict["1011"] = "B";
        binaryDict["1100"] = "C";
        binaryDict["1101"] = "D";
        binaryDict["1110"] = "E";
        binaryDict["1111"] = "F";

        Console.Write("Enter binary number: ");
        string bin = Console.ReadLine();

        int missingZeroes = 4 - bin.Length % 4;

        if (missingZeroes != 0)
        {
            bin = new string('0', missingZeroes) + bin;
        }

        Console.WriteLine("\nThe hexadecimal representation is: \n");

        string hexDidit = string.Empty;
        string hex = string.Empty;
        for (int i = 0; i < bin.Length; i++)
        {
            hexDidit = hexDidit + bin[i];
            if ((i + 1) % 4 == 0 && i != 0)
            {
                hex =  hex + binaryDict[hexDidit];
                hexDidit = string.Empty;
            }
        }

        Console.WriteLine(hex);
        Console.WriteLine("\n");
    }             
}

