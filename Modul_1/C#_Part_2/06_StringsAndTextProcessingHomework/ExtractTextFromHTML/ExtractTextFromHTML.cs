/* Problem 25. Extract text from HTML

Write a program that extracts from given HTML file its title (if available), and its body text without the HTML tags.
Example input:

<html>
 <head><title>News</title></head>
 <body><p><a href="http://academy.telerik.com">Telerik
   Academy</a>aims to provide free real-world practical
   training for young people who want to turn into
   skilful .NET software engineers.</p></body>
</html>
Output:

Title: News

Text: Telerik Academy aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.
*/

using System;
using System.Collections.Generic;
using System.Text;

class ExtractTextFromHTML
{
    static void Main()
    {
        string text = @"<html><head><title>News</title></head> <body><p><a href=""http://academy.telerik.com"">Telerik Academy</a>aims to provide free real-world practical training for young people who want to turn into skilful .NET software engineers.</p></body>";

        string title = ExtractTitle(text);
        string body = ExtractBody(text);

        Console.WriteLine("Title: {0}\n", title);
        Console.WriteLine("Text: {0}\n", body);
    }

    static string ExtractBody(string text)
    {
        string body = text.Substring(text.IndexOf("<body>"));

        int bodyFrom = 0;
        int bodyTo = 0;

        while (true)
        {
            bodyFrom = body.IndexOf("<a");
            bodyTo = body.IndexOf(">", bodyFrom + 1) + 1;

            if (bodyFrom < 0)
            {
                break;
            }

            body = body.Remove(bodyFrom, bodyTo - bodyFrom);
        }

        body = body.Replace("<p>", "").Replace("</p>", "").Replace("</a>", " ").Replace("<body>", "")
            .Replace("</body>", "").Replace("</html>", ""); ;

        return body;
    }

    static string ExtractTitle(string text)
    {
        string title = text;

        int remFro = -1;
        int remTo = -1;

        while (true)
        {
            remFro = title.IndexOf("<title>", 0) + "<title>".Length;
            remTo = title.IndexOf("</title>", 0);

            if (remTo == -1)
            {
                break;
            }

            title = title.Substring(remFro, remTo - remFro);
        }

        if (title == text)
        {
            title = "";
        }

        return title;
    }

//    static int IndexOfSTBL(StringBuilder sb, string tag, int startIndex)
//    {
//        bool isIndexOf = false;
//        int index = -1;

//        for (int i = startIndex; i < sb.Length; i++)
//        {
//            if (sb[i] == tag[0])
//            {
//                isIndexOf = true;
//                for (int j = 1; j < tag.Length; j++)
//                {
//                    if (sb[i + j] != tag[j])
//                    {
//                        isIndexOf = false;
//                    }
//                }
//                if (isIndexOf)
//                {
//                    index = i;
//                    break;
//                }
//            }
//        }

//        return index;
//    }
}




