//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	two
//1024	four
//12309	nine

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(LastDigitAsWord(input)); 
        }

        static string LastDigitAsWord(int number)
        {
            number = number % 10;

            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "not a number";
                
            }

            



        }

    }
}
