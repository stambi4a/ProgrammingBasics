namespace Problem_05.Double_Downs
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            var countVertical = 0;
            var countLeftDiagonal = 0;
            var countRightDiagonal = 0;

            var upperNumber = int.Parse(Console.ReadLine());
            for (var i = 1; i < numberCount; i++)
            {
                var lowerNumber = int.Parse(Console.ReadLine());

                var verticalNumber = upperNumber & lowerNumber;
                var verticalNumberCouples = Convert.ToString(verticalNumber, 2).Count(x => x == '1');
                countVertical += verticalNumberCouples;

                var leftDiagonalNumber = upperNumber & (lowerNumber >> 1);
                var leftDiagonalNumberCouples = Convert.ToString(leftDiagonalNumber, 2).Count(x => x == '1');
                countLeftDiagonal += leftDiagonalNumberCouples;

                var rightDiagonalNumber = upperNumber & (lowerNumber << 1);
                var rightDiagonalNumberCouples = Convert.ToString(rightDiagonalNumber, 2).Count(x => x == '1');
                countRightDiagonal += rightDiagonalNumberCouples;


                upperNumber = lowerNumber;
            }

            Console.WriteLine(countRightDiagonal);
            Console.WriteLine(countLeftDiagonal);
            Console.WriteLine(countVertical);
        }
    }
}
