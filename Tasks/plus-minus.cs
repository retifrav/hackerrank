using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/plus-minus/problem
    class PlusMinus
    {
        private int n;
        public PlusMinus()
        {
            n = 0;
        }

        public void CalculateFractions()
        {
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

            Console.WriteLine($"Now enter {n} integers in one line separated with space");
            string[] input = Console.ReadLine().Split(' ');
            if (input.Length > n)
            {
                Console.WriteLine($"[Error] I asked you to enter {n} integers!");
                return;
            }
            int[] array = Array.ConvertAll(input, Int32.Parse);
            int plus = 0,
                minus = 0,
                zero = 0;
            foreach (int a in array)
            {
                if (a == 0) { zero++; }
                else
                {
                    if (a > 0) { plus++; }
                    else { minus++; }
                }
            }
            
            double plusFraction =
                Math.Round((double)plus / (double)n, 6, MidpointRounding.AwayFromZero);
            double minusFraction =
                Math.Round((double)minus / (double)n, 6, MidpointRounding.AwayFromZero);
            double zeroFraction =
                Math.Round((double)zero / (double)n, 6, MidpointRounding.AwayFromZero);

            Console.WriteLine(plusFraction);
            Console.WriteLine(minusFraction);
            Console.WriteLine(zeroFraction);
        }
    }
}