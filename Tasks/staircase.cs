using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/staircase/problem
    class Staircase
    {
        private int n;

        public Staircase()
        {
            n = 0;
        }

        public void BuildStaircase()
        {
            Console.Write("Enter some positive non-zero integer: ");
            // some checks
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

            int column = 1;
            for (int row = 0; row < n; row++)
            {
                while (column < n - row)
                {
                    Console.Write(" ");
                    column++;
                }
                while (column <= n)
                {
                    Console.Write("#");
                    column++;
                }
                column = 1;
                Console.WriteLine();
            }
        }
    }
}