namespace ExamSchedule
{
    using System;

    internal class Program
    {
        private const int MinutesInHour = 60;
        private const int HoursInFormat = 12;
        private static void Main(string[] args)
        {
            int startingHour = int.Parse(Console.ReadLine());
            int startingMinutes = int.Parse(Console.ReadLine());
            string startingAmOrPm = Console.ReadLine();
            int durationHours = int.Parse(Console.ReadLine());
            int durationMinutes = int.Parse(Console.ReadLine());

            int endMinutes = startingMinutes + durationMinutes;
            int addhour = endMinutes / MinutesInHour;
            endMinutes %= MinutesInHour;
            int endHour = startingHour + addhour + durationHours;
            string endAmOrPm = startingAmOrPm;

            if (endHour >= HoursInFormat && endHour < 2 * HoursInFormat)
            {
                endAmOrPm = endAmOrPm.Equals("AM") ? "PM" : "AM";
            }

            if (endHour > HoursInFormat || endHour > 2 * HoursInFormat)
            {
                endHour %= HoursInFormat;
            }

            if (endHour == 2 * HoursInFormat)
            {
                endHour /= 2;
            }

            Console.WriteLine($"{endHour:d2}:{endMinutes:d2}:{endAmOrPm}");

        }
    }
}
