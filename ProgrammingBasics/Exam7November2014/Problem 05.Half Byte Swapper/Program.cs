namespace Problem_05.Half_Byte_Swapper
{
    using System;
    using System.Net.NetworkInformation;

    internal class Program
    {
        private const int NumberCount = 4;
        private const int BitsInAGroup = 4;
        private static void Main(string[] args)
        {
            var numbers = new uint[NumberCount];
            for (var i = 0; i < NumberCount; i++)
            {
                numbers[i] = uint.Parse(Console.ReadLine());
            }

            while(true)
            {
                var input = Console.ReadLine();
                if (input.Equals("End"))
                {
                    break;
                }

                var inputParams = input.Split();

                var firstNumberIndex = int.Parse(inputParams[0]);
                var firstNumberGroup = int.Parse(inputParams[1]);

                input = Console.ReadLine();
                inputParams = input.Split();

                var secondNumberIndex = int.Parse(inputParams[0]);
                var secondNumberGroup = int.Parse(inputParams[1]);

                var firstGroupBits = (numbers[firstNumberIndex] & (15u << firstNumberGroup * BitsInAGroup)) >> firstNumberGroup * BitsInAGroup;

                var secondGroupBits = (numbers[secondNumberIndex] & (15u << secondNumberGroup * BitsInAGroup)) >> secondNumberGroup * BitsInAGroup;

                var zeros = 15u << secondNumberGroup * BitsInAGroup;
                numbers[secondNumberIndex] &= ~zeros;
                numbers[secondNumberIndex] |= firstGroupBits << secondNumberGroup * BitsInAGroup;

                zeros = 15u << firstNumberGroup * BitsInAGroup;
                numbers[firstNumberIndex] &= ~zeros;
                numbers[firstNumberIndex] |= secondGroupBits << firstNumberGroup * BitsInAGroup;
            }

            Console.WriteLine(string.Join(Environment.NewLine, numbers));
        }
    }
}
