using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class NFactorial
{
    static void Main()
    {
        List<int> currN = new List<int>();
        currN.Add(1);
        int n = 100;
       
        for (int i = 1; i <=n; i++)
        {
            currN = MultiplyNumber(currN, i);
            WriteToFile(currN, n);
            PrintArrayNumber(currN, n);
        }
    }

    static void WriteToFile(List<int> number, int n)
    {
        StreamWriter nFactorials = new StreamWriter(@"..\..\nFactorials.txt", true);

        using (nFactorials)
        {
            int factorial = n;
            nFactorials.WriteLine("n! from {0} is:", factorial);
            for (int i = number.Count - 1; i >= 0; i--)
            {
                nFactorials.Write(number[i]);
            }
            nFactorials.WriteLine("\n");
        }
    }

    static List<int> MultiplyNumber(List<int> number, int multiplier)
    {
        List<int> result = new List<int>();

        int reminder = 0;

        for (int i = 0; i < number.Count; i++)
        {
            int digit = (int)((number[i] * multiplier) + reminder);
            reminder = (int)(digit / 10);
            digit = (int)(digit % 10);
            result.Add(digit);
        }
        if (reminder > 9 && reminder > 0)
        {
            while (reminder > 9)
            {
                result.Add(reminder % 10);
                reminder /= 10;
            }
            result.Add(reminder);
        }
        else
        {
            if (reminder != 0)
            {
                result.Add(reminder);
            }
        }
        return result;
    }

    static void PrintArrayNumber(List<int> number, int n)
    {
        int factorial = n;
        Console.WriteLine("n! from {0} is:", factorial);
        for (int i = number.Count - 1; i >= 0; i--)
        {
            Console.Write(number[i]);
        }
        Console.WriteLine("\n");
    }
}

