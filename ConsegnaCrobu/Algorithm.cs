using System;
using System.Collections.Generic;
using System.Text;

namespace CrobuComputationalComplexity
{
    public static class Algorithm
    {
        public static int Calculate(int[] arr, int x, int y, int startingValue)
        {
            if (arr == null ||
                x > y)
                return 0;
            int n1 = default;
            try
            {
                n1 = (int)Math.Truncate(ReverseFunction(startingValue, x));
                if (arr[n1 - 1] == x)
                    n1--;
            }
            catch
            {
                n1 = 0;
            }
            int n2 = (int)Math.Truncate(ReverseFunction(startingValue, y));
            if (n2 > arr.Length)
                n2 = arr.Length;
            return n2 - n1;
        }

        public static int Function(int first, int n)
        {
            return (int)(first * Math.Pow(2, n));
        }

        public static decimal ReverseFunction(int first, int matchingValue)
        {
            return (decimal)Math.Log2(matchingValue / first) + 1;
        }
    }
}
}
