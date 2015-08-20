//Problem 12. Remove words

//Write a program that removes from a text file all words listed in given another text file.
//Handle all possible exceptions in your methods.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

// триенето е case insensitive

class RemoveWords
{
    static readonly List<string> forbidenWords = new List<string>();
    static void Main()
    {
        try
        {
            const string textPath = "../../text.txt";
            const string forbidenWOrdsPath = "../../ForbidenWords.txt";
            const string resultPath = "../../result.txt";

            GetForbidenkWords(forbidenWOrdsPath);
            ExtractTextWithoutTags(textPath, resultPath);
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
    }

    static void PrintErrorMessage(Exception error)
    {
        Console.Error.WriteLine("Error! {0} - CALL PESHO!!\n", error.Message);
    }

    static void GetForbidenkWords(string pathBlackList)
    {
        using (StreamReader reader = new StreamReader(pathBlackList))
        {
            while (!reader.EndOfStream)
            {
                string[] fWords = reader.ReadLine().Split(new[] { ' ', ',', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in fWords)
                {
                    if (!forbidenWords.Contains(word))
                    {
                        forbidenWords.Add(word);
                    }
                }
            }
        }
    }

    static void ExtractTextWithoutTags(string pathText, string pathResult)
    {
        using (StreamWriter result = new StreamWriter(pathResult))
        {
            using (StreamReader reader = new StreamReader(pathText))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();

                    foreach (var word in forbidenWords)
                    {
                        string pattern = string.Format("\\b{0}\\b", word);

                        MatchCollection matches = Regex.Matches(line, pattern, RegexOptions.IgnoreCase);

                        foreach (var match in matches)
                        {
                            line = line.Replace(match.ToString(), "");
                        }
                    }

                    result.WriteLine(line.Trim(), true);        
                }
            }
        }
    }
}

