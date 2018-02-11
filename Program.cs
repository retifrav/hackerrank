using System;

namespace hackerrank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"[{DateTime.Now.ToString()}]: Start\n---\n");

            BreakingtheRecords problem = new BreakingtheRecords();
            problem.Solve();
            
            Console.WriteLine($"\n---\n[{DateTime.Now.ToString()}]: Finish");

            // BetweenTwoSets problem = new BetweenTwoSets();

            // Kangaroo problem = new Kangaroo();
            // problem.Solve();

            // GradingStudents problem = new GradingStudents();
            // problem.Solve();

            // TimeConversion tc = new TimeConversion();
            // tc.Solve();

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
