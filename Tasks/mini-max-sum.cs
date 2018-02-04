using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/mini-max-sum/problem
    class MiniMaxSum
    {
        private int n;
        public MiniMaxSum()
        {
            n = 0;
        }

        public void Solve()
        {
            #region Entering values
            Console.Write("Enter some positive non-zero integer: ");
            try { n = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("[Error] I asked you to enter an integer!");
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("[Error] I asked you to enter a positive non-zero integer!");
                return;
            }

            Console.WriteLine($"Now enter {n} integers separated by space: ");
            int[] array = Common.ParseStringToArray(n, Console.ReadLine());
            #endregion

            int indexOfMax = IndexOfMax(array),
                indexOfMin = IndexOfMin(array);

            long sumOfMax = 0,
                 sumOfMin = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (i != indexOfMax) { sumOfMin += array[i]; }
                if (i != indexOfMin) { sumOfMax += array[i]; }
            }

            Console.WriteLine($"Sum of min: {sumOfMin}, sum of max: {sumOfMax}");
        }

        int IndexOfMax(int[] arr)
        {
            int max = arr[0], index = 0;
            for (int a = 1; a < arr.Length; a++)
            {
                if (arr[a] > max) { max = arr[a]; index = a; }
            }
            return index;
        }

        int IndexOfMin(int[] arr)
        {
            int min = arr[0], index = 0;
            for (int a = 1; a < arr.Length; a++)
            {
                if (arr[a] < min) { min = arr[a]; index = a; }
            }
            return index;
        }
    }
}