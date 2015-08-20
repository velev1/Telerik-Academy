//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            // creating char array with alphabet
            char[] alpahbetArray = new char[52];

            int toLower = 26;

            for (int i = 0; i < alpahbetArray.Length; i++)
            {
                if (i >= toLower)
                {
                    alpahbetArray[i] = (char)('a' + i - toLower);
                }
                else
                {
                    alpahbetArray[i] = (char)('A' + i);
                }
            }
            // check the alphabet array
            //for (int i = 0; i < alpahbetArray.Length; i++)
            //{
            //    Console.WriteLine(alpahbetArray[i]);
            //}

            //input
            Console.WriteLine("Wrire some word: ");
            string word = Console.ReadLine();

            //print word's characters indexes in the arry
            Console.WriteLine("The indexes in the array of each elemet of the word are: ");

            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < alpahbetArray.Length; j++)
                {
                    if (word[i] == alpahbetArray[j])
                    {
                        Console.Write("{0} ", j);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
