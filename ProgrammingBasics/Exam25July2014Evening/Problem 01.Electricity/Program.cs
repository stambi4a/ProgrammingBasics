namespace Problem_01.Electricity
{
    using System;
    using System.Text;

    internal class Program
    {
        private const decimal ComputerPowerUsage = 125.90m;

        private const decimal LampPowerUsage = 100.53m;

        private static readonly Tuple<int, int> eveningConsumators = new Tuple<int, int>(2, 2);

        private static readonly Tuple<int, int> nightConsumators = new Tuple<int, int>(7, 6);

        private static readonly Tuple<int, int> morningConsumators = new Tuple<int, int>(1, 8);

        private static void Main()
        {
            var floors = int.Parse(Console.ReadLine());
            var flatsOnAFloor = int.Parse(Console.ReadLine());
            var hours = Console.ReadLine();
            var hourBuilder = new StringBuilder();
            var indexColon = hours.IndexOf(':');
            if (indexColon == 1)
            {
                hourBuilder.Append('0');
                hourBuilder.Append(hours[0]);
            }
            else
            {
                hourBuilder.Append(hours[0]);
                hourBuilder.Append(hours[1]);
            }

            hourBuilder.Append(':');
            if (indexColon == hours.Length - 2)
            {
                hourBuilder.Append('0');
                hourBuilder.Append(hours[hours.Length - 1]);
            }
            else
            {
                hourBuilder.Append(hours[hours.Length - 2]);
                hourBuilder.Append(hours[hours.Length - 1]);
            }

            hours = hourBuilder.ToString();
            var totalConsumption = 0;
            var computerConsumatorsPerFlat = 0;
            var lampConsumatorsPerFlat = 0;
            if (hours.CompareTo("14:00") >= 0 && hours.CompareTo("18:59") <= 0)
            {
                computerConsumatorsPerFlat = eveningConsumators.Item2;
                lampConsumatorsPerFlat = eveningConsumators.Item1;
            }

            if (hours.CompareTo("19:00") >= 0 && hours.CompareTo("23:59") <= 0)
            {
                computerConsumatorsPerFlat = nightConsumators.Item2;
                lampConsumatorsPerFlat = nightConsumators.Item1;
            }

            if (hours.CompareTo("00:00") >= 0 && hours.CompareTo("08:59") <= 0)
            {
                computerConsumatorsPerFlat = morningConsumators.Item2;
                lampConsumatorsPerFlat = morningConsumators.Item1;
            }

            totalConsumption = (int)(floors * flatsOnAFloor * (computerConsumatorsPerFlat * ComputerPowerUsage + lampConsumatorsPerFlat * LampPowerUsage));

            Console.WriteLine(totalConsumption + " Watts");
        }
    }
}
