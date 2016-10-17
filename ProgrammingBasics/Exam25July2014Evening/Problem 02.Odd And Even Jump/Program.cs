namespace Problem_02.Odd_And_Even_Jump
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = string.Concat(Console.ReadLine().ToLower().Split());
            var oddLetters = new List<char>();
            var evenLetters = new List<char>();

            for (var i = 0; i < input.Length; i = i + 2)
            {
                oddLetters.Add(input[i]);
            }

            for (var i = 1; i < input.Length; i = i + 2)
            {
                evenLetters.Add(input[i]);
            }

            var oddJump = int.Parse(Console.ReadLine());
            var evenJump = int.Parse(Console.ReadLine());

            var oddSum = 0L;
            for (var i = 0; i < oddLetters.Count; i++)
            {
                if ((i + 1) % oddJump == 0)
                {
                    oddSum *= oddLetters[i];
                    continue;;
                }

                oddSum += oddLetters[i];
            }

            var evenSum = 0L;
            for (var i = 0; i < evenLetters.Count; i++)
            {
                if ((i + 1) % evenJump == 0)
                {
                    evenSum *= evenLetters[i];
                    continue; ;
                }

                evenSum += evenLetters[i];
            }

            Console.WriteLine($"Odd: {oddSum:X}");
            Console.WriteLine($"Even: {evenSum:X}");
        }
    }
}
