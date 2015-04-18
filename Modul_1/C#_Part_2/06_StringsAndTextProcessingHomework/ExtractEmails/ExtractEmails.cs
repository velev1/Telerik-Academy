//Problem 18. Extract e-mails

//Write a program for extracting all email addresses from given text.
//All sub-strings that match the format <identifier>@<host>…<domain> should be recognized as emails.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExtractEmails
{
    static void Main()
    {
        string text = @"E-mails: pesho@gosho.com, gosho@pesho.ru, kotka@stol.ta. Pesho@pesho.pesho is 
                        a special e-mail and the domain @.pesho rules, tosho@Pesho.gosh0 is not an e-mail";
        string[] allWords = text.Split(new [] {" ", ";", ",", ". ", "!", "?", ":"}, StringSplitOptions.RemoveEmptyEntries);
        List<string>  emails = new List<string>();
        IsEmail(allWords, emails);
        PrintMails(emails);
    }

    static void PrintMails(List<string> mails)
    {
        Console.WriteLine("The e-mails in the text are: \n");
        foreach (var mail in mails)
        {
            Console.WriteLine(mail);
        }

        Console.WriteLine();
    }

    static void IsEmail(string[] textWords, List<string> mails) 
    {
        foreach (var word in textWords)
        {
            int indexAtFirst = word.IndexOf("@");
            int indexAtLast = word.LastIndexOf("@");
            int indexDotFirst = word.IndexOf(".");
            int indexDotLast = word.LastIndexOf(".");

            bool isOk = !(word.Contains("#") || word.Contains("!") || word.Contains("/") || word.Contains("\\") || word.Contains("?"))//etc. special characters
                && (indexAtFirst == indexAtLast && indexAtFirst != -1 && indexAtFirst != word.Length - 1  && indexAtFirst != 0)
                && (indexDotFirst == indexDotLast && indexDotLast != -1 && indexDotFirst != word.Length - 1 && indexDotFirst != 0)
                && (( Math.Abs(indexAtFirst - indexDotFirst) != 1));

            if (isOk)
            {
                foreach (char symbol in word.Substring(indexDotFirst))
                {
                    if (char.IsDigit(symbol))
                    {
                        isOk = false;
                    }
                }
            }

            if (isOk)
            {
                mails.Add(word);
            }
        }
    }
}

