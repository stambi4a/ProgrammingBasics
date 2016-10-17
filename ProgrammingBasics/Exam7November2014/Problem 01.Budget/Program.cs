namespace Problem_01.Budget
{
    using System;

    internal class Program
    {
        private const int RentAmount = 150;
        private const int WeekdaysCount = 22;
        private const int WeekendsInAMonth = 4;
        private const int WeekdaySpending = 10;
        private const int WeekendSpendingPerDay = 20;
        private const int DaysInAWeekend = 2;
        private const decimal GoesOutSpendPercentage = 0.03m;
        private const string LeftoverMessage = "Yes, leftover {0}.";
        private const string NotEnoughMessage = "No, not enough {0}.";
        private const string ExactBudgetMessage = "Exact Budget.";

        private static void Main(string[] args)
        {
            var budget = int.Parse(Console.ReadLine());
            var weekdaysOut = int.Parse(Console.ReadLine());
            var weekendsInHometown = int.Parse(Console.ReadLine());

            var weekdaySpendingOut = (int)(GoesOutSpendPercentage * budget);

            var totalSpentMoney = RentAmount;
            totalSpentMoney += WeekdaysCount * WeekdaySpending;
            totalSpentMoney += weekdaysOut * weekdaySpendingOut;
            totalSpentMoney += (WeekendsInAMonth - weekendsInHometown) * DaysInAWeekend * WeekendSpendingPerDay;

            var leftMoney = budget - totalSpentMoney;
            if (leftMoney > 0)
            {
                Console.WriteLine(LeftoverMessage, leftMoney);
            }

            if (leftMoney < 0)
            {
                Console.WriteLine(NotEnoughMessage, -leftMoney);
            }

            if (leftMoney == 0)
            {
                Console.WriteLine(ExactBudgetMessage);
            }
        }
    }
}
