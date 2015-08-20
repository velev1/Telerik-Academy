//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
//Examples:

//n	randomized numbers 1…n
//3	2 1 3
//10	3 4 8 2 6 7 9 1 10 5
//Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.

namespace RandomizeNumbers
{
    using System;

    class RandomizeNumbers
    {
        static void Main()
        {

            //Оставям задачата, за да решавам изпитните :), ама не ми се трие от солюшъна, защото имам намерение да я направя, но не знам кога :)
            int n;            
            bool nParseOK = true;          

            do
            {
                Console.Write("Enter number n: ");
                string valueN = Console.ReadLine();
                nParseOK = int.TryParse(valueN, out n);
            } 
            while (nParseOK == false);
            Console.WriteLine();


        }
    }
}
