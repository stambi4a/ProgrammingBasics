namespace Problem04.Magic_Strings
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Security.Cryptography;
    using System.Xml.Schema;

    internal class Program
    {
        private const int MaxDiff = 16;
        private const int MaxSetWeight = 20;
        private const int MinSetWeight = 4;
        private const int SetLength = 4;

        private static char[] originalSequence;
        private static List<string> supplementSets;
        private static List<string> sets;
        private static Dictionary<char, int> weights;
        private static int diff;

        private static void Main(string[] args)
        {
            originalSequence = new[] { 'k', 'n', 'p', 's' };
            supplementSets = new List<string>();
            sets = new List<string>();
            weights = new Dictionary<char, int>()
                          {
                              { 'k', 1 },
                              { 'n', 4 },
                              { 'p', 5 },
                              { 's', 3 }
                          };

            diff = int.Parse(Console.ReadLine());
            if (diff > MaxDiff)
            {
                Console.WriteLine("No");
            }

            char[] sequence = new char[2 * SetLength];
            GenerateSequencies(sequence, 0);

            foreach (var set in sets)
            {
                Console.WriteLine(set);
            }

           /* using (StreamWriter sw = new StreamWriter("test.txt"))
            {
                foreach (var set in sets)
                {
                    sw.WriteLine(set);
                }
            }*/
               
        }

        private static void GenerateSequencies(char[] sequence, int index)
        {
            if (index == sequence.Length)
            {
                if(CheckWeightDifferencebetweenSets(sequence))
                {
                    sets.Add(new string(sequence));
                }

                return;
            }

            for (int i = 0; i < SetLength; i++)
            {
                sequence[index] = originalSequence[i];
                GenerateSequencies(sequence, index + 1);
            }
        }

        private static bool CheckWeightDifferencebetweenSets(char[] sequence)
        {
            int leftSetWeight = 0;

            for (int i = 0; i < SetLength; i++)
            {
                leftSetWeight += weights[sequence[i]];
            }

            int rightSetWeight = 0;

            for (int i = 0; i < SetLength; i++)
            {
                rightSetWeight += weights[sequence[i + SetLength]];
            }

            if (leftSetWeight == rightSetWeight + diff || leftSetWeight == rightSetWeight - diff)
            {
                return true;
            }

            return false;
        }
        /*private static void GenerateSequencies(char[] sequence, int index, int currentWeight)
        {
            if (index == sequence.Length)
            {
                string leftSet = new string(sequence);

                int givenWeight = currentWeight - diff;
                if (givenWeight >= MinSetWeight)
                {
                    GenerateSequenciesForGivenWeight(new char[SetLength], 0, 0, currentWeight - diff);
                    foreach (var set in supplementSets)
                    {
                        sets.Add(leftSet + set);
                    }

                    supplementSets.Clear();
                }

                GenerateSequenciesForGivenWeight(new char[SetLength], 0, 0, currentWeight + diff);
                foreach (var set in supplementSets)
                {
                    sets.Add(leftSet + set);
                }

                supplementSets.Clear();

               
                
                return;
            }

            if (currentWeight >= MaxSetWeight)
            {
                return;
            }

            for (int i = 0; i < SetLength; i++)
            {
                char ch = originalSequence[i];
                sequence[index] = ch;
                GenerateSequencies(sequence, index + 1, currentWeight + weights[ch]);
            }
        }

        private static void GenerateSequenciesForGivenWeight(char[] sequence, int index, int currentWeight, int givenWeight)
        {
            if (index == SetLength)
            {
                if (currentWeight == givenWeight)
                {
                    supplementSets.Add(new string(sequence));
                }
               
                return;
            }

            if (currentWeight >= givenWeight)
            {
                return;
            }

            for (int i = 0; i < SetLength; i++)
            {
                char ch = originalSequence[i];
                sequence[index] = ch;
                GenerateSequenciesForGivenWeight(sequence, index + 1, currentWeight + weights[ch], givenWeight);
            }
        }*/
    }
}
