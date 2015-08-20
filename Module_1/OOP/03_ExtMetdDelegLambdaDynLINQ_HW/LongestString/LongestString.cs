// Problem 17. Longest string
// Write a program to return the string with maximum length from an array of strings.
// Use LINQ.
namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        public static void Main(string[] args)
        {
            string[] arrayOfStrings = { "I", "'", "Pessho", "and", "I'll", "I'll", "R...you :D" };

            string longest = LongestStringInArray(arrayOfStrings);
            Console.WriteLine(longest);
        }

        private static string LongestStringInArray(string[] arrayOfStrings)
        {
            var longestString =
                from str in arrayOfStrings
                orderby str.Length descending
                select str;

            return longestString.FirstOrDefault();
        }
    }
}
