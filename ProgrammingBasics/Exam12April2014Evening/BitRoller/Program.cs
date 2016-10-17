namespace BitRoller
{
    using System;
    using System.Text;

    internal class Program
    {
        private const int BinaryStringLength = 19;
        private static int maxNumberGivenMaxNumberOfBits;
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int pillar = int.Parse(Console.ReadLine());
            int rollCount = int.Parse(Console.ReadLine());
            maxNumberGivenMaxNumberOfBits = CalculateNumber();

            
            for (int i = 1; i <= rollCount; i++)
            {
                RollBinaryNumber(ref number, pillar);
            }

            Console.WriteLine(number);
        }

        private static int CalculateNumber()
        {
            int number = 0;
            for (int i = 0; i < BinaryStringLength; i++)
            {
                number += 1 << i;
            }

            return number;

        }

        private static void RollBinaryNumber(ref int number, int pillar)
        {
            int lastDigit = number & 1;
            if (pillar == 0)
            {
                lastDigit = (number & (1 << 1)) >> 1;
            }

            for (int i = 18; i > pillar; i--)
            {               
                int previousDigit = (number & (1 << i)) >> i;
                int maskZero = maxNumberGivenMaxNumberOfBits ^ (1 << i);
                int mask = lastDigit << i;
                number = (number & maskZero) | mask;
                string binaryNumber = Convert.ToString(number, 2);
                binaryNumber = new string('0', BinaryStringLength - binaryNumber.Length) + binaryNumber;
                lastDigit = previousDigit;
            }

            for (int i = pillar - 1; i >= 0; i--)
            {
                int previousDigit = (number & (1 << i)) >> i;
                int maskZero = maxNumberGivenMaxNumberOfBits ^ (1 << i);
                int mask = lastDigit << i;
                number = (number & maskZero) | mask;
                string binaryNumber = Convert.ToString(number, 2);
                binaryNumber = new string('0', BinaryStringLength - binaryNumber.Length) + binaryNumber;
                lastDigit = previousDigit;
            }
        }
    }
}
