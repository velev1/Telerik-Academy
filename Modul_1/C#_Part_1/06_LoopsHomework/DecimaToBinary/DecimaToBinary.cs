//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.
//Examples:

//decimal	binary
//0	        0
//3	        11
//43691	    1010101010101011
//236476736	1110000110000101100101000000


namespace DecimaToBinary
{
    using System;

    class DecimaToBinary
    {
        static void Main()
        {
            Console.Write("Enter positive integer number: ");
            long dec = long.Parse(Console.ReadLine());
            long keepDec = dec;
            string bin = "";

            if (dec ==0)
            {
                Console.WriteLine("The binary representation of 0 is: 0");    
            }
            else
            {
                while (dec > 0)
                {
                    long rem = dec % 2;
                    dec = dec / 2;
                    bin = rem + bin;
                }
                Console.WriteLine("The binary representation of {0} is: {1}", keepDec, bin);
            }
            
        }
    }

}





//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Please enter a integer number: ");
//        int number = Int32.Parse(Console.ReadLine());
//        int result;

//        string numberBit = "";

//        while (number >= 1)
//        {
//            result = number / 2;
//            numberBit += (number % 2).ToString();
//            number = result;
//        }

//        string reverseNumberBit = "";

//        for (int i = numberBit.Length - 1; i >= 0; i--)
//        {
//            reverseNumberBit += numberBit[i];
//        }
//        Console.WriteLine("Your number is binary: {0}", reverseNumberBit);
//    }
//}