using System;

namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}]: Start\n---\n");

            BirthdayCakeCandles bcc = new BirthdayCakeCandles();
            bcc.Solve();
            
            Console.WriteLine($"\n---\n[{DateTime.Now.ToString()}]: Finish");

            // MiniMaxSum mms = new MiniMaxSum();
            // mms.Solve();

            // Staircase sc = new Staircase();
            // sc.BuildStaircase();

            // PlusMinus pm = new PlusMinus();
            // pm.CalculateFractions();

            // DiagonalDifference dd = new DiagonalDifference();
            // dd.CalculateDiagonalDifference();
        }
    }
}
