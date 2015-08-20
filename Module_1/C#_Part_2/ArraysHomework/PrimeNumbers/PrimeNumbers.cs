// Problem 15. Prime numbers

// Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.

using System;
using System.Collections.Generic;
using System.IO;

/* Пробвах се да го направа с методи, а също така тествах и записването на резултата във текстови файл. 
 (след стартирането, трябва да се появи файл primes.txt в директорията на домашното във папка PrimeNumbers - някъде около .cs файла) 
 Проблема беше, че зациклих на това домашно и прегледах малко от материал напред, с цел да си улесня живота :) 
 Извинявам се ако не се разбира, но честно казано и аз не съм сигурен, че си го разбирам към момента, но работи и е авторско решение, 
 като е ползван единствено алгоритъма от Wikipedia :) */

 static class PrimeNumbers
{
    private static void Main()
    {
        Console.Write("Enter maximum range to finde prime numbrs (max 10 000 000): ");
        int maxRange = int.Parse(Console.ReadLine());
        Console.Write("Enter first number of the range (min 2): ");
        int firstNumber = int.Parse(Console.ReadLine());

        if (firstNumber < 2)
        {
            Console.WriteLine("Invalid starting number!");
            return;
        }

        if (maxRange > 10000000)
        {
            Console.WriteLine("You are asking too much :)");
            return;
        }

        List<bool> numberIndexes = PrimeFinder(maxRange);

        List<int> primeNumbersArray = ListOfPrimes(maxRange, firstNumber, numberIndexes);

        PrimesWriteToFile(maxRange, firstNumber, primeNumbersArray);

        PrimesPrintToConsole(maxRange, firstNumber, primeNumbersArray);
    }

    private static void PrimesPrintToConsole(int maxRange, int firstNumber, List<int> primeNumbersArray)
    {
        Console.WriteLine("There are {0} prime numbers between {1} and {2}!", primeNumbersArray.Count, firstNumber, maxRange);
        Console.WriteLine("They are as follows: ");
        
        for (int i = 0; i < primeNumbersArray.Count; i++)
        {
            if (i % 10 == 0)
            {
                Console.WriteLine();
            }

            Console.Write("{0,7} ", primeNumbersArray[i]);
        }

        Console.WriteLine();
    }

    private static void PrimesWriteToFile(int maxRange, int firstNumber, List<int> primeNumbersArray)
    {
        StreamWriter primes = new StreamWriter(@"..\..\primes.txt");

        using (primes)
        {
            primes.WriteLine("There are {0} prime numbers between {1} and {2}!", primeNumbersArray.Count, firstNumber, maxRange);
            primes.WriteLine("They are as follows: ");
            
            for (int i = 0; i < primeNumbersArray.Count; i++)
            {
                if (i % 10 == 0)
                {
                    primes.WriteLine();
                }

                primes.Write("{0,7} ", primeNumbersArray[i]);
            }

            primes.WriteLine();
        }
    }

    private static List<int> ListOfPrimes(int maxRange, int firstNumber, List<bool> numberIndexes)
    {
        List<int> primeNumbersArray = new List<int>();

        for (int i = firstNumber; i <= maxRange; i++)
        {
            if (numberIndexes[i] == true)
            {
                primeNumbersArray.Add(i);
            }
        }

        return primeNumbersArray;
    }

    private static List<bool> PrimeFinder(int maxRange)
    {
        List<bool> numberIndexes = new List<bool>();

        for (int i = 0; i <= maxRange; i++)
        {
            numberIndexes.Add(true);
        }

        for (int i = 2; i <= Math.Sqrt(maxRange); i++)
        {
            if (numberIndexes[i] == true)
            {
                for (int j = i * i, h = 1; j <= maxRange; j = (i * i) + (i * h), h++)
                {
                    numberIndexes[j] = false;
                }
            }
        }

        return numberIndexes;
    }
}