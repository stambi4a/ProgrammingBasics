namespace Problem_01.Tic_Tac_Tow_Power
{
    using System;

    internal class Program
    {
        private const int TicTacToeSize = 3;
        private static void Main(string[] args)
        {
            var yCoord = byte.Parse(Console.ReadLine());
            var xCoord = byte.Parse(Console.ReadLine());

            var valueFirstCell = byte.Parse(Console.ReadLine());

            var indexGivenCell = xCoord * TicTacToeSize + yCoord;
            long value = (long)Math.Pow(valueFirstCell + indexGivenCell, indexGivenCell + 1);
            Console.WriteLine(value);

        }
    }
}
