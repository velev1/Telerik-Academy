using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Text.RegularExpressions;

//https://github.com/dentia/TelerikAcademy/blob/master/Homeworks/C%232/Arrays/Combination/Combination.cs теглен код

class Problem_5
{

    static void Main()
    {
        string[] catsInput = Console.ReadLine().Split(' ').ToArray();
        int catsCount = int.Parse(catsInput[0]);

        string[] songsInput = Console.ReadLine().Split(' ').ToArray();
        int songsCount = int.Parse(songsInput[0]);

        bool[,] matrix = new bool[catsCount, songsCount];

        while (true)
        {
            string nexLine = Console.ReadLine();
            if (nexLine == "Mew!")
            {
                break;
            }
            string[] line = nexLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            matrix[int.Parse(line[1]) - 1, int.Parse(line[4]) - 1] = true;
        }

        int[] cols = new int[songsCount];
        int[] bestCols = new int[songsCount];



        for (int col = 0; col < songsCount; col++)
        {
            for (int row = 0; row < songsCount; row++)
            {
                if (matrix[row, col] == true)
                {
                    cols[col] += 1;
                }
            }
        }

        // check is concert possible
        bool isCorrect = false;

        for (int i = 0; i < catsCount; i++)
        {
            isCorrect = false;
            for (int j = 0; j < songsCount; j++)
            {
                if (matrix[i, j] == true)
                {
                    isCorrect = true;
                    break;
                }
            }

            if (!isCorrect)
            {
                Console.WriteLine("No concert!");
                return;
            }
        }

        // best columns

        int minSongs = songsCount + 1;

        bool[] currCat = new bool[songsCount];


        int curentMInSongs = 0;

        

        for (int i = 1; i <= songsCount; i++)
        {
            CombinatoricsComb.Combination combGenerator = new CombinatoricsComb.Combination(i);
            curentMInSongs = 0;

            int[] comb = combGenerator.GetAllCombinations(songsCount);

            foreach (var col in comb)
            {
                Console.Write("{0} ", col);
                curentMInSongs++;
                for (int row = 0; row < songsCount; row++)
                {
                    if (matrix[row, col] == true)
                    {
                        currCat[row] = true;
                    }
                }
            }

            if (!(currCat.Contains(false)))
            {
                if (curentMInSongs < minSongs)
                {
                    minSongs = curentMInSongs;
                }
            }

            for (int j = 0; j < currCat.Length; j++)
            {
                currCat[j] = false;
            }
            Console.WriteLine();
        }

        Console.WriteLine(minSongs );
    }
}

//﻿
//namespace Combinatorics
//{
//    using System.Collections.Generic;
//    using System.Text;
//    public class Permutation
//    {
//        private int length;
//        private int range;
//        StringBuilder permutations;

//        public Permutation(int length)
//        {
//            this.length = length;
//            this.range = length;
//            this.permutations = new StringBuilder();
//        }

//        public string GetAllPermutations()
//        {
//            int[] temp = new int[this.length];
//            bool[] used = new bool[this.length];
//            Permute(temp, used, 0);

//            return this.permutations.ToString();
//        }

//        private void Permute(int[] array, bool[] used, int currentIndex)
//        {
//            if (currentIndex == array.Length)
//            {
//                this.permutations.AppendLine(string.Format("{0}{1}{2}", "{", string.Join(", ", array), "}"));
//                return;
//            }

//            for (int number = 1; number <= range; number++)
//            {
//                if (!used[number - 1])
//                {
//                    used[number - 1] = true;
//                    array[currentIndex] = number;
//                    Permute(array, used, currentIndex + 1);
//                    used[number - 1] = false;
//                }
//            }
//        }
//    }
//}



//namespace CombinatoricsComb
//{
//    using System.Text;
//    public class Combination
//    {
//        private int length;
//        private StringBuilder allCombinations;
//        public Combination(int length)
//        {
//            allCombinations = new StringBuilder();
//            this.length = length;
//        }

//        public int[] GetAllCombinations(int range)
//        {
//            int[] array = new int[length];
//            GenerateCombinations(array, 0, 1, range);
//            return array;
//        }
//        public void GenerateCombinations(int[] array, int currentIndex, int startNum, int range)
//        {
//            if (currentIndex == array.Length)
//            {
//                allCombinations.AppendLine(string.Format("{0}{1}{2}", "{", string.Join(", ", array), "}"));
//                return;
//            }
//            else
//            {
//                for (int number = startNum; number <= range; number++)
//                {
//                    array[currentIndex] = number;
//                    GenerateCombinations(array, currentIndex + 1, number + 1, range);
//                }
//            }
//        }
//    }
//}