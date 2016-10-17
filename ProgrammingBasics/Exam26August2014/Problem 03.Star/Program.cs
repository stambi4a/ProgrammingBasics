namespace Problem_03.Star
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char StarSymbol = '*';
        private const char OtherSymbol = '.';

        private static void Main(string[] args)
        {
            var starLines = new List<string>();
            var parameter = int.Parse(Console.ReadLine());
            var lineBuilder = new StringBuilder();

            lineBuilder.Append(new string(OtherSymbol, parameter) + StarSymbol + new string(OtherSymbol, parameter));
            starLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            for (var i = 1; i < parameter / 2; i++)
            {
                lineBuilder.Append(
                    new string(OtherSymbol, parameter - i) + StarSymbol + new string(OtherSymbol, 2 * i - 1) + StarSymbol
                    + new string(OtherSymbol, parameter - i));
                starLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            lineBuilder.Append(
                new string(StarSymbol, parameter / 2 + 1) + new string(OtherSymbol, parameter - 1)
                + new string(StarSymbol, parameter / 2 + 1));
            starLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            for (var i = 1; i < parameter / 2; i++)
            {
                lineBuilder.Append(
                    new string(OtherSymbol, i) + StarSymbol + new string(OtherSymbol, 2 * parameter - 2 * i - 1) + StarSymbol
                    + new string(OtherSymbol, i));
                starLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            lineBuilder.Append(
                    new string(OtherSymbol, parameter / 2) + StarSymbol + new string(OtherSymbol, parameter / 2 - 1) + StarSymbol + new string(OtherSymbol, parameter / 2 - 1) + StarSymbol +
                    new string(OtherSymbol, parameter / 2));
            starLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            for (var i = 1; i < parameter / 2; i++)
            {
                lineBuilder.Append( 
                    new string(OtherSymbol, parameter / 2 - i) + StarSymbol + new string(OtherSymbol, parameter / 2 - 1) + StarSymbol + new string(OtherSymbol, 2 * i - 1) + StarSymbol + new string(OtherSymbol, parameter / 2 - 1) + StarSymbol + 
                    new string(OtherSymbol, parameter / 2 - i));
                starLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            lineBuilder.Append(
               new string(StarSymbol, parameter / 2 + 1) + new string(OtherSymbol, parameter - 1)
               + new string(StarSymbol, parameter / 2 + 1));
            starLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            Console.WriteLine(string.Join(Environment.NewLine, starLines));
        }
    }
}
