namespace Cinema
{
    using System;
    using System.Globalization;
    using System.Threading;

    internal class Program
    {
        private const decimal Premier = 12m;
        private const decimal Normal = 7.5m;
        private const decimal Discount = 5m;

        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            int seats = rows * columns;
            decimal ticketPrice = 0;
            switch (projectionType)
            {
                case "Premiere":
                    {
                        ticketPrice = Premier;
                    }

                    break;


                case "Normal":
                    {
                        ticketPrice = Normal;
                    }

                    break;


                case "Discount":
                    {
                        ticketPrice = Discount;
                    }

                    break;
            }

            decimal totalWinnings = seats * ticketPrice;
            Console.WriteLine($"{totalWinnings:f2} leva");
        }
    }
}
