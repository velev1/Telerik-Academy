//Problem 2. Enter numbers

//Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
//If an invalid number or non-number text is entered, the method should throw an exception.
//Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EnterNumbers
{
    static void Main()
    {
        List<int> numbers = new List<int>();

        Console.Write("Enter number a1 [1 < a1 < 100]: ");
        int a1 = ReadNumber(1, 1, 100);
        numbers.Add(a1);
        for (int i = 2; i <= 10; i++)
        {
            Console.Write("Enter number a{0} [1 < a1 < ..  … < a10 < 100]: ", i);
                int previous = 1;
                int temp = 1;

                if (i == 2)
                {
                    previous = a1;
                }
                else
                {
                    previous = temp;
                }
                temp = ReadNumber(1, previous, 100);
             numbers.Add(temp);
        }
    }

    static int ReadNumber(int start, int current, int end)
    {
        try
        {
            int number = int.Parse(Console.ReadLine());
            if (!(number < end && number > start) || (number <= current))
            {
                ArgumentOutOfRangeException invaid = new ArgumentOutOfRangeException();
                Console.WriteLine("\nNumber out of range");
                throw (invaid);
            }
            return number;
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input format");
            throw;
        }
    }
}


