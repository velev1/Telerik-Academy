//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.
//Examples:

//score	result
//2	20
//4	400
//9	9000
//-1	invalid score
//10	invalid score


namespace BonusScore
{
    using System;
        
    class BonusScore
    {
        static void Main()
        {
            Console.Write("Insert number (1-9): ");
            int score = int.Parse(Console.ReadLine());

            if ((score <= 3) && (score >= 1))
            {
                score = score * 10;
                Console.WriteLine("Bonus score: {0}", score);
            }

            else if ((score <= 6) && (score >= 4))
            {
                score = score * 100;
                Console.WriteLine("Bonus score: {0}", score);
            }

            else if ((score <= 9) && (score >= 7))
            {
                score = score * 1000;
                Console.WriteLine("Bonus score: {0}", score);
            }

            else 
            {
                Console.WriteLine("Invalid Score!");
            }
        }
    }
}
