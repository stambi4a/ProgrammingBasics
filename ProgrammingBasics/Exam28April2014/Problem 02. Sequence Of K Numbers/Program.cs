namespace Problem_02.Sequence_Of_K_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var sequenceSize = int.Parse(Console.ReadLine());
            if (sequenceSize == 1)
            {
                return;
            }

            var newNumbers = new List<int>();
            var sizeCurrentSequence = 1;
            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    sizeCurrentSequence++;
                }

                else
                {
                    sizeCurrentSequence %= sequenceSize;

                    newNumbers.AddRange(Enumerable.Repeat(numbers[i - 1], sizeCurrentSequence));

                    sizeCurrentSequence = 1;
                }
            }

            sizeCurrentSequence %= sequenceSize;

            newNumbers.AddRange(Enumerable.Repeat(numbers[numbers.Length - 1], sizeCurrentSequence));

            Console.WriteLine(string.Join(" ", newNumbers));

        }
    }
}
