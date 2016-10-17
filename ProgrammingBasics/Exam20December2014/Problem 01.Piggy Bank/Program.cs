namespace Problem_01.Piggy_Bank
{
    using System;

    internal class Program
    {
        private const int DepositMoney = 2;
        private const int PartyMoney = 5;
        private const int DaysInAMonth = 30;
        private const int MonthsInAYear = 12;
        private const string ResultMessage = "{0} years, {1} months";
        private static void Main(string[] args)
        {
            var tankPrice = int.Parse(Console.ReadLine());
            var partyDaysInAMonth = int.Parse(Console.ReadLine());
            var spentMoneyInAMonth = partyDaysInAMonth * PartyMoney;
            var depositedMoneyInAMonth = (DaysInAMonth - partyDaysInAMonth) * DepositMoney;
            var savedMoneyInAMonth = depositedMoneyInAMonth - spentMoneyInAMonth;
            if (savedMoneyInAMonth <= 0)
            {
                Console.WriteLine("never");
                return;
            }

            var months = (int)(Math.Ceiling(tankPrice / (double)savedMoneyInAMonth));
            var yearsToSave = months / MonthsInAYear;
            var monthsToSAve = months % MonthsInAYear;
            Console.WriteLine(ResultMessage, yearsToSave, monthsToSAve);
        }
    }
}
