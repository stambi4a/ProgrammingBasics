namespace Problem01.Work_Hours
{
    using System;

    internal class Program
    {
        private const int WorkHoursPerDay = 12;
        private const double TimeSpentAtWorkInPercents = 0.9;
        private static void Main(string[] args)
        {
            int requiredHours = int.Parse(Console.ReadLine());
            int workingDays = int.Parse(Console.ReadLine());
            double workEfficiency = double.Parse(Console.ReadLine()) / 100;

            int workHours = (int)(workingDays * WorkHoursPerDay * TimeSpentAtWorkInPercents * workEfficiency);
            if (workHours >= requiredHours)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

            Console.WriteLine(workHours - requiredHours);
        }
    }
}
