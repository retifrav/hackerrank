using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/time-conversion/problem
    class TimeConversion
    {
        public void Solve()
        {
            Console.Write("Enter some time in stupid AM/PM format: ");
            string timeAMPM = Console.ReadLine().Trim();
            var regex = new Regex(@"(1[0-2]|0?[1-9]):[0-5][0-9]:\d\d[A|P]M");
            if (!regex.IsMatch(timeAMPM))
            {
                Console.WriteLine("[Error] That is not the time format I was asking for!");
                return;
            }

            string time24 = timeAMPM.Remove(timeAMPM.Length - 2);
            int hours = Convert.ToInt32(timeAMPM.Substring(0, 2));
            if (timeAMPM.Contains("A"))
            {
                if (hours == 12) { time24 = $"00{time24.Substring(2)}"; }
            }
            else
            {
                if (hours != 12) { time24 = $"{hours += 12}{time24.Substring(2)}"; }
            }
            
            Console.WriteLine(time24);
        }
    }
}