namespace Problem_05.Bit_Paths
{
    using System;
    using System.Linq;

    internal class Program
    {
        private const int Rows = 7;
        private const int BitsInRow = 4;

        private static void Main(string[] args)
        {
            var paths = int.Parse(Console.ReadLine());
            var pathDirections = new int[paths][];
            for (var i = 0; i < paths; i++)
            {
                pathDirections[i] = Console.ReadLine().Split(',').Select(int.Parse).ToArray();
            }

            var positions = new int[paths];
            for (var i = 0; i < paths; i++)
            {
                positions[i] = BitsInRow - 1 - pathDirections[i][0];
            }

            var rowNumber = 0;
            for (var i = 0; i < paths; i++)
            {
                rowNumber ^= 1 << positions[i];
            }

            var totalSum = rowNumber;
            for (var i = 1; i <= Rows; i++)
            {
                rowNumber = 0;
                for (var j = 0; j < paths; j++)
                {
                    if (pathDirections[j][i] == 1)
                    {
                        positions[j]--;
                    }

                    if (pathDirections[j][i] == -1)
                    {
                        positions[j]++;
                    }

                    rowNumber ^= 1 << positions[j];
                }

                totalSum += rowNumber;
            }

            var binaryNumber = Convert.ToString(totalSum, 2);
            Console.WriteLine(binaryNumber);
            Console.WriteLine($"{totalSum:X}");
        }
    }
}
