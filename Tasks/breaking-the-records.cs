using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem
    class BreakingtheRecords
    {
        public void Solve()
        {
            int n = 0;
            try { n = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("[Error] That's not a number!");
                return;
            }

            int[] scores = Common.ParseStringToArray(n, Console.ReadLine());
            int best = scores[0], bestCnt = 0,
                worst = scores[0], worstCnt = 0; 

            for (int i = 1; i < scores.Length; i++)
            {
                if (best < scores[i])
                {
                    best = scores[i];
                    bestCnt++;
                }
                if (worst > scores[i])
                {
                    worst = scores[i];
                    worstCnt++;
                }
            }

            Console.WriteLine($"{bestCnt} {worstCnt}");
        }
    }
}