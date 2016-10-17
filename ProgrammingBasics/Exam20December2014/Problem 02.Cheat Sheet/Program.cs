namespace Problem_02.Cheat_Sheet
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var rows = long.Parse(Console.ReadLine());
            var columns = long.Parse(Console.ReadLine());
            var startingHorizontal = long.Parse(Console.ReadLine());
            var startingVertical = long.Parse(Console.ReadLine());
            var matrix = new long[rows][];
            for (var i = 0; i < rows; i++)
            {
                matrix[i] = new long[columns];
                for (var j = 0; j < columns; j++)
                {
                    matrix[i][j] = (startingHorizontal + i) * (startingVertical + j);
                }
            }
            for (var i = 0; i < rows; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }
            
    }
}
