//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	result
//3, 2, 3, 4, 2, 2, 4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter integer elements of the array in one lane separated by ',' (each element can contain more than one symbol):");
        Console.WriteLine();
        string input = Console.ReadLine();
        Console.WriteLine();

        // Преписан парс :)
        //int[] inputToArray = input.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        //        .Select(x => int.Parse(x))
        //        .ToArray();

        string[] arrayInput = input.Split(',');
        int[] inputToArray = new int[arrayInput.Length];

        for (int i = 0; i < inputToArray.Length; i++)
        {
            inputToArray[i] = int.Parse(arrayInput[i]);
        }

        List<int> tempMaxSecElements = new List<int>();
        List<int> maxSecElements = new List<int>();

        for (int i = 0; i < inputToArray.Length; i++)
        {
            if (((i < inputToArray.Length - 1) && ((inputToArray[i] < inputToArray[i + 1] ))))
            {
                tempMaxSecElements.Add(i);
            }
            else if (((i > 0) && ((inputToArray[i] > inputToArray[i - 1] ))))
            {
                tempMaxSecElements.Add(i);
            }

            if ((i < inputToArray.Length - 1) && (inputToArray[i]  >= inputToArray[i + 1] ))
            {
                if (tempMaxSecElements.Count > maxSecElements.Count)
                {
                    maxSecElements = tempMaxSecElements.ToList();
                    tempMaxSecElements.Clear();
                }
                else
                {
                    tempMaxSecElements.Clear();
                }
            }
        }

        if (tempMaxSecElements.Count > maxSecElements.Count)
        {
            maxSecElements = tempMaxSecElements.ToList();
            tempMaxSecElements.Clear();
        }

        Console.WriteLine("The maximal increasing sequence is");
        for (int i = 0; i < maxSecElements.Count; i++)
        {
            if (i == maxSecElements.Count - 1)
            {
                Console.Write("{0} - Total {1} elements", inputToArray[maxSecElements[i]], maxSecElements.Count);
            }
            else
            {
                Console.Write("{0}, ", inputToArray[maxSecElements[i]]);
            }
        }

        Console.WriteLine();
        Console.WriteLine();
    }
}

