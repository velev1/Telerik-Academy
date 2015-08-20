//Problem 12. Parse URL

//Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the [protocol], [server] and [resource] elements.
//Example:

//URL	
//http://telerikacademy.com/Courses/Courses/Details/212	

//Information
//[protocol] = http 
//[server] = telerikacademy.com 
//[resource] = /Courses/Courses/Details/212


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class ParseURL
{
    static void Main(string[] args)
    {
        string url = "http://telerikacademy.com/Courses/Courses/Details/212";
        string protocolSep = "://";
        string resourseSep = "/";

        List<string> information =  new List<string>();
        List<int> indexesOfSep = new List<int>();
        List<string> typeInfo = new List<string>();
        typeInfo.Add("[protocol] = ");
        typeInfo.Add("[server] = ");
        typeInfo.Add("[resourse] = ");
        indexesOfSep.Add(url.IndexOf(protocolSep));
        information.Add(url.Remove(indexesOfSep[0]));
        indexesOfSep.Add(url.IndexOf(resourseSep, indexesOfSep[0] + protocolSep.Length));
        information.Add(url.Substring(indexesOfSep[0] + protocolSep.Length, indexesOfSep[1] - indexesOfSep[0] - protocolSep.Length));
        information.Add(url.Substring(indexesOfSep[1], url.Length - indexesOfSep[1]));
        Console.WriteLine("URL: {0}", url);
        Console.WriteLine();
        for (int i = 0; i < typeInfo.Count; i++)
        {
            Console.WriteLine(typeInfo[i] + information[i]);
        }
        Console.WriteLine();

        //const string URL = @"http://telerikacademy.com/Courses/Courses/Details/212";
        //var fragments = Regex.Match(URL, "(.*)://(.*?)(/.*)").Groups;

        //Console.WriteLine("URL Address: {0}", URL);
        //Console.WriteLine("\n[protocol] = {0}", fragments[1]);
        //Console.WriteLine("[server] = {0}", fragments[2]);
        //Console.WriteLine("[resource] = {0}\n", fragments[3]);
    }
}

