//Problem 24. Order words

//Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderWords
{
    class OrderWords
    {
        static void Main()
        {
            //Console.Write("Enter list of words, separated by spaces: ");
            string text = /*Console.ReadLine();*/ "Lorem ipsum dolor sit amet consectetur adipiscing elit Donec porta placerat risus ac sodales urna tempus aliquam Sed ut metus eu lectus congue maximus Duis sed consequat leo Vivamus ante";
            string[] words = text.Split(new[] { " ", ";", ",", "!", "?", ":", "." }, StringSplitOptions.RemoveEmptyEntries);
            //string[] sorted = (string[])words.Clone();
            Array.Sort(words);
            var output = new StringBuilder();

            foreach (var word in words)
            {
                output.Append(word + " ");
            }
            Console.WriteLine("Words: {0}\n", text);
            Console.WriteLine("Sorted: {0}\n", output.ToString().Trim());
        }
    }
}
