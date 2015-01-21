//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.
//Examples:

//n	Third digit 7?
//5	false
//701	true
//9703	true
//877	false
//777877	false
//9999799	true


namespace IsThirdDigitSeven
{
    using System;

    class IsThirdDigitSeven
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());
            bool isSeven = (number / 100) % 10 == 7;
            Console.WriteLine("Does your number third digit from right to left is 7: {0} ", isSeven);

        }
    }
}
