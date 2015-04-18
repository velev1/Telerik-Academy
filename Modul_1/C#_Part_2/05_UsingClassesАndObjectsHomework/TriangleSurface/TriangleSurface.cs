//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;


class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("Lests calculate surface of triangle:");
        Console.WriteLine("Choose the way to do it:");
        Console.WriteLine("If yo know side and an altitude to it enter -> 1;");
        Console.WriteLine("If yo know three sides enter -> 2;");
        Console.WriteLine("If yo know two sides and an angle between them enter -> 3;");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "1": CalculateBySideAndAltitude(); break;
            case "2": CalcByThreeSides(); ; break;
            case "3": CalcByTwoSidesAndAngle(); break;
            default: Console.WriteLine("Incorrect choice - re run the program :D");
                break;
        }
    }

    static void CalculateBySideAndAltitude()
    {
        Console.Write("Enter side: ");
        double side = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter altitude: ");
        double altitude = double.Parse(Console.ReadLine());
        double surface = (side * altitude) / 2d;
        Console.WriteLine("The surface of the triangle is: {0}\n", surface);
    }

    static void CalcByThreeSides()
    {
        Console.Write("Enter side 1: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side 2: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter side 3: ");
        double c = double.Parse(Console.ReadLine());
        double p = (a + b + c) / 2.0;
        double surface = Math.Sqrt(p * (p - a) * (p - b) * (p - c));        
        Console.WriteLine("The surface of the triangle is: {0}\n", surface);
    }

    static void CalcByTwoSidesAndAngle()
    {
        Console.Write("Enter side 1: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter side 2: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the angle between them(in degreese): ");
        double angle = double.Parse(Console.ReadLine());
        angle = angle * 0.0174532925;
        double surface = (a * b * Math.Sin(angle)) / 2.0;
        Console.WriteLine("The surface of the triangle is: {0}\n", surface); 
    }
}

