namespace Problem_03.Boat
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char BoatSymbol = '*';
        private const char CanvasSymbol = '.';
        private static void Main(string[] args)
        {
            var boatLines = new List<string>();
            var lineBuilder = new StringBuilder();

            var size = int.Parse(Console.ReadLine());
            var sailBlankLine = new string(CanvasSymbol, size);
            for (var i = 1; i <= size; i = i + 2)
            {
                lineBuilder.Append(new string(CanvasSymbol, size - i) + new string(BoatSymbol, i) + sailBlankLine);
                boatLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            for (var i = size - 2; i >= 1; i= i - 2)
            {
                lineBuilder.Append(new string(CanvasSymbol, size - i) + new string(BoatSymbol, i) + sailBlankLine);
                boatLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            for (var i = 0; i < (size - 1) / 2; i++)
            {
                lineBuilder.Append(
                    new string(CanvasSymbol, i) + new string(BoatSymbol, 2 * size - 2 * i) + new string(CanvasSymbol, i));
                boatLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            Console.WriteLine(string.Join(Environment.NewLine,boatLines));
        }
    }
}
