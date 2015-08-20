//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CorrectBrackets
{
    static void Main()
    {
        Console.Write("Enter some expression: ");
        char[] expression = Console.ReadLine().ToCharArray();
        //Console.WriteLine(new string(expression));
        int leftBrk = 0;
        int rightBrk = 0;
        int currLB = 0;
        int currRB = 0;
        int currPos = 0;

        bool correct = true;

        foreach (var symbol in expression)
        {
            if (symbol == '(' )
            {
                ++leftBrk;
            }
            if (symbol == ')' )
            {
                ++rightBrk;
            }
            if (rightBrk > leftBrk)
            {
                correct = false;
            }
            if (expression[currPos] == '(' && expression[currPos + 1] == ')')
            {
                correct = false;
            }

            currPos++;
        }

        if (leftBrk != rightBrk)
        {
            correct = false;
        }

        Console.WriteLine("Correct brackets: {0}", correct);
    }
}

