//Problem 4. Download file

//Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
//Find in Google how to download files in C#.
//Be sure to catch all exceptions and to free any used resources in the finally block.

using System;
using System.Net;

class DownloadFile
{
    static void Main()
    {
        Console.WriteLine("Alolw access to download webbased picture?\n ");
        string access = string.Empty;

        do
        {
            Console.Write("Y / N: ");
            access = Console.ReadLine().ToUpper();
        } while (!(access == "N" || access == "Y"));

        if (access == "N")
        {
            Console.WriteLine("As you wish :)");
            return;
        }

        using (WebClient downloader = new WebClient())
        {
            try
            {
                Console.WriteLine("\nDoanloading...");
                downloader.DownloadFile("http://telerikacademy.com/Content/Images/news-img01.png", "../../Ninja.png");
                Console.WriteLine("\n...Flie downloaded!!\n");
            }
            catch (ArgumentException)
            {
                Console.Error.WriteLine("\n-> Error: You have entered an empty URL!");
            }
            catch (WebException)
            {
                Console.Error.WriteLine("\n-> Error: You have entered an invalid URL!");
            }
            catch (NotSupportedException)
            {
                Console.Error.WriteLine("\n-> Error: This method does not support simultaneous downloads!");
            }
        }
    }
}

