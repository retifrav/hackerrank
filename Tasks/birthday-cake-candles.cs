using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/birthday-cake-candles/problem
    class BirthdayCakeCandles
    {
        private int n;
        public BirthdayCakeCandles()
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

            int max = array[0], cnt = 1;
            for (int a = 1; a < array.Length; a++)
            {
                if (array[a] == max) { cnt++; continue; }
                if (array[a] > max) { max = array[a]; cnt = 1; }
            }

            Console.WriteLine(cnt);
        }
    }
}