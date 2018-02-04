using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/grading/problem
    class GradingStudents
    {
        private int n;
        public GradingStudents()
        {
            n = 0;
        }

        public void Solve()
        {
            Console.Write("Enter the number of students: ");
            try { n = Convert.ToInt32(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("[Error] I asked you to enter a number!");
                return;
            }
            if (n < 1)
            {
                Console.WriteLine("[Error] The fuck am I supposed to do with it?");
                return;
            }
            int[] gradesRounded = new int[n];
            Console.WriteLine($"Now enter {n} grades, one per line: ");
            for (int i = 0; i < n; i++)
            {
                gradesRounded[i] = Convert.ToInt32(Console.ReadLine());
                if (gradesRounded[i] < 0 || gradesRounded[i] > 100)
                {
                    Console.WriteLine("[Error] Grades should be in the range [0-100]!");
                    return;
                }
                gradesRounded[i] = RoundGrade(gradesRounded[i]);
            }

            foreach (int g in gradesRounded) { Console.WriteLine(g); }
        }

        int RoundGrade(int grade)
        {
            if (grade < 38) { return grade; }
            
            int div5 = grade;
            while (div5 % 5 != 0) { div5++; }
            if (div5 - grade > 2) { return grade; }
            
            return div5;
        }
    }
}