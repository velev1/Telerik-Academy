//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
//Examples:

//n	Divided by 7 and 5?
//3	false
//0	false
//5	false
//7	false
//35	true
//140	true

namespace DivideBySevenAndFive
{
    using System;

    class DivideBySevenAndFive
    {
        static void Main()
        {
            Console.Write("Enter integer number: ");
            int number = int.Parse(Console.ReadLine());
            bool divideBy5and7 = number % 35 == 0;
            Console.WriteLine("Devided by 7 and 5 at the same time: {0}", divideBy5and7);
        }
    }
}
