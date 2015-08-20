//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.


using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        Console.Write("Enter binary number: ");
        string input = Console.ReadLine();
        int length = input.Length;
        long inDecimal = 0;
        long result = 0;

        for (int i = 0, n = length - 1; i < length; i++, n--)
        {
            if ((int)Char.GetNumericValue(input[i]) == 1)
            {
                inDecimal = (long)Math.Pow(2, n);
                result = result + inDecimal;
            }
            else
            {
                continue;
            }
        }

        Console.WriteLine();
        Console.WriteLine("\nThe decimal representation of {0} is \"{1}\"\n", input, result);
        Console.WriteLine();
    }
}







//using System;

//class BinaryToDecimalNumber
//{
//    static void Main()
//    {
//        Console.Write("Please enter a binary integer number: ");
//        string binaryNumber = Console.ReadLine();

//        string[] numbers = new string[binaryNumber.Length];

//        int position = 0;

//        foreach (char element in binaryNumber)
//        {
//            numbers[position] = element.ToString();
//            position++;
//        }

//        long[] reverseNumbers = new long[numbers.Length];

//        int positionReverse = 0;
//        for (int index = numbers.Length - 1; index >= 0; index--)
//        {
//            reverseNumbers[positionReverse] = Int32.Parse((numbers[index]));
//            positionReverse++;
//        }

//        long numberInDecimal = 0;

//        Console.Write("Your number in decimal: ");

//        for (int index = 0; index < reverseNumbers.Length; index++)
//        {
//            numberInDecimal += (long)Math.Pow(2, index) * reverseNumbers[index];
//        }

//        Console.WriteLine(numberInDecimal);
//    }
//}