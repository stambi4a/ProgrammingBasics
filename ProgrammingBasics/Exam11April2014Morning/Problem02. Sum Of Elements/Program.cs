namespace Problem02.Sum_Of_Elements
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            long[] numbers = Console.ReadLine().Split().Select(long.Parse).ToArray();

            long sumElements = numbers.Sum();
            bool elementIsFound = false;
            long minDifference = long.MaxValue;
            long element = 0;
            foreach (long number in numbers)
            {
                long difference = Math.Abs(sumElements - 2 * number);
                if (difference == 0)
                {
                    elementIsFound = true;
                    element = number;
                    break;
                }

                if (difference < minDifference)
                {
                    minDifference = difference;
                }
            }

            if (elementIsFound)
            {
                Console.WriteLine($"Yes, sum={element}");
                return;
            }

            Console.WriteLine($"No, diff={minDifference}");
        }
    }
}
