namespace Problem_04.Poker_Straight
{
    using System;

    internal class Program
    {
        private const int MinSumFaces = 550;
        private const int MaxSumFaces = 2050;
        private const int NextSumFaces = 150;
        private const int MinSumSuits = 5;
        private const int MaxSumSuits = 20;
        private const int CardsInStraight = 5;
        private const int SuitCount = 4;

        private static int suitCombinationsCount = 0;
        private static int weight;

        private static readonly int[] suitValues = { 1, 2, 3, 4 };
        private static void Main(string[] args)
        {
            weight = int.Parse(Console.ReadLine());
            if (weight <= MinSumFaces || weight >= MaxSumFaces)
            {
                Console.WriteLine(0);
                return;
            }

            weight -= MinSumFaces;
            while (weight >= NextSumFaces)
            {
                weight %= NextSumFaces;
            }

            if (weight < MinSumSuits || weight > MaxSumSuits)
            {
                Console.WriteLine(0);
                return;
            }

            CalculateNumberOfSuitCombinations(0, 0);
            Console.WriteLine(suitCombinationsCount);
        }

        private static void CalculateNumberOfSuitCombinations(int currentWeight,int index)
        {
            if (index == CardsInStraight)
            {
                if (currentWeight == weight)
                {
                    suitCombinationsCount++;
                }
            }

            for (var i = 0; i < SuitCount && currentWeight <= weight; i++)
            {
                currentWeight += suitValues[i];
                CalculateNumberOfSuitCombinations(currentWeight, index + 1);
                currentWeight -= suitValues[i];
            }
        }
    }
}
