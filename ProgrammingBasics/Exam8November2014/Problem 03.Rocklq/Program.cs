namespace Problem_03.Rocklq
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

            lineBuilder.Append(new string(CanvasSymbol, parameter) + new string(ContourSymbol, parameter) + new string(CanvasSymbol, parameter));
            planeLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            for (var i = 1; i <= parameter / 2; i++)
            {
                lineBuilder.Append(new string(CanvasSymbol, parameter - 2 * i) + ContourSymbol + new string(CanvasSymbol, parameter + 4 * i - 2) + ContourSymbol + new string(CanvasSymbol, parameter - 2 * i));

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
