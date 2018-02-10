using System;
using System.Collections.Generic;

namespace hackerrank
{
    // https://www.hackerrank.com/challenges/between-two-sets/problem
    class BetweenTwoSets
    {
        public void Solve()
        {
            int[] sizes = Common.ParseStringToArray(2, Console.ReadLine());
            
            int[] array1 = Common.ParseStringToArray(sizes[0], Console.ReadLine());
            int[] array2 = Common.ParseStringToArray(sizes[1], Console.ReadLine());

            int betweensCount = 0;
            int min = FindMin(array1);
            int max = FindMax(array2);
            
            bool shouldContinue = true;
            for (int i = min; i <= max; i++)
            {
                shouldContinue = true;
                foreach (int a in array1)
                {
                    if (i % a != 0)
                    {
                        shouldContinue = false;
                        break;
                    }
                }
                if (shouldContinue)
                {
                    foreach (int a in array2)
                    {
                        if (a % i != 0)
                        {
                            shouldContinue = false;
                            break;
                        }
                    }

                    if (shouldContinue) { betweensCount++; }
                }
            }

            Console.WriteLine(betweensCount);
        }

        int FindMin(int[] array)
        {
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        int FindMax(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}