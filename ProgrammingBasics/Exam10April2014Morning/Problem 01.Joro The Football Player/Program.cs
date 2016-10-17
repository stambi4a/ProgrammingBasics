namespace Problem_01.Joro_The_Football_Player
{
    using System;

    internal class Program
    {
        private const int WeekendsInAYear = 52;
        private static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var holidayCount = int.Parse(Console.ReadLine());
            var weekendCount = int.Parse(Console.ReadLine());
            double totalPlays = 0;
            totalPlays += weekendCount;
            totalPlays += (double)(WeekendsInAYear - weekendCount) * 2 / 3;
            totalPlays += (double)holidayCount * 1 / 2;
            if (yearType.Equals("t"))
            {
                totalPlays += 3;
            }

            Console.WriteLine((int)totalPlays);
        }
    }
}
