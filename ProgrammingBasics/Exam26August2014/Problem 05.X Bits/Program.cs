namespace Problem_05.X_Bits
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private const int NumbersInInput = 8;
        private const int BitsInInteger = 32;
        private const char Zero = '0';
        private const char One = '1';

        private static void Main(string[] args)
        {
            var numbers = new int[NumbersInInput];
            for (var i = 0; i < NumbersInInput; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var binaryNumbers = new List<string>();
            for (var i = 0; i < NumbersInInput; i++)
            {
                var binaryNumber = Convert.ToString(numbers[i], 2);
                var length = binaryNumber.Length;
                binaryNumber = new string(Zero, BitsInInteger - length) + binaryNumber;
                binaryNumbers.Add(binaryNumber);
            }

            var xCount = 0;
            for (var i = 0; i < NumbersInInput - 2; i++)
            {
                for (var j = 0; j < BitsInInteger - 2; j++)
                {
                    if (binaryNumbers[i][j] != One || binaryNumbers[i][j + 1] != Zero || binaryNumbers[i][j + 2] != One)
                    {
                        continue;
                    }

                    if (binaryNumbers[i + 1][j] != Zero || binaryNumbers[i + 1][j + 1] != One || binaryNumbers[i + 1][j + 2] != Zero)
                    {
                        continue;
                    }

                    if (binaryNumbers[i + 2][j] == One && binaryNumbers[i + 2][j + 1] == Zero &&  binaryNumbers[i + 2][j + 2] == One)
                    {
                        xCount++;
                    }
                }
            }

            Console.WriteLine(xCount);
        }
    }
}
