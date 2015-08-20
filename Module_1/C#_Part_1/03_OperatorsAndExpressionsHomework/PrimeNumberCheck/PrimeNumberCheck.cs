//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n = 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Examples:

//n	Prime?
//1	false
//2	true
//3	true
//4	false
//9	false
//97	true
//51	false
//-3	false
//0	false


namespace PrimeNumberCheck
{
    using System;

    class PrimeNumberCheck
    {
        static void Main()
        {            
            Console.Write("Enter integer number (0-100): ");
            int number = int.Parse(Console.ReadLine());
            bool divByPrime = (number % 2.0 != 0) && (number % 3.0 != 0) && (number % 5.0 != 0) && (number % 7.0 != 0);
            bool prime =  (number == 2) || (number == 3) || (number == 5) || (number == 7);
            bool isPrime = (divByPrime || prime) && (number != 1);
            Console.WriteLine(isPrime);
        }
    }
}
