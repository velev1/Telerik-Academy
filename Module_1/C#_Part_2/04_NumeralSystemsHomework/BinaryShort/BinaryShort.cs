//Problem 8. Binary short

//Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

using System;
using System.Text;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            Console.Write("Enter integer number {0} <= n <= {1}: ", short.MinValue, short.MaxValue);
            short number = short.Parse(Console.ReadLine());
            Console.WriteLine("\nThe binari represrntation of {0} is:\n\n{1}\n", number, ShortToBynary(number));
        }

        static string ShortToBynary(short number)
        {
            StringBuilder shortInBin = new StringBuilder(16);

            if (number > 0)
            {
                while (number > 0)
                {
                    byte reminder = (byte)(number % 2);
                    number /= 2;
                    shortInBin.Insert(0, reminder);
                }
                if (shortInBin.Length < 16)
                {
                    shortInBin.Insert(0, "0", 16 - shortInBin.Length);
                }
            }
            else if (number < 0)
            {
                number = (short)((short.MaxValue + 1) + number );
                while (number > 0)
                {
                    byte reminder = (byte)(number % 2);
                    number /= 2;
                    shortInBin.Insert(0, reminder);
                }
                if (shortInBin.Length < 16)
                {
                    shortInBin.Insert(0, '1');
                    shortInBin.Insert(1, "0", 16 - shortInBin.Length);
                }
                
            }
            else
            {
                shortInBin.Insert(0, "0", 16 - shortInBin.Length);
            }

            return shortInBin.ToString();
        }
    }
}

