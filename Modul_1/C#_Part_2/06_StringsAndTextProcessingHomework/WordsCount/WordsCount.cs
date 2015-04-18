//Problem 22. Words count

//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WordsCount
{
    static void Main()
    {
        Console.Write("Enter some text: ");
        string text = Console.ReadLine(); //"Lorem ipsum dolor sit amet, consectetur adipiscing elit. Maecenas a egestas ligula, vestibulum rhoncus nisi. Nullam euismod pretium semper. Nulla ac ultricies ligula. Nullam ut.";
        var lettersAndCount = new SortedDictionary<string, int>();

        foreach (var word in text.Split(new[] { " ", ";", ",", "!", "?", ":", "." }, StringSplitOptions.RemoveEmptyEntries))
        {
            if (!lettersAndCount.ContainsKey(word.ToUpper()))
            {
                lettersAndCount[word.ToUpper()] = 1;
            }
            else if (lettersAndCount.ContainsKey(word.ToUpper()))
            {
                lettersAndCount[word.ToUpper()] += 1;
            }
        }

        Console.WriteLine("\nWords sorted lexicographically:\n");
        foreach (var key in lettersAndCount.Keys)
        {
            Console.WriteLine("{0} -> {1} times", key, lettersAndCount[key]);
        }
        Console.WriteLine();


    }
}

