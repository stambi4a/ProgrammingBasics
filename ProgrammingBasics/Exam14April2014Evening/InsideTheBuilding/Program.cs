using System;
using System.Collections.Generic;

namespace InsideTheBuilding
{
    class Program
    {
        private const string InsideResult = "inside";
        private const string OutsideResult = "outside";
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            List<string> checkResults = new List<string>();
            for (int i = 1; i <= 5; i++)
            {
                int xCoord = int.Parse(Console.ReadLine());
                int yCoord = int.Parse(Console.ReadLine());
                if (CheckPointIsInside(size, xCoord, yCoord))
                {
                    checkResults.Add(InsideResult);
                }
                else
                {
                    checkResults.Add(OutsideResult);
                }
            }

            Console.WriteLine(string.Join(string.Format("{0}", Environment.NewLine), checkResults));
        }

        static bool CheckPointIsInside(int size, int xCoord, int yCoord)
        {
            if (xCoord >= 0 && yCoord <= size && xCoord <= 3 * size && yCoord >= 0)
            {
                return true;
            }

            if (xCoord >= size && yCoord <= 4 * size && xCoord <= 2 * size && yCoord >= size)
            {
                return true;
            }

            return false;
        }
    }
}
