namespace Problem_04.Nakovs_Matching
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private const string MatchResult = "({0}|{1}) matches ({2}|{3}) by {4} nakovs";
        private static void Main(string[] args)
        {
            var results = new List<string>();

            var first = Console.ReadLine();
            var second = Console.ReadLine();
            var maxWeightDifference = int.Parse(Console.ReadLine());

            var lengthFirst = first.Length;
            var lengthSecond = second.Length;

            for (var i = 1; i < lengthFirst; i++)
            {
                var firstLeft = first.Substring(0, i);
                var firstRight = first.Substring(i, lengthFirst - i);

                var weightFirstLeft = firstLeft.Sum(x => x);
                var weightFirstRight = firstRight.Sum(x => x);

                for (var j = 1; j < lengthSecond; j++)
                {
                    var secondLeft = second.Substring(0, j);
                    var secondRight = second.Substring(j, lengthSecond - j);
                    var weightSecondLeft = secondLeft.Sum(x => x);
                    var weightSecondRight = secondRight.Sum(x => x);

                    var firstWeights = weightFirstLeft * weightSecondRight;
                    var secondWeights = weightSecondLeft * weightFirstRight;

                    var weightDifference = Math.Abs(firstWeights - secondWeights);
                    if (weightDifference <= maxWeightDifference)
                    {
                        results.Add(string.Format(MatchResult, firstLeft, firstRight, secondLeft, secondRight, weightDifference));
                    }
                }
            }

            if (results.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, results));
                return;
            }

            Console.WriteLine("No");
        }
    }
}
