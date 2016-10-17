namespace Problem_04.Weird_Combinations
{
    using System;
    using System.Xml.Schema;

    internal class Program
    {
        private const int UpperLimit = 3124;
        private const int SequenceLength = 5;
        private static void Main(string[] args)
        {
            var input = Console.ReadLine().ToCharArray();
            var nthNumberIndex = int.Parse(Console.ReadLine());

            if (nthNumberIndex > UpperLimit)
            {
                Console.WriteLine("No");
                return;
            }
            var maxSize = (int)Math.Pow(5, 4);
            var indices = new int[SequenceLength];
            for (var i = 0; i < SequenceLength; i++)
            {
                indices[i] = nthNumberIndex / maxSize;
                nthNumberIndex %= maxSize;
                maxSize /= SequenceLength; 
            }

            var nthNumber =
                new string(
                    new[]
                        {
                        input[indices[0]],
                        input[indices[1]],
                        input[indices[2]],
                        input[indices[3]],
                        input[indices[4]]
                        });

            Console.WriteLine(nthNumber);
        }
    }
}
