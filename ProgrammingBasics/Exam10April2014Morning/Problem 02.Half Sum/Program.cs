namespace Problem_02.Half_Sum
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sumFirst = 0;
            var sumSecond = 0;
            for (var i = 0; i < num; i++)
            {
                sumFirst += int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < num; i++)
            {
                sumSecond += int.Parse(Console.ReadLine());
            }

            if (sumFirst == sumSecond)
            {
                Console.WriteLine("Yes, sum=" + sumFirst);
                return;
            }

            Console.WriteLine("No, diff=" + Math.Abs(sumSecond - sumFirst));
        }
    }
}
