namespace Problem_01.Melons_And_Watermelons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Principal;

    internal class Program
    {
        private const int DaysInAWeek = 7;
        private static void Main(string[] args)
        {         
            var fruitsWeekDays = new Dictionary<int, Tuple<int, int>>()
                                 {
                                     { 1, new Tuple<int, int>(1, 0) },
                                     { 2, new Tuple<int, int>(0, 2) },
                                     { 3, new Tuple<int, int>(1, 1) },
                                     { 4, new Tuple<int, int>(2, 0) },
                                     { 5, new Tuple<int, int>(2, 2) },
                                     { 6, new Tuple<int, int>(1, 2) },
                                     { 7, new Tuple<int, int>(0, 0) }
                                 };

            var startingDay = int.Parse(Console.ReadLine());
            var duration = int.Parse(Console.ReadLine());
            var days = duration % DaysInAWeek;
            var melonCount = 0;
            var watermelonCount = 0;
            for (var i = startingDay; i < startingDay + days; i++)
            {
                var j = i % DaysInAWeek == 0 ? 7 : i % DaysInAWeek;
                melonCount += fruitsWeekDays[j].Item2;
                watermelonCount += fruitsWeekDays[j].Item1;
            }

            var difference = watermelonCount - melonCount;
            if (difference < 0)
            {
                Console.WriteLine($"{-difference} more melons");
                return;
            }

            if (difference > 0)
            {
                Console.WriteLine($"{difference} more watermelons");
                return;
            }

            var weekCount = duration / DaysInAWeek;
            var melonsInAWeek = fruitsWeekDays.Values.Sum(fruit => fruit.Item2);
            melonCount += melonsInAWeek * weekCount;
            Console.WriteLine($"Equal amount: {melonCount}");
        }
    }
}
