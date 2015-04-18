//Problem 8. Extract sentences

//Write a program that extracts from a given text all sentences containing given word.
//Example:

//The word is: in

//The text is: We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

//Consider that the sentences are separated by . and the words – by non-letter symbols.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ExtractSentences
    {
        static void Main()
        {
            string text = "We are living in a yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
            string wanted = " in ";
            FindeSentence(text, wanted);
        }

        static void FindeSentence(string text, string wanted)
        {
            List<string> textTosentences = new List<string>();
            List<int> separatorIndexes = new List<int>();

            int separatorIndex = -1;
            while (true)
            {
                separatorIndex = text.IndexOf('.', separatorIndex  + 1);
                if (separatorIndex == -1)
                {
                    break;
                }

                separatorIndexes.Add(separatorIndex);
            }

            for (int i = 0; i < separatorIndexes.Count; i++)
            {
                if (i == 0)
                {
                    textTosentences.Add(text.Substring(0, separatorIndexes[i] + 1));
                    //Console.WriteLine(textTosentences[i]);
                }
                else
                {
                    if (i != separatorIndexes.Count - 1 )
                    {
                        textTosentences.Add(text.Substring(separatorIndexes[i - 1] + 2, separatorIndexes[i] - separatorIndexes[i - 1]));
                    }
                    else
                    {
                        textTosentences.Add(text.Substring(separatorIndexes[i - 1] + 2, separatorIndexes[i] - separatorIndexes[i - 1] - 1) );
                    }
                }
            }

            int wantedIndex = -1;

            foreach (var sent in textTosentences)
            {
                wantedIndex = sent.IndexOf(wanted);

                if (wantedIndex != - 1)
                {
                    Console.WriteLine(sent);
                }
            }
        }
    }

