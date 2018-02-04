using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/diagonal-difference/problem
    class DiagonalDifference
    {
        private int n;
        public DiagonalDifference()
        {
            n = 0;
        }

        public void CalculateDiagonalDifference()
        {
            Console.Write("Enter some positive non-zero integer < 100: ");
            try { n = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("[Error] I asked you to enter an integer!");
                return;
            }
            if (n < 1 || n > 100)
            {
                Console.WriteLine("[Error] I asked you to enter a positive non-zero integer < 100!");
                return;
            }

            int[,] array = new int[n, n];
            int[] arrayTemp = new int [n];
            Console.WriteLine($"Now enter {n} lines with {n} integers in each (N x N matrix): ");
            for (int line = 0; line < n; line++)
            {
                arrayTemp = Common.ParseStringToArray(n, Console.ReadLine());
                for (int column = 0; column < n; column++)
                {
                    array[line, column] = arrayTemp[column];
                }
            }

            // debug
            // for (int line = 0; line < n; line++)
            // {
            //     for (int column = 0; column < n; column++)
            //     {
            //         Console.Write($"{array[line, column]} ");
            //     }
            //     Console.WriteLine();
            // }
            
            long diagPrimary = 0;
            long diagSecondary = 0;
            for (int line = 0; line < n; line++)
            {
                diagPrimary += array[line, line];
                //Console.WriteLine(diagPrimary);
                diagSecondary += array[line, n - 1 - line];
                //Console.WriteLine(diagSecondary);
                //Console.WriteLine("- - -");
            }
            Console.WriteLine($"DiagonalDifference: {Math.Abs(diagPrimary - diagSecondary)}");
        }
    }
}