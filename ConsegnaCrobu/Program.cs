using System;

namespace CrobuComputationalComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantity = 10;
            int startingValue = 3;
            var arr = new int[quantity];
            for (int v = 0; v < quantity; v++)
                arr[v] = Function(startingValue, v);
            int x = 50;
            int y = 500;

            try
            {
                int result = Calculate(arr, x, y, startingValue);
                Console.Write("Input list: ");
                for (int c = 0; c < arr.Length; c++)
                    Console.Write(arr[c].ToString() + " ");
                Console.WriteLine($"\nNumber quantity between {x} (x) and {y} (y) included: {result}");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                Console.WriteLine("*****possible correction: change x or y value(s)*****");
                Console.ReadKey();
            }
        }

        private static int Calculate(int[] arr, int x, int y, int startingValue)
        {
            if (arr == null ||
                x > y)
                return 0;
            int n1 = (int)Math.Truncate(ReverseFunction(startingValue, x));
            if (arr[n1 - 1] == x)
                n1--;
            int n2 = (int)Math.Truncate(ReverseFunction(startingValue, y));
            return n2 - n1;
        }

        private static int Function(int first, int n)
        {
            return (int)(first * Math.Pow(2, n));
        }
        private static decimal ReverseFunction(int first, int matchingValue)
        {
            return (decimal)Math.Log2(matchingValue / first) + 1;
        }
    }
}
