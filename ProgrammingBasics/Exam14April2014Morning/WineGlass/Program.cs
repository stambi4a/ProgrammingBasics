namespace WineGlass
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const int BorderCase = 12;
        private static void Main(string[] args)
        {
            int countLines = int.Parse(Console.ReadLine());
            List<string> glass = CreateWineGlass(countLines);
            Console.WriteLine(string.Join(Environment.NewLine, glass));
        }

        private static List<string> CreateWineGlass(int countLines)
        {
            List<string> lineStrings = new List<string>();
            for (int i = 0; i < countLines / 2; i++)
            {
                StringBuilder lineString = new StringBuilder();
                for (int j = 0; j < i; j++)
                {
                    lineString.Append('.');
                }

                lineString.Append('\\');
                for (int j = i + 1; j < countLines - i - 1; j++)
                {
                    lineString.Append('*');
                }
                lineString.Append('/');
                for (int j = countLines - i; j < countLines; j++)
                {
                    lineString.Append('.');
                }

                lineStrings.Add(lineString.ToString());
            }

            int glassHandleBottom = countLines < BorderCase ? countLines - 1 : countLines - 2;
            for (int i = countLines / 2; i < glassHandleBottom; i++)
            {
                StringBuilder lineString = new StringBuilder();
                for (int j = 0; j < countLines / 2 - 1; j++)
                {
                    lineString.Append('.');
                }

                lineString.Append("||");

                for (int j = countLines / 2 + 1; j < countLines; j++)
                {
                    lineString.Append('.');
                }

                lineStrings.Add(lineString.ToString());
            }

            for (int i = glassHandleBottom; i < countLines; i++)
            {
                lineStrings.Add(new string('-', countLines));
            }

            return lineStrings;
        }
    }
}
