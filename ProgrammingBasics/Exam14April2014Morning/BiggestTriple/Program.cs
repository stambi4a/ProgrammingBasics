namespace BiggestTriple
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int length = numbers.Length;
            int triplesCount = length / 3;
            int maxSum = int.MinValue;
            int indexTriple = 0;
            for (int i = 0; i < triplesCount; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    sum += numbers[i * 3 + j];
                }

                if (sum > maxSum)
                {
                    maxSum = sum;
                    indexTriple = i;
                }
            }

            int sumEndNumbers = 0;
            int k = 0;
            while (triplesCount * 3 + k < length)
            {
                sumEndNumbers += numbers[triplesCount * 3 + k];
                k++;
            }
            
            if (triplesCount * 3 < length && sumEndNumbers > maxSum)
            {
                indexTriple = triplesCount;
            }

            List<int> maxTriple = new List<int>();
            maxTriple.Add(numbers[indexTriple * 3]);
            if (indexTriple * 3 < length - 1)
            {
                maxTriple.Add(numbers[indexTriple * 3 + 1]);
            }

            if (indexTriple * 3 < length - 2)
            {
                maxTriple.Add(numbers[indexTriple * 3 + 2]);
            }

            Console.WriteLine(string.Join(" ", maxTriple));
        }
    }
}
