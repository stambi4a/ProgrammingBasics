namespace Problem_04.Spiral_Matrix
{
    using System;

    internal class Program
    {
        private const string Result = "{0} - {1}";
        private static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var word = Console.ReadLine();

            var length = word.Length;
            var matrix = new char[size, size];
            var wordIndex = 0;
            for (var i = 0; i < size / 2; i++)
            {
                for (var j = i; j < size - i - 1; j ++)
                {
                    matrix[i, j] = word[wordIndex % length];
                    wordIndex++;
                }

                for (var j = i; j < size - i - 1; j++)
                {
                    matrix[j, size - i - 1] = word[wordIndex % length];
                    wordIndex++;
                }

                for (var j = size - i - 1; j > i; j--)
                {
                    matrix[size - i - 1, j] = word[wordIndex % length];
                    wordIndex++;
                }

                for (var j = size - i - 1; j > i; j--)
                {
                    matrix[j, i] = word[wordIndex % length];
                    wordIndex++;
                }
            }

            var maxRowWeight = 0;
            var maxRowIndex = 0;
            for (var i = 0; i < size; i++)
            {
                var currentRowWeight = 0;
                for (var j = 0; j < size; j++)
                {
                    if (matrix[i, j] >= 'a' && matrix[i, j] <= 'z')
                    {
                        currentRowWeight += matrix[i, j] - 'a' + 1;
                        continue;
                    }

                    currentRowWeight += matrix[i, j] - 'A' + 1;
                }

                if (currentRowWeight > maxRowWeight)
                {
                    maxRowWeight = currentRowWeight;
                    maxRowIndex = i;
                }
            }

            Console.WriteLine(Result, maxRowIndex, maxRowWeight * 10);
            /*for (var i = 0; i < size; i++)
            {
                for (var j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j]);
                }

                Console.WriteLine();
            }*/
        }
    }
}
