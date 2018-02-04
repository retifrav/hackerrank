using System;

namespace hackerrank
{
    static class Common
    {
        public static int[] ParseStringToArray(int n, string str)
        {
            int[] arrayInt = new int[n];
            string[] arrayStr = str.Split(' ');
            for (int i = 0; i < n; i++)
            {
                arrayInt[i] = Convert.ToInt32(arrayStr[i]);
            }
            return arrayInt;
        }
    }
}