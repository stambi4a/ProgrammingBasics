namespace Problem_05.Bits_Up
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private const int BitsInByte = 8;
        private static void Main(string[] args)
        {
            var bytes = new List<int>();
            var countBytes = int.Parse(Console.ReadLine());

            var step = int.Parse(Console.ReadLine());
            var position = 1;
            for (var i = 1; i <= countBytes; i++)
            {
                var num = int.Parse(Console.ReadLine());
                while (position < BitsInByte)
                {
                    num |= 1 << BitsInByte - position - 1;
                    position += step;
                }

                if (position >= BitsInByte)
                {
                    position -= BitsInByte;
                }

                bytes.Add(num);
            }

            Console.WriteLine(string.Join(Environment.NewLine, bytes));
        }
    }
}
