//Problem 3. Read file contents

//Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
//Find in MSDN how to use System.IO.File.ReadAllText(…).
//Be sure to catch all possible exceptions and print user-friendly error messages.

using System;
using System.IO;

class ReadFileContents
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Enter full path to file (incl file name and extension) you want to read: ");
            string path = Console.ReadLine();
            StreamReader reader = new StreamReader(path);
            using (reader)
            {
                Console.WriteLine(File.ReadAllText(path));
            }
        }
        catch(DriveNotFoundException)
        {
            Console.WriteLine("\nDrive not found!\nCall Pesho!");
        }
        catch (NotSupportedException)
        {
            Console.WriteLine("\nPath format not supported!\nCall Pesho!");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("\nFile not found!\nCall Pesho!");
        }
        catch (DirectoryNotFoundException)
        {
            Console.WriteLine("\nDirectory not found!\nCall Pesho!");
        }
        catch (FileLoadException)
        {
            Console.WriteLine("\nThe file could not be load!\nCall Pesho!");
        }
        catch (PathTooLongException)
        {
            Console.WriteLine("\nToo long pathh!\nCall Pesho!");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("\nYou have no permitons to open the file!\nCall Pesho!");
        }
        catch (FieldAccessException)
        {
            Console.WriteLine("\nAcces denied!\nCall Pesho!");
        }
        catch (Exception)
        {
            Console.WriteLine("\nCall Pesho!\nThen call Gosho!\nThere is something very wrong!!");
        }
    }
}

