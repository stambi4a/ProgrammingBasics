namespace Problem_03.BodyBuilding
{
    using System;
    using System.Text;

    internal class Program
    {
        private const char OutDumbellChar = '&';
        private const char InDumbellChar = '*';
        private const char ShaftChar = '=';
        private const char CanvasChar = '.';

        private static void Main(string[] args)
        {
            var lineBuilder = new StringBuilder();
            var linesCount= int.Parse(Console.ReadLine());
            var dumbbellLines = new string[linesCount];

            lineBuilder.Append(
                new string(CanvasChar, linesCount / 2) + new string(OutDumbellChar, linesCount / 2 + 1)
                + new string(CanvasChar, linesCount) + new string(OutDumbellChar, linesCount / 2 + 1)
                + new string(CanvasChar, linesCount / 2));
            dumbbellLines[0] = dumbbellLines[linesCount - 1] =  lineBuilder.ToString();
            lineBuilder.Clear();

            for (var i = linesCount / 2 - 1; i >= 1; i--)
            {
                lineBuilder.Append(
                new string(CanvasChar, i) + OutDumbellChar + new string(InDumbellChar, linesCount - i - 2) + OutDumbellChar + new string(CanvasChar, linesCount) + OutDumbellChar + new string(InDumbellChar, linesCount - i - 2) + OutDumbellChar + new string(CanvasChar, i));
                dumbbellLines[linesCount / 2 - i] = dumbbellLines[linesCount - linesCount / 2 + i - 1] = lineBuilder.ToString();
                lineBuilder.Clear();
            }

            lineBuilder.Append(
                OutDumbellChar + new string(InDumbellChar, linesCount - 2) + OutDumbellChar + new string(ShaftChar, linesCount) + OutDumbellChar + new string(InDumbellChar, linesCount - 2) + OutDumbellChar);
            dumbbellLines[linesCount / 2] = lineBuilder.ToString();

            Console.WriteLine(string.Join(Environment.NewLine, dumbbellLines));
        }
    }
}
