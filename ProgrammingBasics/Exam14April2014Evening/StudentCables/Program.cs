namespace StudentCables
{
    using System;

    class Program
    {
        private const int minCableLength = 20;
        private const int CantimetersInMeter = 100;
        private const int CableLength = 500;
        private const int RJ32TrimLength = 2;
        private const int JoinLength = 3;

        static void Main(string[] args)
        {
            int piecesCount = int.Parse(Console.ReadLine());
            int wholeCableLength = 0;
            int finalPiecesCount = 0;
            for (int i = 0; i < piecesCount; i++)
            {
                int cableSize = int.Parse(Console.ReadLine());
                string measure = Console.ReadLine();
                if (measure.Equals("meters"))
                {
                    cableSize *= CantimetersInMeter;
                }

                if (cableSize >= minCableLength)
                {
                    wholeCableLength += cableSize;
                    finalPiecesCount++;
                }
            }

            wholeCableLength -= (finalPiecesCount - 1) * JoinLength;
            int materialPerCable = 2 * RJ32TrimLength + CableLength;
            int cablesCount = wholeCableLength / materialPerCable;
            int remainder = wholeCableLength % materialPerCable;
            Console.WriteLine(cablesCount);
            Console.WriteLine(remainder);
        }
    }
}
