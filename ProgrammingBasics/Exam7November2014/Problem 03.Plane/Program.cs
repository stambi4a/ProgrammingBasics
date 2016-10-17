namespace Problem_03.Plane
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char ContourSymbol = '*';
        private const char CanvasSymbol = '.';

        private static void Main(string[] args)
        {
            var planeLines = new List<string>();
            var lineBuilder = new StringBuilder();

            var parameter = int.Parse(Console.ReadLine());

            lineBuilder.Append(new string(CanvasSymbol, parameter * 3 / 2) + ContourSymbol + new string(CanvasSymbol, parameter * 3 / 2));
            planeLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            var limit = parameter / 2 + 2;
            for (var i = 1; i <= limit; i++)
            {
                lineBuilder.Append(new string(CanvasSymbol, (3 * parameter - 2 * i - 1) / 2) + ContourSymbol + new string(CanvasSymbol, 2 * i - 1) + ContourSymbol + new string(CanvasSymbol, (3 * parameter - 2 * i - 1) / 2));

                planeLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            for (var i = limit + 2; i <= (3 * parameter - 4) / 2 + 1; i = i + 2)
            {
                var width = (3 * parameter - 2 * i - 1) / 2;
                lineBuilder.Append(new string(CanvasSymbol, width) + ContourSymbol + new string(CanvasSymbol, 2 * i - 1) + ContourSymbol + new string(CanvasSymbol, width));

                planeLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            lineBuilder.Append(ContourSymbol + new string(CanvasSymbol, parameter - 2) + ContourSymbol + new string(CanvasSymbol, parameter) + ContourSymbol + new string(CanvasSymbol, parameter - 2) + ContourSymbol);

            planeLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            for (var i = 1; i <= parameter - 4; i = i + 2)
            {
                lineBuilder.Append(
                    ContourSymbol + new string(CanvasSymbol, parameter - 3 - i) + ContourSymbol
                    + new string(CanvasSymbol, i) + ContourSymbol + new string(CanvasSymbol, parameter) + ContourSymbol
                    + new string(CanvasSymbol, i) + ContourSymbol + new string(CanvasSymbol, parameter - 3 - i)
                    + ContourSymbol);
                planeLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            for (var i = parameter - 1; i >= 1; i--)
            {
                lineBuilder.Append(
                    new string(CanvasSymbol, i) + ContourSymbol + new string(CanvasSymbol, parameter + 2 * (parameter - i - 1)) + ContourSymbol
                    + new string(CanvasSymbol, i));
                planeLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            planeLines.Add(new string(ContourSymbol, 3 * parameter));

            Console.WriteLine(string.Join(Environment.NewLine, planeLines));
        }
    }
}
