namespace Problem03.House
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private static List<string> lines;
        private static void Main(string[] args)
        {
            lines = new List<string>();
            int height = int.Parse(Console.ReadLine());
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < height / 2; i++)
            {
                strBuilder.Append('.');
            }

            strBuilder.Append('*');

            for (int i = 0; i < height / 2; i++)
            {
                strBuilder.Append('.');
            }

            lines.Add(strBuilder.ToString());
            for (int i = height / 2 - 1 ; i >= 1; i--)
            {
                strBuilder.Clear();
                for (int j = i; j >= 1; j--)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('*');

                for (int j = 1; j <= height - 2 * (i + 1); j++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('*');

                for (int j = i; j >= 1; j--)
                {
                    strBuilder.Append('.');
                }

                lines.Add(strBuilder.ToString());
            }

            lines.Add(new string('*', height));

            int distance = height / 4;
            for (int i = 1; i <= height / 2 - 1; i++)
            {
                strBuilder.Clear();
                for (int j = 1; j <= distance; j++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('*');

                for (int j = 1; j <= height - 2 * (distance + 1); j++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('*');

                for (int j = 1; j <= distance; j++)
                {
                    strBuilder.Append('.');
                }

                lines.Add(strBuilder.ToString());
            }

            strBuilder.Clear();
            for (int j = 1; j <= distance; j++)
            {
                strBuilder.Append('.');
            }

            for (int j = 1; j <= height - 2 * distance; j++)
            {
                strBuilder.Append('*');
            }

            for (int j = 1; j <= distance; j++)
            {
                strBuilder.Append('.');
            }

            lines.Add(strBuilder.ToString());

            Console.WriteLine(string.Join(Environment.NewLine, lines));
        }
    }
}