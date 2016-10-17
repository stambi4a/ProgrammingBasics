namespace Problem_02.Book_Orders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Threading;

    internal class Program
    {  
        private const int MinimumPacketsMaximumDiscount = 110;

        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var discounts = new Dictionary<int, decimal>()
                                {
                                    { 0, 0 },
                                    { 1, 0.05m },
                                    { 2, 0.06m },
                                    { 3, 0.07m },
                                    { 4, 0.08m },
                                    { 5, 0.09m },
                                    { 6, 0.10m },
                                    { 7, 0.11m },
                                    { 8, 0.12m },
                                    { 9, 0.13m },
                                    { 10, 0.14m },
                                    { 11, 0.15m }
                                };

            var orderCount = int.Parse(Console.ReadLine());
            var totalSum = 0.0;
            var boughtBooks = 0;
            for (var i = 1; i <= orderCount; i++)
            {
                var packets = int.Parse(Console.ReadLine());
                var booksInAPacket = int.Parse(Console.ReadLine());
                var currentOrderBoughtBooks = packets * booksInAPacket;
                boughtBooks += currentOrderBoughtBooks;
                var bookPrice = double.Parse(Console.ReadLine());
                packets = packets > MinimumPacketsMaximumDiscount ? MinimumPacketsMaximumDiscount : packets;
                var discount = discounts[packets / 10];
                var totalOrderSum = currentOrderBoughtBooks * bookPrice * (double)(1 - discount);
                totalSum += totalOrderSum;
            }

            Console.WriteLine(boughtBooks + Environment.NewLine + $"{totalSum:f2}");
        }
    }
}
