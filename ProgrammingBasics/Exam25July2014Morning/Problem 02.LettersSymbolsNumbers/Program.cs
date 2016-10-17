namespace Problem_02.LettersSymbolsNumbers
{
    using System;
    using System.Text.RegularExpressions;

    internal class Program
    {
        private const int DigitValue = 20;
        private const int LetterValue = 10;
        private const int SpecialSymbolValue = 200;

        private static void Main(string[] args)
        {
            var countInputs = int.Parse(Console.ReadLine());
            var sumLetters = 0;
            var sumNumbers = 0;
            var sumSpecialSymbols = 0;
            for (var j = 0; j < countInputs; j++)
            {
                var input = Regex.Replace(Console.ReadLine(), "\\s+", "");
                var length = input.Length;
                for (var i = 0; i < length; i++)
                {
                    var symbol = input[i];
                    if (symbol >= '0' && symbol <= '9')
                    {
                        sumNumbers += (symbol - '0') * DigitValue;
                        continue;
                    }

                    if (symbol >= 'a' && symbol <= 'z')
                    {
                        sumLetters += (symbol - 'a' + 1) * LetterValue;
                        continue;
                    }

                    if (symbol >= 'A' && symbol <= 'Z')
                    {
                        sumLetters += (symbol - 'A' + 1) * LetterValue;
                        continue;
                    }

                    sumSpecialSymbols += SpecialSymbolValue;
                }
            }

            Console.WriteLine($"{sumLetters}\n{sumNumbers}\n{sumSpecialSymbols}");
        }          
    }
}
