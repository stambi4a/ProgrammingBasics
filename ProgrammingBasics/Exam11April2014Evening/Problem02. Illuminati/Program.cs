namespace Problem02.Illuminati
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();
            int countVowels = 0;
            int vowelTotalValue = 0;
            foreach (char ch in text)
            {
                if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
                {
                    countVowels++;
                    vowelTotalValue += ch;
                }
            }

            Console.WriteLine($"{countVowels}{Environment.NewLine}{vowelTotalValue}");
        }
    }
}
