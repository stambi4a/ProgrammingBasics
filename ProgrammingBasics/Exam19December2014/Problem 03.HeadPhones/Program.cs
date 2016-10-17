namespace Problem_03.HeadPhones
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char HeadphoneSymbol = '*';
        private const char CanvasSymbol = '-';

        private static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var headphoneLines = new List<string>();
            var lineBuilder = new StringBuilder();
            lineBuilder.Append(
                new string(CanvasSymbol, width / 2) + new string(HeadphoneSymbol, width + 2)
                + new string(CanvasSymbol, width / 2));
            headphoneLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            lineBuilder.Append(
                    new string(CanvasSymbol, width / 2) + HeadphoneSymbol + new string(CanvasSymbol, width)
                    + HeadphoneSymbol + new string(CanvasSymbol, width / 2));
            var cableLine = lineBuilder.ToString();
            lineBuilder.Clear();

            for (var i = 0; i < width; i++)
            {
                headphoneLines.Add(cableLine);
            }

            for (var i = (width - 3) / 2; i >= 0; i--)
            {
                lineBuilder.Append(new string(CanvasSymbol, i) + new string(HeadphoneSymbol, width - 2 * i) + new string(CanvasSymbol, 2 * i + 1) + new string(HeadphoneSymbol, width - 2 * i) + new string(CanvasSymbol, i));
                headphoneLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            for (var i = 1; i <= width / 2; i++)
            {
                lineBuilder.Append(new string(CanvasSymbol, i) + new string(HeadphoneSymbol,width - 2 * i) + new string(CanvasSymbol, 2 * i + 1) + new string(HeadphoneSymbol, width - 2 * i) + new string(CanvasSymbol, i));
                headphoneLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            Console.WriteLine(string.Join(Environment.NewLine, headphoneLines));
        }
    }
}
