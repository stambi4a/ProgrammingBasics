namespace Problem_01.Torrent_Pirate
{
    using System;

    internal class Program
    {
        private const string PlaceToGoMessage = "{0} -> {1:f2}lv";
        private const string CinemaPlace = "cinema";
        private const string MallPlace = "mall";
        private const int SecondsInAnHour = 3600;  
        private const int SpeedPerSecond = 2;
        private const int DownloadedPerhour = SecondsInAnHour * SpeedPerSecond;
        private const int MovieSize = 1500;

        private static void Main(string[] args)
        {
            var contentSize = decimal.Parse(Console.ReadLine());
            var moviePrice = decimal.Parse(Console.ReadLine());
            var wifeSpentPerHour = decimal.Parse(Console.ReadLine());

            var moviesCount = contentSize / MovieSize;
            var cinemaTotalSpent = moviesCount * moviePrice;
            var hoursAtMall = contentSize / DownloadedPerhour;
            var totalWifeSpent = hoursAtMall * wifeSpentPerHour;

            var place = CinemaPlace;
            var moneySpent = cinemaTotalSpent;
            if (cinemaTotalSpent >= totalWifeSpent)
            {
                place = MallPlace;
                moneySpent = totalWifeSpent;
            }

            Console.WriteLine(PlaceToGoMessage, place, moneySpent);
        }
    }
}
