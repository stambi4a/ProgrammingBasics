namespace Problem_01.Baba_TInche_Airlines
{
    using System;

    internal class Program
    {
        private const int FirstClassTicket = 7000;
        private const int BusinessClassTicket = 3500;
        private const int EconomyClassTicket = 1000;
        private const decimal MealPriceOfTicket = 0.005m;
        private const decimal FrequentFlyersDiscount = 0.70m;
        private const int FirstClassPassengers = 12;
        private const int BusinessClassPassengers = 28;
        private const int EconomyClassPassengers = 50;

        private static void Main(string[] args)
        {
            var maximalProfit = (int)((FirstClassPassengers * FirstClassTicket + BusinessClassPassengers * BusinessClassTicket
                                 + EconomyClassPassengers * EconomyClassTicket) * (1 + MealPriceOfTicket));

            var input = Console.ReadLine().Split();
            var firstClassPassengers = int.Parse(input[0]);
            var firstClassFrequentFlyers = int.Parse(input[1]);
            var firstClassMealPurchasers = int.Parse(input[2]);

            input = Console.ReadLine().Split();
            var businessClassPassengers = int.Parse(input[0]);
            var businessClassFrequentFlyers = int.Parse(input[1]);
            var businessClassMealPurchasers = int.Parse(input[2]);

            input = Console.ReadLine().Split();
            var economyClassPassengers = int.Parse(input[0]);
            var economyClassFrequentFlyers = int.Parse(input[1]);
            var economyClassMealPurchasers = int.Parse(input[2]);

            var firstClassTotalProfit = (firstClassPassengers - firstClassMealPurchasers - firstClassFrequentFlyers)
                                        * FirstClassTicket
                                        + firstClassMealPurchasers * FirstClassTicket * (1 + MealPriceOfTicket)
                                        + firstClassFrequentFlyers * FirstClassTicket * (1 - FrequentFlyersDiscount);

            var businessClassTotalProfit = (businessClassPassengers - businessClassMealPurchasers - businessClassFrequentFlyers)
                                        * BusinessClassTicket
                                        + businessClassMealPurchasers * BusinessClassTicket * (1 + MealPriceOfTicket)
                                        + businessClassFrequentFlyers * BusinessClassTicket * (1 - FrequentFlyersDiscount);

            var economyClassTotalProfit = (economyClassPassengers - economyClassMealPurchasers - economyClassFrequentFlyers)
                                        * EconomyClassTicket
                                        + economyClassMealPurchasers * EconomyClassTicket * (1 + MealPriceOfTicket)
                                        + economyClassFrequentFlyers * EconomyClassTicket * (1 - FrequentFlyersDiscount);

            var totalProfit = (int)(firstClassTotalProfit + businessClassTotalProfit + economyClassTotalProfit);
            Console.WriteLine(totalProfit);
            Console.WriteLine(maximalProfit - totalProfit);
        }
    }
}
