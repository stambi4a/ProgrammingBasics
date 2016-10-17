namespace Problem_04.Morse_Code_Numbers
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private const int MorseCodeSequencesCount = 6;
        private const string MorseCodeSeparator = "|";

        private static List<string> morseCodeNumbers;
        private static Dictionary<int, string> morseCodeSequences;
        private static HashSet<string> sequencesMorseCodeNumbers;
        private static int sumDigits;

        private static void Main(string[] args)
        {
            morseCodeSequences = new Dictionary<int, string>()
                                         {
                                             { 0, "-----" },
                                             { 1, ".----" },
                                             { 2, "..---" },
                                             { 3, "...--" },
                                             { 4, "....-" },
                                             { 5, "....." }
                                         };

            morseCodeNumbers = new List<string>();
            sequencesMorseCodeNumbers = new HashSet<string>();
            var number = int.Parse(Console.ReadLine());
            sumDigits = 0;
            while (number > 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }

            GenerateMorseCodeSequences(0, 1);

            if (sequencesMorseCodeNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(MorseCodeSeparator + Environment.NewLine, sequencesMorseCodeNumbers) + MorseCodeSeparator);
                return;
            }
            Console.WriteLine("No");

        }

        private static void GenerateMorseCodeSequences(int index, int product)
        {
            if (index == MorseCodeSequencesCount)
            {
                if (product == sumDigits)
                {
                    sequencesMorseCodeNumbers.Add(string.Join(MorseCodeSeparator, morseCodeNumbers));
                }

                return;
            }

            for (var i = 1; i < MorseCodeSequencesCount; i++)
            {
                morseCodeNumbers.Add(morseCodeSequences[i]);
                GenerateMorseCodeSequences(index + 1, product * i);
                morseCodeNumbers.RemoveAt(morseCodeNumbers.Count - 1);
            }
        }
    }
}
