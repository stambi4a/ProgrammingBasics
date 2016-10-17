namespace Problem_01.Simple_Calculation
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var xCoord = decimal.Parse(Console.ReadLine());
            var yCoord = decimal.Parse(Console.ReadLine());
            var pointPosition = 0;
            if (xCoord == 0 && yCoord != 0)
            {
                pointPosition = 5;
            }
            else if (xCoord != 0 && yCoord == 0)
            {
                pointPosition = 6;
            }

            if (xCoord > 0 && yCoord > 0)
            {
                pointPosition = 1;
            }

            if (xCoord < 0 && yCoord > 0)
            {
                pointPosition = 2;
            }

            if (xCoord < 0 && yCoord < 0)
            {
                pointPosition = 3;
            }

            if (xCoord > 0 && yCoord < 0)
            {
                pointPosition = 4;
            }

            Console.WriteLine(pointPosition);
        }
    }
}
