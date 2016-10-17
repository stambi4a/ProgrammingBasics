namespace Problem_04.Gambling
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    internal class Program
    {
        private const string Draw = "DRAW";
        private const string Fold = "FOLD";
        private const int DrawnCards = 4;
        private const int MinFaceValue = 2;
        private const int MaxFaceValue = 14;
        private const int CardsInASuit = 13;

        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var faceValues = new Dictionary<string, int>()
                                 {
                                     { "2", 2 },
                                     { "3", 3 },
                                     { "4", 4 },
                                     { "5", 5 },
                                     { "6", 6 },
                                     { "7", 7 },
                                     { "8", 8 },
                                     { "9", 9 },
                                     { "10", 10 },
                                     { "J", 11 },
                                     { "Q", 12 },
                                     { "K", 13 },
                                     { "A", 14 }
                                 };

            var budget = double.Parse(Console.ReadLine());
            var cards = Console.ReadLine().Split();
            var houseValue = 0;
            for (var i = 0; i < DrawnCards; i++)
            {
                houseValue += faceValues[cards[i]];
            }

            var handsBiggerThanHouseValue = 0;
            for (var i = MinFaceValue; i <= MaxFaceValue; i++)
            {
                for (var j = MinFaceValue; j <= MaxFaceValue; j++)
                {
                    for (var k = MinFaceValue; k <= MaxFaceValue; k++)
                    {
                        for (var l = MinFaceValue; l <= MaxFaceValue; l++)
                        {
                            if (i + j + k + l > houseValue)
                            {
                                handsBiggerThanHouseValue++;
                            }
                        }
                    }
                }
            }

            var probability = handsBiggerThanHouseValue / (Math.Pow(CardsInASuit, DrawnCards));
            var probableWinnings = 2 * probability * budget;
            Console.WriteLine(probability < 0.50 ? Fold : Draw);
            Console.WriteLine($"{probableWinnings:f2}");
        }
    }
}
