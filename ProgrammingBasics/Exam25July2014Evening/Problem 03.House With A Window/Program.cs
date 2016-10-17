namespace Problem_03.House_With_A_Window
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char HouseSymbol = '*';
        private const char OutsideInsideSymbol = '.';

        private static void Main(string[] args)
        {
            var house = new List<string>();
            var number = int.Parse(Console.ReadLine());
            var houseWidth = number * 2 - 1;
            var rowBuilder = new StringBuilder();

            var outside = new string(OutsideInsideSymbol, number - 1);
            rowBuilder.Append(outside);
            rowBuilder.Append(HouseSymbol);
            rowBuilder.Append(outside);

            house.Add(rowBuilder.ToString());
            rowBuilder.Clear();

            for (var i = number - 2; i >= 0; i--)
            {
                outside = new string(OutsideInsideSymbol, i);
                var inside = new string(OutsideInsideSymbol, houseWidth - 2 * i - 2);
                rowBuilder.Append(outside);
                rowBuilder.Append(HouseSymbol);
                rowBuilder.Append(inside);
                rowBuilder.Append(HouseSymbol);
                rowBuilder.Append(outside);

                house.Add(rowBuilder.ToString());
                rowBuilder.Clear();
            }

            var level = new string(HouseSymbol, houseWidth);
            house.Add(level);

            var aboveBelowWindow = HouseSymbol + new string(OutsideInsideSymbol, houseWidth - 2) + HouseSymbol;
            var windowLevel = HouseSymbol + 
                new string(OutsideInsideSymbol, number / 2) + 
                new string(HouseSymbol, number - 3) + 
                new string(OutsideInsideSymbol, number / 2) +
                HouseSymbol;

            for (var i = 1; i <= number / 4; i++)
            {
                house.Add(aboveBelowWindow);
            }

            for (var i = 1; i <= number / 2; i++)
            {
                house.Add(windowLevel);
            }

            for (var i = 1; i <= number / 4; i++)
            {
                house.Add(aboveBelowWindow);
            }

            house.Add(level);

            Console.WriteLine(string.Join(Environment.NewLine, house));
        }
    }
}
