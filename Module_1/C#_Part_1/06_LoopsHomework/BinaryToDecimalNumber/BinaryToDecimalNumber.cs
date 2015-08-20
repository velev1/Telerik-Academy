//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.
//Examples:

//binary	                    decimal
//0	                            0
//11    	                    3
//1010101010101011	            43691
//1110000110000101100101000000	236476736




namespace BinaryToDecimalNumber
{
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

            for (int i = 0 , n = length -1; i < length; i++, n--)
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
            Console.WriteLine("The decimal representation of {0} is \"{1}\"", input, result);
            Console.WriteLine();
        }
    }
}






//using System;
 
//class ConvertBinaryToDecimal
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