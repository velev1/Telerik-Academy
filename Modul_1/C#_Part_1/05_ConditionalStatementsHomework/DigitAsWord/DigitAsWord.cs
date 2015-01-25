//Problem 8. Digit as Word

//Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.
//Examples:

//d	result
//2	two
//1	one
//0	zero
//5	five
//-0.1	not a digit
//hi	not a digit
//9	nine
//10	not a digit


namespace DigitAsWord
{
    using System;

    class DigitAsWord
    {
        static void Main()
        {
            Console.Write("Enter digit (0-9): ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "0": Console.WriteLine(" {0} -> zero", input); break;
                case "1": Console.WriteLine(" {0} -> one", input); break;
                case "2": Console.WriteLine(" {0} -> two", input); break;
                case "3": Console.WriteLine(" {0} -> three", input); break;
                case "4": Console.WriteLine(" {0} -> four", input); break;
                case "5": Console.WriteLine(" {0} -> five", input); break;
                case "6": Console.WriteLine(" {0} -> six", input); break;
                case "7": Console.WriteLine(" {0} -> seven", input); break;
                case "8": Console.WriteLine(" {0} -> eight", input); break;
                case "9": Console.WriteLine(" {0} -> nine", input); break;

                default: Console.WriteLine("not a digit"); break;
            }
        }
    }
}
