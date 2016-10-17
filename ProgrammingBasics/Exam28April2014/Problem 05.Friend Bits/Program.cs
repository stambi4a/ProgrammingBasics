namespace Problem_05.Friend_Bits
{
    using System;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = uint.Parse(Console.ReadLine());
            if (number <= 1)
            {
                Console.WriteLine(number);
                Console.WriteLine(0);
                return;
            }

            var binaryNumber = Convert.ToString(number, 2);
            var length = binaryNumber.Length;
            var friendBitsBuilder = new StringBuilder();
            var aloneBitsBuilder = new StringBuilder();

            var counter = 1;
            for (var i = 0; i < length - 1; i++)
            {
                if (binaryNumber[i] == binaryNumber[i + 1])
                {
                    friendBitsBuilder.Append(binaryNumber[i]);
                    counter++;
                }
                else if (counter > 1)
                {
                    friendBitsBuilder.Append(binaryNumber[i]);
                    counter = 1;
                }
                else
                {
                    aloneBitsBuilder.Append(binaryNumber[i]);
                }
            }

            if (binaryNumber[length - 1] == binaryNumber[length - 2])
            {
                friendBitsBuilder.Append(binaryNumber[length - 1]);
            }
            else
            {
                aloneBitsBuilder.Append(binaryNumber[length - 1]);
            }

            var friendbitsNumber = ConvertBinaryNumberToNumber(friendBitsBuilder.ToString());
            var aloneBitsNumber = ConvertBinaryNumberToNumber(aloneBitsBuilder.ToString());
            Console.WriteLine(friendbitsNumber);
            Console.WriteLine(aloneBitsNumber);
        }

        private static int ConvertBinaryNumberToNumber(string binaryNumber)
        {
            var length = binaryNumber.Length;
            var number = 0;
            for (var i = length - 1; i >= 0; i--)
            {
                number = number | (binaryNumber[i] - '0') << (length - 1 - i);
            }

            return number;
        }
    }
}
