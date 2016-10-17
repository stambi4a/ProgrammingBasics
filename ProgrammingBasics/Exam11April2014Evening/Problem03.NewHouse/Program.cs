namespace Problem03.NewHouse
{
    using System;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            StringBuilder strBuilder = new StringBuilder();

            for (int j = width / 2; j >= 0; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    strBuilder.Append('-');
                }

                for (int i = 1; i <= width - 2 * j; i++)
                {
                    strBuilder.Append('*');
                }

                for (int i = 0; i < j; i++)
                {
                    strBuilder.Append('-');
                }

                strBuilder.Append(Environment.NewLine);
            }

            for (int i = 1; i <= width; i++)
            {
                strBuilder.Append('|');

                for (int j = 1; j <= width - 2; j++)
                {
                    strBuilder.Append('*');
                }

                strBuilder.Append('|');
                strBuilder.Append(Environment.NewLine);
            }

            strBuilder.Length -= Environment.NewLine.Length;

            Console.WriteLine(strBuilder.ToString());
        }
    }
}
