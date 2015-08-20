/*
Problem 6. Save sorted names

Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
Example:

input.txt	output.txt
Ivan        George 
Peter       Ivan 
Maria       Maria
George	    Peter
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


class SaveSortedNames
{
    static void Main()
    {
        List<string> names = new List<string>();

        using (var readUnsorted = new StreamReader("..\\..\\unsorted.txt"))
        {
            do
            {
                string currName = readUnsorted.ReadLine();
                if (currName == null)
                {
                    break;
                }

                names.Add(currName);
            } while (true);
        }

        names.Sort();

        using (var writeSorted = new StreamWriter("..\\..\\sorted.txt"))
        {
            foreach (var name in names)
            {
                writeSorted.WriteLine(name);
            }
        }
        Console.WriteLine("Check sorted names at ..\\..\\sorted.txt");
    }
}

