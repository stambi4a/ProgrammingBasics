namespace Problem_03.PandaScotlandFlag
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const char OuterFlagSymbol = '~';
        private const char InnerFlagSymbol = '#';
        private const char CenterFlagSymbol = '-';
        private const int AlphabetSize = 26;

        private static void Main(string[] args)
        {
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var flagLineBuilder = new StringBuilder();
            var flag = new List<string>();
            var flagWidth = int.Parse(Console.ReadLine());
            var counterLetters = 0;
            for (var i = 0; i < flagWidth / 2; i++)
            {
                var outsideSymbols = new string(OuterFlagSymbol, i);
                var widthInsideSymbols = flagWidth - 2 * i - 2;
                var insideSymbols = new string(InnerFlagSymbol, widthInsideSymbols);
                flagLineBuilder.Append(outsideSymbols);
                flagLineBuilder.Append(alphabet[counterLetters % AlphabetSize]);
                counterLetters++;
                flagLineBuilder.Append(insideSymbols);
                flagLineBuilder.Append(alphabet[counterLetters % AlphabetSize]);
                counterLetters++;
                flagLineBuilder.Append(outsideSymbols);

                flag.Add(flagLineBuilder.ToString());
                flagLineBuilder.Clear();
            }

            var middleHalfLine = new string(CenterFlagSymbol, (flagWidth - 1) / 2);
            flagLineBuilder.Append(middleHalfLine);
            flagLineBuilder.Append(alphabet[counterLetters % AlphabetSize]);
            counterLetters++;
            flagLineBuilder.Append(middleHalfLine);
            flag.Add(flagLineBuilder.ToString());
            flagLineBuilder.Clear();

            for (var i = flagWidth / 2 - 1; i >= 0; i--)
            {
                var outsideSymbols = new string(OuterFlagSymbol, i);
                var widthInsideSymbols = flagWidth - 2 * i - 2;
                var insideSymbols = new string(InnerFlagSymbol, widthInsideSymbols);
                flagLineBuilder.Append(outsideSymbols);
                flagLineBuilder.Append(alphabet[counterLetters % AlphabetSize]);
                counterLetters++;
                flagLineBuilder.Append(insideSymbols);
                flagLineBuilder.Append(alphabet[counterLetters % AlphabetSize]);
                counterLetters++;
                flagLineBuilder.Append(outsideSymbols);
                flag.Add(flagLineBuilder.ToString());
                flagLineBuilder.Clear();
            }

            Console.WriteLine(string.Join(Environment.NewLine, flag));
        }
    }
}
