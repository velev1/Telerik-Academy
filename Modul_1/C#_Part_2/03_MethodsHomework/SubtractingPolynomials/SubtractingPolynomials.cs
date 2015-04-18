using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SubtractingPolynomials
{
    static void Main()
    {
        Console.Write("Enter first polynomial degree: ");
        int firstDegree = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] firstPol = (int[])InputPolynomials(firstDegree).Clone();

        Console.WriteLine();

        Console.Write("Enter second polynomial degree: ");
        int secondDegree = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int[] secondPol = (int[])InputPolynomials(secondDegree).Clone();

        Console.Write("\nEnter operation between them (+ , - , *): ");
        string operation = Console.ReadLine();

        if (operation == "+")
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 43));
            Console.WriteLine();
            PirntPolynomials(firstPol);
            Console.WriteLine("\n+\n");
            PirntPolynomials(secondPol);
            Console.WriteLine("\n=\n");
            int[] result = (int[])(AddingPols(firstPol, secondPol)).Clone();
            PirntPolynomials(result);
            Console.WriteLine();
        }
        else if (operation == "-")
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 43));
            Console.WriteLine();
            PirntPolynomials(firstPol);
            Console.WriteLine("\n-\n");
            PirntPolynomials(secondPol);
            Console.WriteLine("\n=\n");
            int[] result = (int[])(SubstrPols(firstPol, secondPol)).Clone();
            PirntPolynomials(result);
            Console.WriteLine();
        }
        else if (operation == "*")
        {
            Console.WriteLine();
            Console.WriteLine(new string('-', 43));


            Console.WriteLine();
            PirntPolynomials(firstPol);
            Console.WriteLine("\n*\n");
            PirntPolynomials(secondPol);
            Console.WriteLine("\n=\n");
            int[] result = (int[])(MultiplyPols(firstPol, secondPol)).Clone();
            PirntPolynomials(result);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("\nInvalid operation!!!");
        }



    }

    static int[] MultiplyPols(int[] firstPol, int[] secondPol)
    {
        int lengthMax = Math.Max(firstPol.Length, secondPol.Length);
        int[] result = new int[firstPol.Length + secondPol.Length - 1];

        int[] tempPol = new int[lengthMax];

        if (firstPol.Length <= secondPol.Length)
        {
            tempPol = (int[])firstPol.Clone();
            firstPol = (int[])secondPol.Clone();
            secondPol = (int[])tempPol.Clone();
        }
        int[] tempResult = new int[result.Length];

        for (int i = 0; i < secondPol.Length; i++)
        {
            for (int j = 0; j < firstPol.Length; j++)
            {
                tempResult[j + i] = firstPol[j] * secondPol[i];
            }

            result = (int[])(AddingPols(result, tempResult)).Clone();

            for (int h = 0; h < result.Length; h++)
            {
                tempResult[h] = 0;
            }
        }

        return result;
    }

    static int[] SubstrPols(int[] firstPol, int[] secondPol)
    {
        int lengthMax = Math.Max(firstPol.Length, secondPol.Length);
        int[] resultPol = new int[lengthMax];
        int[] tempPol = new int[lengthMax];

        if (firstPol.Length <= secondPol.Length)
        {
            tempPol = (int[])firstPol.Clone();
            firstPol = (int[])secondPol.Clone();
            secondPol = (int[])tempPol.Clone();
        }

        for (int i = 0; i < secondPol.Length; i++)
        {
            resultPol[i] = firstPol[i] - secondPol[i];
        }

        for (int i = secondPol.Length; i < lengthMax; i++)
        {
            resultPol[i] = firstPol[i];
        }

        return resultPol;
    }

    static int[] AddingPols(int[] firstPol, int[] secondPol)
    {
        int lengthMax = Math.Max(firstPol.Length, secondPol.Length);
        int[] resultPol = new int[lengthMax];
        int[] tempPol = new int[lengthMax];

        if (firstPol.Length <= secondPol.Length)
        {
            tempPol = (int[])firstPol.Clone();
            firstPol = (int[])secondPol.Clone();
            secondPol = (int[])tempPol.Clone();
        }

        for (int i = 0; i < secondPol.Length; i++)
        {
            resultPol[i] = firstPol[i] + secondPol[i];
        }

        for (int i = secondPol.Length; i < lengthMax; i++)
        {
            resultPol[i] = firstPol[i];
        }

        return resultPol;
    }

    static int[] InputPolynomials(int n)
    {
        int[] pol = new int[n + 1];

        for (int i = 0; i <= n; i++)
        {
            Console.Write("X^{0} = ", i);
            pol[i] = int.Parse(Console.ReadLine());
        }

        return pol;
    }

    static void PirntPolynomials(int[] pol)
    {
        for (int i = pol.Length - 1; i >= 0; i--)
        {
            if (pol[i] != 0 && i != 0)
            {
                if (pol[i] == 1)
                {
                    if (i == 1)
                    {
                        Console.Write("X + ", pol[i]);
                    }
                    else
                    {
                        Console.Write("X^{1} + ", pol[i], i);
                    }
                }
                else
                {
                    if (i == 1)
                    {
                        Console.Write("{0}X + ", pol[i]);
                    }
                    else
                    {
                        Console.Write("{0}X^{1} + ", pol[i], i);
                    }
                }
            }
            else if (i == 0 && pol[i] != 0)
            {
                Console.Write("{0}", pol[i]);
            }
        }

        Console.WriteLine();
    }
}

