namespace BitShooter
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private const int BitsInLongNumber = 64;
        private static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                BlastBinaryNumber(ref number);
            }

            /*ulong number = (ulong.MaxValue);
            Console.WriteLine(number);
            string binaryNumber = Convert.ToString((long)number, 2);
            Console.WriteLine(binaryNumber);*/

            string numberToBinaryString = Convert.ToString((long)number, 2);
            StringBuilder strBuilder = new StringBuilder();
            strBuilder.Append(new string('0', BitsInLongNumber - numberToBinaryString.Length));
            strBuilder.Append(numberToBinaryString);
            string binaryNumber = strBuilder.ToString();
            int leftOnesCount = binaryNumber.Substring(0, BitsInLongNumber / 2).ToCharArray().Where(x => x == '1').Count();
            Console.WriteLine("left: " + leftOnesCount);

            int rightOnesCount = binaryNumber.Substring(BitsInLongNumber / 2, BitsInLongNumber / 2).ToCharArray().Where(x => x == '1').Count();
            Console.WriteLine("right: " + rightOnesCount);
        }

        private static void BlastBinaryNumber(ref ulong number)
        {
            string[] input = Console.ReadLine().Split();
            int center = int.Parse(input[0]);
            int radius = int.Parse(input[1]) / 2;
            int leftBorder = center - radius > 0 ? center - radius : 0;
            int rightBorder = radius + center < BitsInLongNumber - 1 ? radius + center : BitsInLongNumber - 1;
           
            for (int j = leftBorder; j <= rightBorder; j++)
            {
                ulong pairNumber = ulong.MaxValue ^ (1ul << j);
                number &= pairNumber;
                string numberToBinaryString = Convert.ToString((long)number, 2);
                StringBuilder strBuilder = new StringBuilder();
                strBuilder.Append(new string('0', BitsInLongNumber - numberToBinaryString.Length));
                strBuilder.Append(numberToBinaryString);
                string binaryNumber = strBuilder.ToString();
            }         
        }
    }
}
