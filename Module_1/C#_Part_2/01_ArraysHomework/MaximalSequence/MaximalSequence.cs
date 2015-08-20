//Problem 4. Maximal sequence

//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                            result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2

using System;
using System.Collections.Generic;
using System.Linq;

class MaximalSequence
{
    static void Main()
    {
        //Има 3 варианта, първият и вторият са закоментирани!!

        //Вариант 3. отделните елементи могата да бъдат повече от един символ, и на входа трябва да бъдат разделени със запетая ','.

        Console.WriteLine("Enter elements of the array in one lane separated by ',' (each element can contain more than one symbol):");
        Console.WriteLine();
        string input = Console.ReadLine();
        Console.WriteLine();

        string[] inputToArray = input.Split(',');

        List<int> tempMaxSecElements = new List<int>();
        List<int> maxSecElements = new List<int>();

        for (int i = 0; i < inputToArray.Length; i++)
        {
            if (((i < inputToArray.Length - 1) && ((inputToArray[i] == inputToArray[i + 1]))))
            {
                tempMaxSecElements.Add(i);
            }
            else if (((i > 0) && ((inputToArray[i] == inputToArray[i - 1]))))
            {
                tempMaxSecElements.Add(i);
            }

            if ((i < inputToArray.Length - 1) && (inputToArray[i] != inputToArray[i + 1]))
            {
                if (tempMaxSecElements.Count > maxSecElements.Count)
                {
                    maxSecElements = tempMaxSecElements.ToList();
                    tempMaxSecElements.Clear();
                }
                else
                {
                    tempMaxSecElements.Clear();
                }
            }
        }

        if (tempMaxSecElements.Count > maxSecElements.Count)
        {
            maxSecElements = tempMaxSecElements.ToList();
            tempMaxSecElements.Clear();
        }

        Console.WriteLine("The longest secuence of equal elements is");
        for (int i = 0; i < maxSecElements.Count; i++)
        {
            if (i == maxSecElements.Count - 1)
            {
                Console.Write("{0} - Total {1} equal elements", inputToArray[maxSecElements[i]], maxSecElements.Count);
            }
            else
            {
                Console.Write("{0}, ", inputToArray[maxSecElements[i]]);
            }
        }

        Console.WriteLine();
        Console.WriteLine();

        //вариант 1 - вход като стринг за единични символи (без разделител м/у символите)- действа и за вскякакви други символи освен цифри. 
        //стринга е масив от чарове на практика :)
        //бъг - ако има повече от една поредица с еднакви максимални дължини, с еднакви символи - изкарва само пътвата (пример 6662777 => отговор 666)
        //Обшо взето я тествах доста и ако има други бъгове моля споделяйте :)
        /*
        Console.WriteLine("Enter elements of the array in one line without separation:");
        string inputToArray = Console.ReadLine();

        string maxSecuence = "";
        string tempMaxSec = "";

        for (int i = 0; i < inputToArray.Length; i++)
        {

           
            if (((i < inputToArray.Length - 1) && ((inputToArray[i] == inputToArray[i + 1]))))
            {
                tempMaxSec += inputToArray[i];
            }
            else if (((i > 0) && ((inputToArray[i] == inputToArray[i - 1]))))
            {
                tempMaxSec += inputToArray[i];
            }
            if ((i < inputToArray.Length - 1) && (inputToArray[i] != inputToArray[i + 1]))
            {

                if (tempMaxSec.Length > maxSecuence.Length)
                {
                    maxSecuence = tempMaxSec;
                    tempMaxSec = "";
                }
                else
                {
                    tempMaxSec = "";
                }
            }
           
        }

        if (tempMaxSec.Length > maxSecuence.Length)
        {
            maxSecuence = tempMaxSec;
            tempMaxSec = "";
        }
        Console.WriteLine("The longest secuence of equal symbols is: {0}", maxSecuence);
        */

        //вариант 2 - вход - отделните елементи могата да бъдат повече от един символ, и на входа трябва да бъдат разделени със запетая ','.
        //чийтърски аутпут - не вади реално елементите от масива а ги изкарва в едно стрингче, евентуално във вариант 3, ще пробвам да пази номерата на елементите в масива и така да ги изкарва!!

        /*
        Console.WriteLine("Enter elements of the array in one lane separated by ',' (each element can contain more than one symbol):");
        string input = Console.ReadLine();

        string[] inputToArray = input.Split(',');

        string maxSecuence = "";
        string tempMaxSec = "";

        for (int i = 0; i < inputToArray.Length; i++)
        {
            if (((i < inputToArray.Length - 1) && ((inputToArray[i] == inputToArray[i + 1]))))
            {
                tempMaxSec += inputToArray[i] + ",";
            }
            else if (((i > 0) && ((inputToArray[i] == inputToArray[i - 1]))))
            {
                tempMaxSec += inputToArray[i] + ",";
            }
            if ((i < inputToArray.Length - 1) && (inputToArray[i] != inputToArray[i + 1]))
            {
                if (tempMaxSec.Length > maxSecuence.Length)
                {
                    maxSecuence = tempMaxSec;
                    tempMaxSec = "";
                }
                else
                {
                    tempMaxSec = "";
                }
            }
        }

        if (tempMaxSec.Length > maxSecuence.Length)
        {
            maxSecuence = tempMaxSec;
            tempMaxSec = "";
        }

        Console.WriteLine("The longest secuence of equal elements is:");
        for (int i = 0; i < maxSecuence.Length - 1; i++)
        {
            Console.Write("{0}", maxSecuence[i]);
        }
        Console.WriteLine();
        */


        //Вариант 4 - oт workshopa

        //int[] nums = {2, 1, 1, 2, 3, 3, 2, 2, 2, 1};
        ////string[] numStr = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

        //int currentNum, maxNum = nums[0];
        //int currentCount, maxCount = 0;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    currentNum = nums[i];
        //    currentCount = 0;
        //    for (int j = i; j < nums.Length; j++)
        //    {
        //        if (currentNum == nums[j])
        //        {
        //            currentCount++;
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }


        //    if (maxCount< currentCount)
        //    {
        //        maxCount = currentCount;
        //        maxNum = currentNum;
        //    }
            
        //}
        //Console.WriteLine("{0} x {1}", maxCount, maxNum);
           
 
    }
}

