namespace Problem_01.Traveller_Bob
{
    using System;
    using System.Runtime.InteropServices;

    internal class Program
    {
        private const int WeeksInAMonth = 4;
        private const int MonthsInAYear = 12;
        private const decimal NormalMonthTavelDecrease = 0.40m;
        private const int TravelsInAContractWeek = 3;
        private const int TravelsInAFamilyWeek = 2;
        private const int TravelWeeksInFamilyMonth = 2;
        private const decimal OverallTravelIncreaeInAleapYear = 0.05m;

        private static void Main(string[] args)
        {
            var yearType = Console.ReadLine();
            var travelsInAContractMonth = TravelsInAContractWeek * WeeksInAMonth;
            var travelsInAFamilyMonth = TravelsInAFamilyWeek * TravelWeeksInFamilyMonth;
            var travelsInANormalMonth = travelsInAContractMonth * (1 - NormalMonthTavelDecrease);
            var contractMonths = int.Parse(Console.ReadLine());
            var familyMonths = int.Parse(Console.ReadLine());

            var overallTravels = travelsInAContractMonth * contractMonths + travelsInAFamilyMonth * familyMonths
                                 + travelsInANormalMonth * (MonthsInAYear - contractMonths - familyMonths);
            if (yearType.Equals("leap"))
            {
                overallTravels *= (1 + OverallTravelIncreaeInAleapYear);
            }

            Console.WriteLine((int)overallTravels);
        }
    }
}
