namespace Problem_03.The_explorer
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static List<string> diamondLines;
        private static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            diamondLines = new List<string>(width);

            char[][] diamond = new char[width][];
            for (int i = 0; i < width; i++)
            {
                diamond[i] = new string('-', width).ToCharArray();
            }

            GenerateLines(diamond, width);
            Console.WriteLine(string.Join(Environment.NewLine, diamondLines));
        }

        private static void GenerateLines(char[][] diamond, int width)
        {
            int half = width / 2;
            for (int i = half; i >= 0; i--)
            {
                diamond[half - i][i] = '*';
                diamond[half - i][width - i - 1] = '*';
                diamondLines.Add(new string(diamond[half - i]));
            }

            for (int i = 1; i <= half; i++)
            {
                diamond[half + i][i] = '*';
                diamond[half + i][width - i - 1] = '*';
                diamondLines.Add(new string(diamond[half + i]));
            }
        }
    }
}
