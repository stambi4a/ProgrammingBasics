namespace Problem_04.Chess_Queens
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var positions = new List<string>();
            var chessDesignation = new Dictionary<int, char>()
                                       {
                                           { 0, 'a' },
                                           { 1, 'b' },
                                           { 2, 'c' },
                                           { 3, 'd' },
                                           { 4, 'e' },
                                           { 5, 'f' },
                                           { 6, 'g' },
                                           { 7, 'h' },
                                           { 8, 'i' },
                                           { 9, 'j' },
                                           { 10, 'k' },
                                           { 11, 'l' },
                                           { 12, 'm' },
                                           { 13, 'n' },
                                           { 14, 'o' },
                                           { 15, 'p' },
                                           { 16, 'q' },
                                           { 17, 'r' },
                                           { 18, 's' },
                                           { 19, 't' },
                                       };
            var size = int.Parse(Console.ReadLine());
            var distance = int.Parse(Console.ReadLine()) + 1;

            for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    if (j + distance < size)
                    {
                        positions.Add($"{chessDesignation[i]}{j + 1} - {chessDesignation[i]}{j + 1 + distance}");
                        positions.Add($"{chessDesignation[i]}{j + 1 + distance} - {chessDesignation[i]}{j + 1}");
                    }

                    if (i + distance < size)
                    {
                        positions.Add($"{chessDesignation[i]}{j + 1} - {chessDesignation[i + distance]}{j + 1}");
                        positions.Add($"{chessDesignation[i + distance]}{j + 1} - {chessDesignation[i]}{j + 1}");
                    }

                    if (i + distance < size && j + distance < size)
                    {
                        positions.Add($"{chessDesignation[i]}{j + 1} - {chessDesignation[i + distance]}{j + distance + 1}");
                        positions.Add($"{chessDesignation[i + distance]}{j + distance + 1} - {chessDesignation[i]}{j + 1}");
                    }

                    if (i + distance < size && j - distance >= 0)
                    {
                        positions.Add($"{chessDesignation[i]}{j + 1} - {chessDesignation[i + distance]}{j - distance + 1}");
                        positions.Add($"{chessDesignation[i + distance]}{j - distance + 1} - {chessDesignation[i]}{j + 1}");
                    }
                }
            }

            if (positions.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, positions));
                return;
            }

            Console.WriteLine("No valid positions");
        }
    }
}
