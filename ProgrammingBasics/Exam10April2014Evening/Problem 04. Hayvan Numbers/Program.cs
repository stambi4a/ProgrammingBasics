namespace Problem_04.Hayvan_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const int MinSum = 45;
        private const int MaxSum = 81;
        private const int MinDifference = 0;
        private const int MaxDifference = 222;
        private const int MinDigit = 5;
        private const int MaxDigit = 9;
        private const int Hundred = 100;
        private const int Ten = 10;
        private const int Thousand = 1000;

        private static void Main(string[] args)
        {
            var hayvanNumbers = new List<string>();
            var sum = int.Parse(Console.ReadLine());
            if (sum < MinSum || sum > MaxSum)
            {
                Console.WriteLine("No");
                return;
            }

            var difference = int.Parse(Console.ReadLine());
            if (difference < MinDifference || difference > MaxDifference)
            {
                Console.WriteLine("No");
                return;
            }

            for (var i = MinDigit; i <= MaxDigit; i++)
            {
                for (var j = MinDigit; j <= MaxDigit; j++)
                {
                    for (var k = MinDigit; k <= MaxDigit; k++)
                    {
                        var hayvanNumber = new StringBuilder();
                        var sumDigits = i + j + k;
                        var firstNum = i * Hundred + j * Ten + k;
                        hayvanNumber.Append(firstNum);
                        var secondNum = firstNum + difference;
                        hayvanNumber.Append(secondNum);
                        var thirdNum = secondNum + difference;
                        hayvanNumber.Append(thirdNum);

                        if (secondNum >= Thousand || thirdNum >= Thousand)
                        {
                            continue;
                        }

                        while (secondNum > 0)
                        {
                            var digit = secondNum % 10;
                            if (digit < MinDigit)
                            {
                                break;
                            }

                            sumDigits += digit;
                            secondNum /= Ten;
                        }

                        if (secondNum > 0)
                        {
                            continue;
                        }

                        while (thirdNum > 0)
                        {
                            var digit = thirdNum % 10;
                            if (digit < MinDigit)
                            {
                                break;
                            }

                            sumDigits += digit;
                            thirdNum /= Ten;
                        }

                        if (thirdNum > 0)
                        {
                            continue;
                        }

                        if (sumDigits == sum)
                        {
                            hayvanNumbers.Add(hayvanNumber.ToString());
                        }
                    }
                }
            }

            if (hayvanNumbers.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(Environment.NewLine, hayvanNumbers));
        }
    }
}
