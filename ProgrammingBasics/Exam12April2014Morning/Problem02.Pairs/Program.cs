namespace Problem02.Pairs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var pairValues = new List<int>();
            for (int i = 0; i < numbers.Length; i = i + 2)
            {
                pairValues.Add(numbers[i] + numbers[i + 1]);
            }

            int minPairValue = pairValues.Min();
            int maxPairValue = pairValues.Max();

            if (minPairValue == maxPairValue)
            {
                Console.WriteLine("Yes, value=" + maxPairValue);
                return;
            }

            var maxDifferences = new List<int>();
            for (int i = 1; i < pairValues.Count; i++)
            {
                maxDifferences.Add(Math.Abs(pairValues[i] - pairValues[i - 1]));
            }

            int maxPairDifference = maxDifferences.Max();
            Console.WriteLine("No, maxdiff=" + maxPairDifference);
            return;
        }
    }
}
