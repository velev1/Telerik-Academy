//Problem 7. One system to any other

//Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤ 16).

using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
// Не остана време да правя и проверки за верен инпут, така че има бъгове - ако примерно искаш да преобразуваш нещо от дуична и зададеде 2002445 - дава някакви резултати :)
class OneSystemToAnyOther
{
    static Dictionary<char, int> numbersOther = new Dictionary<char, int>();
    static Dictionary<byte, string> numbersDecimal = new Dictionary<byte, string>();

    static void Main()
    {
        FillDictionary();

        Console.Write("Enter numerical system to convert from: ");
        int sysFrom = int.Parse(Console.ReadLine());
        Console.Write("\nEnter number you want to convert from: ");
        string numberFrom = Console.ReadLine().ToUpper();
        Console.Write("\nEnter numerical system to convert to: ");
        int sysTo = int.Parse(Console.ReadLine());
        string toDec = ToDecimal(numberFrom, sysFrom);
        string toNSys = FromDecimal(toDec, sysTo); ;
        Console.WriteLine("\nThe number {0} ({1}) \n\nis represented as \n\n{2} ({3})\n", numberFrom, sysFrom, toNSys, sysTo);
    }

    static void FillDictionary()
    {
        numbersOther['0'] = 0;
        numbersOther['1'] = 1;
        numbersOther['2'] = 2;
        numbersOther['3'] = 3;
        numbersOther['4'] = 4;
        numbersOther['5'] = 5;
        numbersOther['6'] = 6;
        numbersOther['7'] = 7;
        numbersOther['8'] = 8;
        numbersOther['9'] = 9;
        numbersOther['A'] = 10;
        numbersOther['B'] = 11;
        numbersOther['C'] = 12;
        numbersOther['D'] = 13;
        numbersOther['E'] = 14;
        numbersOther['F'] = 15;

        numbersDecimal[0] = "0";
        numbersDecimal[1] = "1";
        numbersDecimal[2] = "2";
        numbersDecimal[3] = "3";
        numbersDecimal[4] = "4";
        numbersDecimal[5] = "5";
        numbersDecimal[6] = "6";
        numbersDecimal[7] = "7";
        numbersDecimal[8] = "8";
        numbersDecimal[9] = "9";
        numbersDecimal[10] = "A";
        numbersDecimal[11] = "B";
        numbersDecimal[12] = "C";
        numbersDecimal[13] = "D";
        numbersDecimal[14] = "E";
        numbersDecimal[15] = "F";
    }

    static string FromDecimal(string numDec, int sysTo)
    {
        StringBuilder result = new StringBuilder();
        BigInteger decimalNumber = BigInteger.Parse(numDec);
        while (decimalNumber > 0)
        {
            byte reminder = (byte)(decimalNumber % sysTo);
            decimalNumber = decimalNumber / sysTo;
            string rem = numbersDecimal[reminder];
            result.Insert(0, rem);
        }
        if (result.Length == 0)
        {
            result.Append("0");
        }
       
        return result.ToString();        
    }

    static string ToDecimal(string number, int sysFrom)
    {
        BigInteger inDec = 0;
        BigInteger resultDec = 0;

        for (int i = 0; i < number.Length; i++)
        {
            inDec = numbersOther[number[i]] * (BigInteger)Math.Pow(sysFrom, number.Length - i - 1);
            resultDec = resultDec + inDec;
        }
        string result = Convert.ToString(resultDec);
        return result;
    }
}

