using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class NumberAsArray
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            string firstNumber = Console.ReadLine();
            Console.Write("Enter second number: ");
            string secondNumber = Console.ReadLine();

            byte[] firstAsArray = (byte[])NumberToArray(firstNumber).Clone();
            byte[] secondAsArray = (byte[])NumberToArray(secondNumber).Clone();

            List<byte>  result = new List<byte>();

            result = (AddingTwoNumbers(firstAsArray, secondAsArray)).ToList();
            PrintArrayNumber(result);
        }

        static List<byte> AddingTwoNumbers(byte[] first, byte[] second)
        {
            List<byte> result = new List<byte>(Math.Max(first.Length, second.Length));

            byte remainder = 0;

            for (int i = 0; i < result.Capacity; i++)
            {
                byte a;
                byte b;
                if (i >= first.Length)
                {
                    a = 0;
                }
                else
                {
                    a = first[i];
                }

                if (i >= second.Length)
                {
                    b = 0;
                }
                else
                {
                    b = second[i];
                }

                byte digit = (byte)(remainder + a + b);
                remainder = (byte)(digit / 10);
                digit = (byte)(digit % 10);
                result.Add(digit);
            }

            if (remainder > 0)
            {
                result.Add(remainder);
            }

            return result;
        }

        static byte[] NumberToArray(string number)
        {
            byte[] numAsArray = new byte[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                numAsArray[i] = (byte)(number[number.Length - i - 1] - '0');
            }

            return numAsArray;
        }

        static void PrintArrayNumber(List<byte> number)
        {
            Console.WriteLine("\nThe result is:\n");
            for (int i = number.Capacity - 1; i >= 0; i--)
            {
                Console.Write(number[i]);
            }
            Console.WriteLine("\n\n");
        }


    }
}
