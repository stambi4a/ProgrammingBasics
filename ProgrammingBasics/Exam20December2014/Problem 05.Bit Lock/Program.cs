namespace Problem_05.Bit_Lock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private const int Rows = 8;
        private const int Columns = 12;

        private static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var binaryNumbers = numbers.Select(number => Convert.ToString(number, 2)).ToList();
            for (var i = 0; i < Rows; i++)
            {
                binaryNumbers[i] = new string('0', Columns - binaryNumbers[i].Length) + binaryNumbers[i];
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("end"))
                {
                    PrintRows(binaryNumbers);
                    break;
                }

                var inputParams = input.Split();
                if (inputParams[0].Equals("check"))
                {
                    var col = int.Parse(inputParams[1]);
                    CountBitsInAAcolumn(col, binaryNumbers);
                    continue;
                }

                var row = int.Parse(inputParams[0]);
                var count = int.Parse(inputParams[2]);
                var direction = inputParams[1];
                RotateRow(row, count, direction, binaryNumbers);
            }
        }

        private static void PrintRows(IEnumerable<string> binaryNumbers)
        {
            var numbers = binaryNumbers.Select(number => Convert.ToInt32(number, 2));
            Console.WriteLine(string.Join(" ", numbers));
        }

        private static void CountBitsInAAcolumn(int col, IEnumerable<string> binaryNumbers)
        {
            var bitCount = binaryNumbers.Count(number => number[Columns - col - 1] == '1');
            Console.WriteLine(bitCount);
        }

        private static void RotateRow(int row, int count, string direction, IList<string> binaryNumbers)
        {
            var number = Convert.ToInt32(binaryNumbers[row], 2);
            var shift = count % Columns;
            if(direction.Equals("right"))
            {
                for (var i = 1; i <= shift; i++)
                {
                    var zeroBit = number & 1;
                    number >>= 1;
                    number |= zeroBit << Columns - 1;
                }
                
            }
            else
            {
                for (var i = 1; i <= shift; i++)
                {
                    var endBit = number & (1 << Columns - 1);
                    number <<= 1;
                    number |= endBit >> Columns - 1;
                }

                for (var i = Columns; i < Columns + shift; i++)
                {
                    number &= ~(1 << i);
                }
            }

            binaryNumbers[row] = Convert.ToString(number, 2).PadLeft(Columns, '0');
        }
    }
}
