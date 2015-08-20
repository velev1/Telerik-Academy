// Problem 1. StringBuilder.Substring
// Implement an extension method Substring(int index, int length) for the class StringBuilder 
// that returns new StringBuilder and has the same functionality as Substring in the class String.

namespace ExtensioMethods.ExtensionMethods
{
    using System;
    using System.Text;

    public static class StringBuilderExtensions
    {       
        public static StringBuilder Substring(this StringBuilder sb, int index, int length)
        {
            string tempSb = sb.ToString().Substring(index, length);
            return sb.Clear().Append(tempSb);
        }
    }
}
