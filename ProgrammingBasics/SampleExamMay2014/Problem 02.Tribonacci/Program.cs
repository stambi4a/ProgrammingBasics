namespace Problem_02.Tribonacci
{
    using System;
    using System.Numerics;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            var first = new BigInteger(int.Parse(Console.ReadLine()));
            var second = new BigInteger(int.Parse(Console.ReadLine()));
            var third = new BigInteger(int.Parse(Console.ReadLine()));

            var tribonacciIndex = long.Parse(Console.ReadLine());
            if (tribonacciIndex == 1)
            {
                Console.WriteLine(first);
                return;
            }
            if (tribonacciIndex == 2)
            {
                Console.WriteLine(second);
                return;
            }

            if (tribonacciIndex == 3)
            {
                Console.WriteLine(third);
                return;
            }

            var currentIndex = 4;
            while (currentIndex <= tribonacciIndex)
            {
                third = third + first + second;
                second = third - first - second;
                first = third - second - first;
                currentIndex++;
            }

            Console.WriteLine(third);
        }
    }
}
