namespace Problem_02.Odd_Even_Sum
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var oddSum = 0;
            var evenSum = 0;
            for (var i = 0; i < 2 * num; i = i + 2)
            {
                oddSum += int.Parse(Console.ReadLine());
                evenSum += int.Parse(Console.ReadLine());
            }

            if (oddSum == evenSum)
            {
                Console.WriteLine("Yes, sum=" + oddSum);
                return;
            }

            Console.WriteLine("No, diff=" + Math.Abs(evenSum - oddSum));
        }
    }
}
