namespace FiveSpecialLetters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        private const int CharArrayLength = 5;

        private static Dictionary<char, int> lettersWeight;
        private static List<string> sequencies;

        private static char[] originalSequence;
        private static int startNumber;
        private static int endNumber;
        static void Main(string[] args)
        {
            lettersWeight = new Dictionary<char, int>
                                {
                                    { 'a', 5 },
                                    { 'b', -12 },
                                    { 'c', 47 },
                                    { 'd', 7 },
                                    { 'e', -32 }
                                };
            sequencies = new List<string>();
            originalSequence = new[] { 'a', 'b', 'c', 'd', 'e' };
            startNumber = int.Parse(Console.ReadLine());
            endNumber = int.Parse(Console.ReadLine());
            char[] sequence = new char[CharArrayLength];
            GenerateSequenciesRecursion(sequence, 0);
            if (sequencies.Count > 0)
            {
                Console.WriteLine(string.Join(" ", sequencies));
                return;
            }

            Console.WriteLine("No");
        }

        private static void GenerateSequenciesRecursion(char[] sequence, int index)
        {
            if (index == CharArrayLength)
            {
                int sequenceTotalWeight = CalculateWeightOfSequence(sequence);
                if (sequenceTotalWeight >= startNumber && sequenceTotalWeight <= endNumber)
                {
                    sequencies.Add(new string(sequence));
                }

                return;
            }

            for (int i = 0; i < CharArrayLength; i++)
            {
                sequence[index] = originalSequence[i];
                GenerateSequenciesRecursion(sequence, index + 1);
            }
        }

        private static int CalculateWeightOfSequence(char[] sequence)
        {
            var totalWeight = 0;
            var distinctLetters = sequence.Distinct().ToArray();

            for (int i = 0; i < distinctLetters.Length; i++)
            {
                totalWeight += (i + 1) * lettersWeight[distinctLetters[i]];
            }

            return totalWeight;
        }
    }
}
