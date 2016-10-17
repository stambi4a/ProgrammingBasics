namespace Volleyball
{
    using System;

    internal class Program
    {
        private const int WeekendsInAYear = 48;
        private static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var holidayCount = int.Parse(Console.ReadLine());
            var weekendCount = int.Parse(Console.ReadLine());
            double totalPlays = 0;
            totalPlays += weekendCount;
            totalPlays += (double)(WeekendsInAYear - weekendCount) * 3 / 4;
            totalPlays += (double)holidayCount * 2 / 3;
            if (yearType.Equals("leap"))
            {
                totalPlays += 0.15 * totalPlays;
            }

            Console.WriteLine((int)totalPlays);
        }
    }
}
