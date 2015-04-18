//Problem 5. Hexadecimal to binary

//Write a program to convert hexadecimal numbers to binary numbers (directly).

using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //Пробвам речника, ако някой не знае ето това чудо - тук: http://telerikacademy.com/Courses/LectureResources/Video/5910/%D0%92%D0%B8%D0%B4%D0%B5%D0%BE-16-%D1%84%D0%B5%D0%B2%D1%80%D1%83%D0%B0%D1%80%D0%B8-2015-%D0%98%D0%B2%D0%B0%D0%B9%D0%BB%D0%BE

        var hexadecimal = new Dictionary<string, string>();
        hexadecimal["0"] = "0000";
        hexadecimal["1"] = "0001";
        hexadecimal["2"] = "0010";
        hexadecimal["3"] = "0011";
        hexadecimal["4"] = "0100";
        hexadecimal["5"] = "0101";
        hexadecimal["6"] = "0110";
        hexadecimal["7"] = "0111";
        hexadecimal["8"] = "1000";
        hexadecimal["9"] = "1001";
        hexadecimal["A"] = "1010";
        hexadecimal["B"] = "1011";
        hexadecimal["C"] = "1100";
        hexadecimal["D"] = "1101";
        hexadecimal["E"] = "1110";
        hexadecimal["F"] = "1111";

        Console.Write("Enter hexadecimal number: ");
        string hex = Console.ReadLine();

        Console.WriteLine("\nThe binari representation is: \n");
        foreach (char digit in hex)
        {
            string hexDig = digit.ToString().ToUpper();
            Console.Write(hexadecimal[hexDig]);            
        }

        Console.WriteLine("\n");
    }
}

