//Problem 21. Letters count

//Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

// Приемам условието, като case insensitive, ако трябва да е case ensitive трябва да се изтрие на всякъде .ToUpper().

using System;
using System.Collections.Generic;

class LettersCount
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine(); // "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas a egestas ligula, vestibulum rhoncus nisi. Nullam euismod pretium semper. Nulla ac ultricies ligula. Nullam ut.";
        var lettersAndCount = new SortedDictionary<string, int>();

        foreach (var symbol in text)
        {
            if (char.IsLetter(symbol) && !lettersAndCount.ContainsKey(symbol.ToString().ToUpper()))
            {
                lettersAndCount[symbol.ToString().ToUpper()] = 1;
            }
            else if (char.IsLetter(symbol) && lettersAndCount.ContainsKey(symbol.ToString().ToUpper()))
            {
                lettersAndCount[symbol.ToString().ToUpper()] += 1;
            }
        }

        Console.WriteLine("\nLetters sorted alphabetically:\n");
        foreach (var key in lettersAndCount.Keys)
        {
            Console.WriteLine("{0} -> {1} times", key, lettersAndCount[key]);
        }
        Console.WriteLine();
    }
}
