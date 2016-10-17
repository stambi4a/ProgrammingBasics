namespace Problem04.MagicDates
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int startYear = int.Parse(Console.ReadLine());
            int endYear = int.Parse(Console.ReadLine());
            var magicDates = new List<string>();
            int weight = int.Parse(Console.ReadLine());

            DateTime startDate = new DateTime(startYear, 1, 1);
            DateTime endDate = new DateTime(endYear, 12, 31);
            List<int> digits = new List<int>(8);
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                digits.Clear();
                int days = date.Day;
                while (days > 0)
                {
                    digits.Add(days % 10);
                    days /= 10;
                }

                int month = date.Month;
                while (month > 0)
                {
                    digits.Add(month % 10);
                    month /= 10;
                }

                int year = date.Year;
                while (year > 0)
                {
                    digits.Add(year % 10);
                    year /= 10;
                }

                digits = digits.Where(x => x != 0).ToList();
                int currentWeight = 0;
                for (int i = 0; i < digits.Count - 1; i++)
                {
                    for (int j = i + 1; j < digits.Count; j++)
                    {
                        currentWeight += digits[i] * digits[j];
                    }
                }

                if (currentWeight == weight)
                {
                    magicDates.Add(date.ToString("dd-MM-yyyy"));
                }
            }

            if (magicDates.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine(string.Join(Environment.NewLine, magicDates));
        }
    }
}
