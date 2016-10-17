namespace Problem_02.Odd_Or_Even_Counter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private const string MostNumbersMessage = "{0} set has the most {1} numbers: {2}";
        private static void Main(string[] args)
        {
            var ordinalNumbers = new Dictionary<int, string>()
                                     {
                                         { 1, "First" },
                                         { 2, "Second" },
                                         { 3, "Third" },
                                         { 4, "Fourth" },
                                         { 5, "Fifth" },
                                         { 6, "Sixth" },
                                         { 7, "Seventh" },
                                         { 8, "Eighth" },
                                         { 9, "Ninth" },
                                         { 10, "Tenth" }
                                     };
            var setCount = int.Parse(Console.ReadLine());
            var setSize = int.Parse(Console.ReadLine());
            var numberType = Console.ReadLine();

            var sets = new int[setCount][];
            for (var i = 0; i < setCount; i++)
            {
                sets[i] = new int[setSize];
                for (var j = 0; j < setSize; j++)
                {
                    sets[i][j] = int.Parse(Console.ReadLine());
                }
            }

            var maxCountNumbers = 0;
            var maxCountSetIndex = 0;
            for (var i = 0; i < setCount; i++)
            {
                if(numberType.Equals("odd"))
                {
                    var currentCount = sets[i].Where(x => x % 2 == 1).Count();
                    if (currentCount <= maxCountNumbers)
                    {
                        continue;
                    }

                    maxCountNumbers = currentCount;
                    maxCountSetIndex = i;
                }
                else
                {
                    var currentCount = sets[i].Where(x => x % 2 == 0).Count();
                    if (currentCount <= maxCountNumbers)
                    {
                        continue;
                    }

                    maxCountNumbers = currentCount;
                    maxCountSetIndex = i;
                }
            }

            if (maxCountNumbers > 0)
            {
                Console.WriteLine(MostNumbersMessage, ordinalNumbers[maxCountSetIndex + 1], numberType, maxCountNumbers);
                return;
            }

            Console.WriteLine("No");
        }
    }
}
