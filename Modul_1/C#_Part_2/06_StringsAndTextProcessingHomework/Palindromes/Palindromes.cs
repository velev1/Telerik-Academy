//Problem 20. Palindromes

//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Palindromes
{
    static void Main()
    {
        string text = "!!ABBA was a Swedish pop group formed in Stockholm in 1972. Exe is a common filename extension denoting an executable file. Isabelle LaMal, was an American film actress. ";
        string[] words = text.Split(new[] { " ", ";", ",", ". ", "!", "?", ":", "." }, StringSplitOptions.RemoveEmptyEntries);
        var palindromes = new List<string>();
        IsPalindrome(words, palindromes);
        PrintPalindromes(palindromes);
    }

    static void PrintPalindromes(List<string> palindromes)
    {
        foreach (var palindrome in palindromes)
	    {
            Console.WriteLine(palindrome);
	    }
    }

    static void IsPalindrome(string[] words, List<string> palindromes)
    {
        foreach (var word in words)
	    {
            bool isPalindrome = true;

            for (int i = 0; i < word.Length/2; i++)
            {
                if (word[i].ToString().ToUpper() != word[word.Length - i - 1].ToString().ToUpper())
                {
                    isPalindrome = false;
                }
            }

            if (isPalindrome && word.Length > 1)
            {
                palindromes.Add(word);
            }
	    }
    }
}

