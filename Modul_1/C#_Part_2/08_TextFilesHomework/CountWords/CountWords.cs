/*
Problem 13. Count words

Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
Handle all possible exceptions in your methods.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Тука пак е Ignore Casing работата
class CountWords
{
    static readonly Dictionary<string, int> countWords = new Dictionary<string, int>();
    static void Main()
    {
        try
        {
            const string textPath = "../../test.txt";
            const string wordsPath = "../../words.txt";
            const string resultPath = "../../result.txt";

            GetWords(wordsPath);
            GetWordOccurs(textPath, resultPath);
        }
        catch (DriveNotFoundException driveError)
        {
            PrintErrorMessage(driveError);
        }
        catch (DirectoryNotFoundException directoryError)
        {
            PrintErrorMessage(directoryError);
        }
        catch (EndOfStreamException eose)
        {
            PrintErrorMessage(eose);
        }
        catch (FileNotFoundException fnfe)
        {
            PrintErrorMessage(fnfe);
        }
        catch (FileLoadException fle)
        {
            PrintErrorMessage(fle);
        }
        catch (PathTooLongException ptle)
        {
            PrintErrorMessage(ptle);
        }
        catch (InvalidOperationException ioe)
        {
            PrintErrorMessage(ioe);
        }
    }

    static void PrintErrorMessage(Exception error)
    {
        Console.Error.WriteLine("CALL PESHO!! {0}\n", error.Message);
    }

    static void GetWords(string pathSearchedWords)
    {
        using (StreamReader reader = new StreamReader(pathSearchedWords))
        {
            while (!reader.EndOfStream)
            {
                string[] words = reader.ReadLine().Split(new char[] { ' ', ',', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (!countWords.ContainsKey(word.ToLower()))
                    {
                        countWords.Add(word.ToLower(), 0);
                    }
                }
            }
        }
    }

    static void GetWordOccurs(string pathText, string pathResult)
    {
        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                var allContent = reader.ReadToEnd();

                for (int i = 0; i < countWords.Count; i++)
                {
                    KeyValuePair<string, int> word = countWords.ElementAt(i);
                    int index = allContent.IndexOf(word.Key.ToLower(), StringComparison.OrdinalIgnoreCase);

                    while (index != -1)
                    {
                        countWords[word.Key]++;
                        index = allContent.IndexOf(word.Key.ToLower(), index + 1, StringComparison.OrdinalIgnoreCase);
                    }
                }
            }

            WriteWordOccursToFile(result);
        }
    }

    static void WriteWordOccursToFile(StreamWriter result)
    {
        foreach (KeyValuePair<string, int> word in countWords.OrderByDescending(key => key.Value))
            result.WriteLine(word.Key + " -> " + word.Value + " time(s).");
    }

}

