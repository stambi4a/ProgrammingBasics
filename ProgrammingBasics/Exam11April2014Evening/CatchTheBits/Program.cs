namespace Problem05.BitKiller
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    internal class Program
    {
        private const int BitsInByte = 8;
        private static void Main(string[] args)
        {
            int byteCount = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 1; i <= byteCount; i++)
            {
                int byteNumber = int.Parse(Console.ReadLine());
                string binaryNumber = Convert.ToString(byteNumber, 2);
                strBuilder.Append(new string('0', BitsInByte - binaryNumber.Length));
                strBuilder.Append(binaryNumber);
            }

            string joinedBytes = strBuilder.ToString();
            int length = joinedBytes.Length;
            int startingBit = 1;
            int killedBits = (length - startingBit - 1) / step + 1;
            strBuilder.Clear();
/*
            for (int i = 0; i < startingBit; i++)
            {
                strBuilder.Append(joinedBytes[i]);
            }*/

            for (int i = 0; i < killedBits; i++)
            {
                strBuilder.Append(joinedBytes[i * step + startingBit]);
            }

            int trailingZerosLength = strBuilder.Length % BitsInByte > 0
                                          ? BitsInByte - strBuilder.Length % BitsInByte
                                          : 0;
            strBuilder.Append(new string('0', trailingZerosLength));
            string bytesAfterKillingBits = strBuilder.ToString();

            int newBytesCount = bytesAfterKillingBits.Length / BitsInByte;
            var bytes = new List<int>();
            for (int i = 0; i < newBytesCount; i++)
            {
                string byteString = bytesAfterKillingBits.Substring(i * BitsInByte, BitsInByte);
                int byteNumber = Convert.ToInt32(byteString, 2);
                bytes.Add(byteNumber);
            }

            Console.WriteLine(string.Join(Environment.NewLine, bytes));
        }
    }
}
