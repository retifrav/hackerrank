using System;

namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}]: Start\n---");

            MiniMaxSum mms = new MiniMaxSum();
            mms.Solve();
            
            Console.WriteLine($"---\n[{DateTime.Now.ToString()}]: Finish");

            // Staircase sc = new Staircase();
            // sc.BuildStaircase();

            // PlusMinus pm = new PlusMinus();
            // pm.CalculateFractions();

            // DiagonalDifference dd = new DiagonalDifference();
            // dd.CalculateDiagonalDifference();
        }
    }
}
