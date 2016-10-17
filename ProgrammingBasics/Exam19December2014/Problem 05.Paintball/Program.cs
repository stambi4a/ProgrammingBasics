namespace Problem_05.Paintball
{
    using System;
    using System.Linq;

    internal class Program
    {
        private const int Size = 10;
        private static void Main(string[] args)
        {
            var matrix = new char[Size][];
            for (var i = 0; i < Size; i++)
            {
                matrix[i] = Enumerable.Repeat('1', Size).ToArray();
            }

            var counter = 0;
            while (true)
            {
                var line = Console.ReadLine();
                if (line.Equals("End"))
                {
                    break;
                }

                var input = line.Split().Select(int.Parse).ToArray();
                var row = input[0];
                var column = Size - 1 - input[1];
                var radius = input[2];
                var upperLeftRow = row - radius > 0 ? row - radius : 0;
                var upperLeftColumn = column - radius > 0 ? column - radius : 0;
                var lowerRightRow = row + radius < Size - 1 ? row + radius : Size - 1;
                var lowerRightColum = column + radius < Size - 1 ? column + radius : Size - 1;
                for (var j = upperLeftRow; j <= lowerRightRow; j++)
                {
                    for (var k = upperLeftColumn; k <= lowerRightColum; k++)
                    {
                        matrix[j][k] = counter % 2 == 0 ? '0' : '1';
                    }
                }

                counter++;
            }

            var totalSum = 0;
            for (var i = 0; i < Size; i++)
            {
                totalSum += Convert.ToInt32(new string(matrix[i]), 2);
            }

            Console.WriteLine(totalSum);
        }
    }
}
