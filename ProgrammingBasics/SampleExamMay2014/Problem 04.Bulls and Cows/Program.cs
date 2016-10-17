namespace Problem_04.Bulls_and_Cows
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private const int NumberLength = 4;
        private const int Thousand = 1000;
        private const int Hundred = 100;
        private const int Ten = 10;
        private const int MinDigit = 1;
        private const int MaxDigit = 9;

        private static void Main(string[] args)
        {
            var guessNumbers = new List<int>();
            var secretNumber = int.Parse(Console.ReadLine());
            var bulls = int.Parse(Console.ReadLine());
            var cows = int.Parse(Console.ReadLine());

            var digits = new int[NumberLength];
            digits[0] = secretNumber / Thousand;
            digits[1] = secretNumber % Thousand / Hundred;
            digits[2] = secretNumber % Thousand % Hundred / Ten;
            digits[3] = secretNumber % Ten;
            var digitSet = new List<int> { digits[0], digits[1], digits[2], digits[3] };
            for (var i = MinDigit; i <= MaxDigit; i++)
            {
                for (var j = MinDigit; j <= MaxDigit; j++)
                {
                    for (var k = MinDigit; k <= MaxDigit; k++)
                    {
                        for (var l = MinDigit; l <= MaxDigit; l++)
                        {
                            var currentBulls = 0;
                            var currentDigits = new List<int> (digitSet);

                            if (l == digits[3])
                            {
                                currentBulls++;
                            }
                           
                            if (k == digits[2])
                            {
                                currentBulls++;
                            }
                            
                            if (j == digits[1])
                            {
                                currentBulls++;
                            }
                            
                            if (i == digits[0])
                            {
                                currentBulls++;
                            }

                            var currentCows = 0;
                            var index = currentDigits.IndexOf(i);
                            if (index >= 0)
                            {
                                currentCows++;
                                currentDigits[index] = 0;
                            }

                            index = currentDigits.IndexOf(j);
                            if (index >= 0)
                            {
                                currentCows++;
                                currentDigits[index] = 0;
                            }

                            index = currentDigits.IndexOf(k);
                            if (index >= 0)
                            {
                                currentCows++;
                                currentDigits[index] = 0;
                            }

                            index = currentDigits.IndexOf(l);
                            if (index >= 0)
                            {
                                currentCows++;
                                currentDigits[index] = 0;
                            }
                            
                            currentCows -= currentBulls;

                            if (currentCows != cows || currentBulls != bulls)
                            {
                                continue;
                            }

                            var guessNumber = i * Thousand + j * Hundred + k * Ten + l;
                            guessNumbers.Add(guessNumber);
                        }
                    }
                }
            }

            if (guessNumbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", guessNumbers));
                return;
            }

            Console.WriteLine("No");
        }
    }
}
