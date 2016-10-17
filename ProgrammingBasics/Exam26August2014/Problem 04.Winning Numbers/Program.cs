namespace Problem_04.Winning_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private const int DigitsInThreeDigitNumber = 3;
        private const int MinDigit = 1;
        private const int MaxDigit = 9;
        private const int ProductInitialValue = 1;

        private static int letSum;
        private static int[] threeDigitNumber;
        private static SortedSet<string> winningNumbers;
        private static List<string> permutations;

        private static void Main(string[] args)
        {
            winningNumbers = new SortedSet<string>();
            permutations = new List<string>();
            var input = Console.ReadLine().ToLower();
            letSum = input.Sum(ch => ch - 'a' + 1);
            threeDigitNumber = new int[DigitsInThreeDigitNumber];
            FindThreeDigitNumbers(MinDigit, 0, ProductInitialValue);
            GenerateWinningNumbers();

            if (winningNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, winningNumbers));
                return;
            }

            Console.WriteLine("No");
        }

        private static void FindThreeDigitNumbers(int digit, int index, int digitProduct)
        {
            if (index == DigitsInThreeDigitNumber)
            {
                if (digitProduct == letSum)
                {
                    GenerateNumberPermutations();
                }

                return;
            }

            for (var i = MinDigit; i <= MaxDigit && digitProduct <= letSum; i++)
            {
                threeDigitNumber[index] = i;
                FindThreeDigitNumbers(digit, index + 1, digitProduct * i);
            } 
        }

        private static void GenerateNumberPermutations()
        {
            permutations.Add((threeDigitNumber[0] * 100 + threeDigitNumber[1] * 10
                                       + threeDigitNumber[2]).ToString());
            permutations.Add((threeDigitNumber[0] * 100 + threeDigitNumber[2] * 10
                                       + threeDigitNumber[1]).ToString());
            permutations.Add((threeDigitNumber[1] * 100 + threeDigitNumber[0] * 10
                                       + threeDigitNumber[2]).ToString());
            permutations.Add((threeDigitNumber[1] * 100 + threeDigitNumber[2] * 10
                                       + threeDigitNumber[0]).ToString());
            permutations.Add((threeDigitNumber[2] * 100 + threeDigitNumber[0] * 10
                                       + threeDigitNumber[1]).ToString());
            permutations.Add((threeDigitNumber[2] * 100 + threeDigitNumber[1] * 10
                                       + threeDigitNumber[0]).ToString());
        }

        private static void GenerateWinningNumbers()
        {
            var permCount = permutations.Count;
            for (var i = 0; i < permCount; i++)
            {
                for (var j = 0; j < permCount; j++)
                {
                    winningNumbers.Add(permutations[i] + '-' + permutations[j]);
                }
            }
        }
    }
}
