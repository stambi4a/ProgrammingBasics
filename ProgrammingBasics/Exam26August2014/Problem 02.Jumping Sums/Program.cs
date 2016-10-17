namespace Problem_02.Jumping_Sums
{
    using System;
    using System.Linq;

    internal class Program
    {
        private const string MaxSumMessage = "max sum = {0}";
        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var length = numbers.Length;
            var jumpCount = int.Parse(Console.ReadLine());
            var sums = new int[length];
            for(var j = 0; j < length; j++)
            {
                sums[j] += numbers[j];
                var index = j;
                for (var i = 1; i <= jumpCount; i++)
                {
                    index = (index + numbers[index]) % length;
                    sums[j] += numbers[index];
                }
            }

            var maxSum = sums.Max();
            Console.WriteLine(MaxSumMessage, maxSum);
        }
    }
}
