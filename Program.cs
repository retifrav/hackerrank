using System;

namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}]: Start\n---\n");

            TimeConversion tc = new TimeConversion();
            tc.Solve();
            
            Console.WriteLine($"\n---\n[{DateTime.Now.ToString()}]: Finish");

            // BirthdayCakeCandles bcc = new BirthdayCakeCandles();
            // bcc.Solve();

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
