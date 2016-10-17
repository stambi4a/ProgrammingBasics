namespace Problem_03.Disk
{
    using System;

    internal class Program
    {
        private static char[,] grid;
        private static void Main(string[] args)
        {
            var sizeGrid = int.Parse(Console.ReadLine());
            grid = new char[sizeGrid, sizeGrid];
            var radius = int.Parse(Console.ReadLine());

            var centerX = sizeGrid / 2;
            var centerY = sizeGrid / 2;

            for (var i = 0; i < sizeGrid; i++)
            {
                for (var j = 0; j < sizeGrid; j++)
                {
                    if (Math.Sqrt(Math.Pow(i - centerX, 2) + Math.Pow(j - centerY, 2)) > radius)
                    {
                        grid[i, j] = '.';
                    }
                    else
                    {
                        grid[i, j] = '*';
                    }
                }
            }

            for (var i = 0; i < sizeGrid; i++)
            {
                for (var j = 0; j < sizeGrid; j++)
                {
                    Console.Write(grid[i, j]);
                }

                Console.WriteLine();
            }
        }
    }
}
