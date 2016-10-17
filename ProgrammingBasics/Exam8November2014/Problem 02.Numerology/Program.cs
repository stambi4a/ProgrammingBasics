namespace Problem_02.Numerology
{
    using System;

    internal class Program
    {
        private const int SacralNumber = 13;
        private const int Ten = 10;

        private static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var date = DateTime.Parse(input[0]);
            long dateNumber = date.Day * date.Month * date.Year;
            if(date.Month % 2 == 1)
            {
                dateNumber *= dateNumber;
            }

            var userName = input[1];
            var nameNumber = 0;
            for (var i = 0; i < userName.Length; i++)
            {
                if (userName[i] >= 'a' && userName[i] <= 'z')
                {
                    nameNumber += userName[i] - 'a' + 1;
                }

                if (userName[i] >= 'A' && userName[i] <= 'Z')
                {
                    nameNumber += (userName[i] - 'A' + 1) * 2;
                }

                if (userName[i] >= '0' && userName[i] <= '9')
                {
                    nameNumber += userName[i] - '0';
                }
            }

            var celestialNumber = dateNumber + nameNumber;
            while (celestialNumber > SacralNumber)
            {
                var temp = 0L;
                while (celestialNumber > 0)
                {
                    temp += celestialNumber % Ten;
                    celestialNumber /= Ten;
                }

                celestialNumber = temp;
            }

            Console.WriteLine(celestialNumber);
        }
    }
}
