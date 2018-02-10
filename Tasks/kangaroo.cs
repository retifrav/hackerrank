using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/kangaroo/problem
    class Kangaroo
    {
        int n = 4;
        public void Solve()
        {
            int[] input = Common.ParseStringToArray(n, Console.ReadLine());
            int start1 = input[0],
                length1 = input[1],
                start2 = input[2],
                length2 = input[3];

            if (start1 < 0 || start2 < 0 || start1 > 10000 || start2 > 10000)
            {
                Console.WriteLine("[Error] Start position should be in range [0-10000]");
                return;
            }
            if (length1 < 1 || length2 < 1 || length1 > 10000 || length2 > 10000)
            {
                Console.WriteLine("[Error] Jump length should be in range [1-10000]");
                return;
            }

            // first eliminate obvious cases
            if (length1 == length2)
            {
                if (start1 == start2)
                {
                    Console.WriteLine("YES");
                    return;
                }
                else
                {
                    Console.WriteLine("NO");
                    return;
                }
            }
            else
            {
                if (start1 == start2)
                {
                    Console.WriteLine("NO");
                    return;
                }
                else
                {
                    if ((start1 > start2 && length1 > length2) || (start1 < start2 && length1 < length2))
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    // now we're talking
                    bool thereIsStillChance = true;
                    long progress1 = start1,
                         progress2 = start2,
                         diff = Math.Abs(progress1 - progress2),
                         newDiff = 0;
                    
                    // debug
                    Console.WriteLine($"{progress1} - {progress2} = {diff}");

                    while (thereIsStillChance)
                    {
                        progress1 += length1;
                        progress2 += length2;

                        newDiff = Math.Abs(progress1 - progress2);    
                        
                        // debug
                        Console.WriteLine($"{progress1} | {progress2} : {newDiff}");

                        if (progress1 == progress2)
                        {
                            Console.WriteLine("YES");
                            return;
                        }
                        else
                        {   
                            if (newDiff < diff)
                            {
                                diff =  newDiff;
                                continue;
                            }
                            else { thereIsStillChance = false; }
                        }
                    }
                    Console.WriteLine("NO");
                    return;
                }
            }
        }
    }
}