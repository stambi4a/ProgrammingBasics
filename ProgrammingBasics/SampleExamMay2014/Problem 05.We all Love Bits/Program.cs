namespace Problem_05.We_all_Love_Bits
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var countNumbers = int.Parse(Console.ReadLine());
            for (var counter = 1; counter <= countNumbers; counter++)
            {
                var number = int.Parse(Console.ReadLine());
                var binaryNumber = Convert.ToString(number, 2);
                var binaryNumberLength = binaryNumber.Length;
                var invertedNumber = number;
                for (var i = binaryNumberLength - 1; i >= 0; i--)
                {
                    invertedNumber = (invertedNumber | (1 << i)) & ~(invertedNumber & (1 << i));
                }

                var reversedNumber = 0;
                for (var i = binaryNumberLength - 1; i >= binaryNumberLength / 2; i--)
                {
                    var shift = 2 * i + 1 - binaryNumberLength;
                    reversedNumber = reversedNumber | ((number & (1 << i)) >> shift);
                }

                for (var i = binaryNumberLength / 2 - 1; i >= 0; i--)
                {
                    var shift = binaryNumberLength - 2 * i - 1;
                    reversedNumber = reversedNumber | ((number & (1 << i)) << shift);
                }

                var newNumber = (number ^ invertedNumber) & reversedNumber;
                Console.WriteLine(newNumber);
            }
        }
    }
}
