namespace Problem_03.Car
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char CarSymbol = '*';
        private const char OtherSymbol = '.';

        private static void Main(string[] args)
        {
            var carLines = new List<string>();
            var parameter = int.Parse(Console.ReadLine());
            var carWidth = 3 * parameter;
            var roofHeight = parameter / 2;
            var lineBuilder = new StringBuilder();
            lineBuilder.Append(
                new string(OtherSymbol, parameter) + new string(CarSymbol, parameter)
                + new string(OtherSymbol, parameter));
            carLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();
            for (var i = 1; i <= roofHeight - 1; i++)
            {
                lineBuilder.Append(
                    new string(OtherSymbol, parameter - i) +
                    CarSymbol + 
                    new string(OtherSymbol, parameter + 2 * (i - 1)) + 
                    CarSymbol + 
                    new string(OtherSymbol, parameter - i));
                carLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            lineBuilder.Append(
                new string(CarSymbol, parameter - roofHeight + 1) + 
                new string(OtherSymbol, 2 * parameter - 2) + 
                new string(CarSymbol, parameter - roofHeight + 1));

            carLines.Add(lineBuilder.ToString());
            lineBuilder.Clear();

            for (var i = 1; i <= roofHeight - 2; i++)
            {
                lineBuilder.Append(
                    CarSymbol + new string(OtherSymbol, carWidth - 2) + CarSymbol);
                carLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            carLines.Add(new string(CarSymbol, carWidth));

            for (var i = 1; i <= roofHeight - 2; i++)
            {
                lineBuilder.Append(
                    new string(OtherSymbol, roofHeight) + 
                    CarSymbol + 
                    new string(OtherSymbol, roofHeight - 1) + 
                    CarSymbol + 
                    new string(OtherSymbol, parameter - 2) + 
                    CarSymbol + 
                    new string(OtherSymbol, roofHeight - 1) + 
                    CarSymbol + 
                    new string(OtherSymbol , roofHeight));
                carLines.Add(lineBuilder.ToString());
                lineBuilder.Clear();
            }

            lineBuilder.Append(
                    new string(OtherSymbol, roofHeight) +
                    new string(CarSymbol, roofHeight + 1) +
                    new string(OtherSymbol, parameter - 2) +
                    new string(CarSymbol, roofHeight + 1) +
                    new string(OtherSymbol, roofHeight));
            carLines.Add(lineBuilder.ToString());

            Console.WriteLine(string.Join(Environment.NewLine, carLines));
        }

        
    }
}
