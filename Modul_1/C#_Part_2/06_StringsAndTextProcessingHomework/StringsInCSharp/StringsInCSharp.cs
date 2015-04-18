//Problem 1. Strings in C#.

//Describe the strings in C#.
//What is typical for the string data type?
//Describe the most important methods of the String class.

using System;

class StringsInCSharp
{
    static void Main()
    {
        Console.BufferHeight = 300;
        Console.BufferWidth = 100;

        Console.WriteLine(@"
A string is an object of type String whose value is text. 
Internally, the text is stored as a sequential read-only collection of Char objects. T
here is no null-terminating character at the end of a C# string; therefore a C# string 
can contain any number of embedded null characters ('\0'). The Length property of a string 
represents the number of    Char objects it contains, not the number of Unicode characters. 
To access the individual Unicode code points in a string, use the StringInfo object.

String objects are immutable: they cannot be changed after they have been created.
All of the String methods and C# operators that appear to modify a string actually return 
theresults in a new string object. In the following example, when the contents of s1 and s2 
are concatenated to form a single string, the two original strings are unmodified. 
The  += operator creates a new string that contains the combined contents. 
That new object is assigned to the variable s1, and the original object that was assigned 
to s1 is   released for garbage collection because no other variable holds a reference to it.

Because a string ""modification"" is actually a new string creation, you must use caution when 
you create references to strings. If you create a reference to a string, and then  ""modify"" 
the original string, the reference will continue to point to the original object instead of the 
new object that was created when the string was modified

String objects are like arrays of characters (char[])
Have fixed length (String.Length)
Elements can be accessed directly by index
The index is in the range [0...Length-1]

Methods. Here are the methods and properties on strings. Some are static. 
We access them on the string type (like string.Empty). 
Complex algorithms often use many string methods.

            Compare
            CompareOrdinal
            CompareTo
            Concat
            Contains
            Copy
            CopyTo
            EndsWith
            Empty
            Equals
            Format
            GetHashCode
            IndexOf
            IndexOfAny
            Insert
            Intern
            IsInterned
            IsNormalized
            IsNullOrEmpty
            IsNullOrWhiteSpace
            Join
            LastIndexOf
            LastIndexOfAny
            Length
            Normalize
            PadLeft
            PadRight
            Remove
            Replace
            Split
            StartsWith
            Substring
            ToCharArray
            ToLower
            ToLowerInvariant
            ToString
            ToUpper
            ToUpperInvariant
            Trim
            TrimEnd
            TrimStart
");
    }
}

