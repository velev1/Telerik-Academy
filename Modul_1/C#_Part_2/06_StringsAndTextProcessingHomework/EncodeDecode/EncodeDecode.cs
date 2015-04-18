//Problem 7. Encode/decode

//Write a program that encodes and decodes a string using given encryption key (cipher).
//The key consists of a sequence of characters.
//The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, the second – with the second, etc. When the last key character is reached, the next is the first.

using System;
using System.Linq;

class EncodeDecodeTask
{
    static void Main(string[] args)
    {
        Console.Write("Enter text to decode/encode: ");
        char[] text = Console.ReadLine().ToCharArray();
        Console.WriteLine("Enter the encription key: ");
        char[] key = Console.ReadLine().ToCharArray();
        EncodeDecode(text, key);
        Console.WriteLine("Encoded: {0}", new string(text));
        EncodeDecode(text, key);
        Console.WriteLine("Decoded: {0}", new string(text));
    }

    static void EncodeDecode(char[] text, char[] key)
    {
        int keyIndex = 0;

        for (int i = 0; i < text.Count(); i++)
        {
            if (keyIndex == key.Count())
            {
                keyIndex = 0;
            }

            text[i] = (char)(text[i] ^ key[keyIndex]);
            ++keyIndex;
        }
    }
}

