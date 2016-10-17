namespace Problem_03.Sand_Glass
{
    using System;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var width = int.Parse(Console.ReadLine());
            var builder = new StringBuilder();
            builder.Append(new string('*', width) + Environment.NewLine);
            var halfSandGlass = (width - 3) / 2;
            for (var i = 1; i <= halfSandGlass; i++)
            {
                builder.Append(
                    new string('.', i) + new string('*', width - 2 * i) + new string('.', i) + Environment.NewLine);
            }

            builder.Append(new string('.', halfSandGlass + 1) + '*' + new string('.', halfSandGlass + 1) + Environment.NewLine);

            for (var i = halfSandGlass; i >= 1; i--)
            {
                builder.Append(
                    new string('.', i) + new string('*', width - 2 * i) + new string('.', i) + Environment.NewLine);
            }

            builder.Append(new string('*', width));
            Console.WriteLine(builder.ToString());
        }
    }
}
