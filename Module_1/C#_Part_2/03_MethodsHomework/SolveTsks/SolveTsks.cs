//Problem 13. Solve tasks

//Write a program that can solve these tasks:
//Reverses the digits of a number
//Calculates the average of a sequence of integers
//Solves a linear equation a * x + b = 0
//Create appropriate methods.
//Provide a simple text-based menu for the user to choose which task to solve.
//Validate the input data:
//The decimal number should be non-negative
//The sequence should not be empty
//a should not be equal to 0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SolveTsks
{
    static void Main()
    {
        Console.WriteLine("Choose task to solve:\n");
        Console.WriteLine("Inser 1 if you want to reverse difitst of number;");
        Console.WriteLine("Inser 2 if you want to finde the averege of sequence;");
        Console.WriteLine("Inser 3 if you want to Solves a linear equation;");
        Console.Write("\nEnter your choise: ");
        string choise = Console.ReadLine();
        if (choise != "1" && choise != "2" && choise != "3")
        {
            Console.WriteLine("Invalid input!");
            while (true)
            {
                Console.Write("\nEnter your choise: ");
                choise = Console.ReadLine();
                if (choise == "1" || choise == "2" || choise == "3")
                {
                    break;
                }
            }
        }

        switch (choise)
        {
            case "1": ReverseDigits(); break;
            case "2": Averege(); break;
            case "3": LinearEquation(); break;
            default:
                break;
        }
    }

    static void Continue()
    {
        Console.WriteLine("\nDo you want to solve another task? (Y/N): ");
        string answer = Console.ReadLine();
        if (answer != "N" && answer != "Y" )
        {
            while (true)
            {
                Console.Write("Enter 'Y' or 'N': ");
                answer = Console.ReadLine();
                if (answer == "N" || answer == "Y")
                {
                    break;
                }
            }
        }
        if (answer == "Y")
        {
            Main();
        }
        else
        {
            Console.WriteLine("\nGood bye!\n");
            return;
        }
    }

    static void LinearEquation()
    {
        Console.WriteLine("\nYou have linear equation a * x + b = 0 : \n");
        Console.Write("Enter element a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter element b: ");
        int b = int.Parse(Console.ReadLine());
        if (a == 0)
        {
            Console.WriteLine("Element 'a' should not be 0 (zero): ");
            while (true)
            {
                Console.Write("Try again? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer == "Y" || answer == "N")
                {
                    if (answer == "Y")
                    {
                        LinearEquation();
                    }
                    else if (answer == "N")
                    {
                        Continue();
                    }
                }
            }
        }

        Console.WriteLine("\nYour equation is {0}x + {1} = 0", a, b);

        decimal x = -b / a;

        Console.WriteLine("\nX = {0}", x);

        Continue();
    }

    static void ReverseDigits()
    {
        Console.WriteLine("\nEnter positive integer number: ");
        int number = int.Parse(Console.ReadLine());
        if (number < 0)
        {
            Console.WriteLine("The number shound not be negative!");
            while (true)
            {
                Console.Write("Try again? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer == "Y" || answer == "N")
                {
                    if (answer == "Y")
                    {
                        ReverseDigits();
                    }
                    else if (answer == "N")
                    {
                        Main();
                    }
                }
            }
        }

        int left = number;
        int reversed = 0;
        while (left > 0)
        {
            int rest = left % 10;
            reversed = reversed * 10 + rest;
            left = left / 10;
        }

        Console.WriteLine("\nReversed: {0}\n", reversed);

        Continue();
    }

    static void Averege()
    {
        Console.WriteLine("\nEnter integer elements of the sequence in one lane separated by ','");
        string input = Console.ReadLine();
        if (input.Length == 0)
        {
            Console.WriteLine("\nThe sequence should NOT be empty!!\n");
            while (true)
            {
                Console.Write("Try again? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer == "Y" || answer == "N")
                {
                    if (answer == "Y")
                    {
                        Averege();
                    }
                    else if (answer == "N")
                    {
                        Main();
                    }
                }
            }
        }

        string[] inputToArray = input.Replace(" ", string.Empty).Split(',');
        decimal[] sequence = new decimal[inputToArray.Length];
        for (int i = 0; i < inputToArray.Length; i++)
        {
            sequence[i] = int.Parse(inputToArray[i]);
        }

        decimal averege = sequence.Average();

        Console.WriteLine("\nAverege: {0}", averege);
        
        Continue();
    }
}

