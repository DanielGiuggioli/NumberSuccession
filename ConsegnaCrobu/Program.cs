using System;

namespace CrobuComputationalComplexity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Values 'quantity', 'startingValue', 'x', and 'y' can be changed... pre-setted values are of default

            int quantity = 10;
            int startingValue = 3;
            var arr = new int[quantity];
            for (int v = 0; v < quantity; v++)
                arr[v] = Algorithm.Function(startingValue, v);
            int x = 1;
            int y = 10000;

            try
            {
                int result = Algorithm.Calculate(arr, x, y, startingValue);
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
    }
}
