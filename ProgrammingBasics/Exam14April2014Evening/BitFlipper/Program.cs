namespace BitFlipper
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        private const int BitSequenceLength = 64;
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            string numberToBinary = Convert.ToString((long)number, 2);
            int length = numberToBinary.Length;
            StringBuilder binNumber = new StringBuilder();
            binNumber.Append(new string('0', BitSequenceLength - length));
            binNumber.Append(numberToBinary);
            string binaryNumber = binNumber.ToString();
            /*Console.WriteLine(binaryNumber);*/
            SortedSet<int> indices = new SortedSet<int>();
            int index = 0;
            while (true)
            {
                index = binaryNumber.IndexOf("111", index);
                if (index == -1)
                {
                    break;
                }

                indices.Add(index);
                index += 3;
            }

            index = 0;
            while (true)
            {
                index = binaryNumber.IndexOf("000", index);
                if (index == -1)
                {
                    break;
                }

                indices.Add(index);
                index += 3;
            }

            foreach (var ind in indices)
            {
                int shift = BitSequenceLength - ind - 1;               
                for (int i = 1; i <= 3; i++)
                {
                    ulong numberToCompare = 1ul << shift;
                    string binNumberToCompare = Convert.ToString((long)numberToCompare, 2);
                    number ^= numberToCompare;
                    binaryNumber = Convert.ToString((long)number, 2);
                    shift--;
                }
            }

            binaryNumber = Convert.ToString((long)number, 2);
            /*Console.WriteLine(binaryNumber);*/
            Console.WriteLine(number);
        }
    }
}
