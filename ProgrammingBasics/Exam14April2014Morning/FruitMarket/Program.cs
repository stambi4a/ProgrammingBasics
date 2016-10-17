using System.Collections.Generic;

namespace FruitMarket
{
    using System;
    using System.Globalization;
    using System.Threading;

    class Program
    {
        private const int CountLines = 3;
        private static Dictionary<string, decimal> productPrices;
        private static Dictionary<string, decimal> productQuantities;
        private static Dictionary<string, decimal> priceReductionWeekdays;
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            productPrices = new Dictionary<string, decimal>();
            productQuantities = new Dictionary<string, decimal>();
            priceReductionWeekdays = new Dictionary<string, decimal>();

            productPrices.Add("banana", 1.80m);
            productPrices.Add("cucumber", 2.75m);
            productPrices.Add("tomato", 3.20m);
            productPrices.Add("orange", 1.60m);
            productPrices.Add("apple", 0.86m);

            priceReductionWeekdays.Add("Friday", 0.10m);
            priceReductionWeekdays.Add("Sunday", 0.05m);
            priceReductionWeekdays.Add("Tuesday", 0.20m);
            priceReductionWeekdays.Add("Wednesday", 0.10m);
            priceReductionWeekdays.Add("Thursday", 0.30m);

            productQuantities.Add("banana", 0);
            productQuantities.Add("cucumber", 0);
            productQuantities.Add("tomato", 0);
            productQuantities.Add("orange", 0);
            productQuantities.Add("apple", 0);

            string day = Console.ReadLine();
            decimal totalSum = 0;
            for (int i = 1; i <= CountLines; i++)
            {
                string input = Console.ReadLine();
                decimal quantity = decimal.Parse(input);
                string product = Console.ReadLine();
                productQuantities[product] += quantity;
            }

            ApplyDayPriceReduction(day);
            foreach (var product in productQuantities.Keys)
            {
                totalSum += productPrices[product] * productQuantities[product];
            }

            Console.WriteLine($"{totalSum:f2}");
        }

        private static void ApplyDayPriceReduction(string day)
        {
            switch (day)
            {
                case "Friday":
                    {
                        foreach (var product in productQuantities.Keys)
                        {
                            productPrices[product] *= (1m - priceReductionWeekdays[day]);
                        }
                    }

                    break;
                case "Sunday":
                    {
                        foreach (var product in productQuantities.Keys)
                        {
                            productPrices[product] *= (1m - priceReductionWeekdays[day]);
                        }
                    }

                    break;
                case "Tuesday":
                    {
                        productPrices["banana"] *= (1m -priceReductionWeekdays[day]);
                        productPrices["apple"] *= (1m - priceReductionWeekdays[day]);
                        productPrices["orange"] *= (1m - priceReductionWeekdays[day]);
                    }

                    break;
                case "Wednesday":
                    {
                        productPrices["cucumber"] *= (1m - priceReductionWeekdays[day]);
                        productPrices["tomato"] *= (1m - priceReductionWeekdays[day]);
                    }

                    break;
                case "Thursday":
                    {
                        productPrices["banana"] *= (1m - priceReductionWeekdays[day]);
                    }

                    break;
            }
        }
    }
}

