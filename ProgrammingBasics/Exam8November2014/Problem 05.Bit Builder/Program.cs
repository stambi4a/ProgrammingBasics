namespace Problem_05.Bit_Builder
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = ulong.Parse(Console.ReadLine());
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Equals("quit"))
                {
                    break;
                }

                var position = int.Parse(input);
                var command = Console.ReadLine();
                switch (command)
                {
                    case "flip":
                        {
                           FlipBit(position, ref number); 
                        }

                        break;

                    case "remove":
                        {
                            RemoveBit(position, ref number);
                        }

                        break;

                    case "insert":
                        {
                            InsertBit(position, ref number);
                        }

                        break;
                }
            }

            Console.WriteLine(number);
        }

        private static void FlipBit(int position, ref ulong number)
        {
            var mask = 1ul << position;
            var bit = ~(number & mask) & mask;
            number = (number & ~mask) | bit;
        }

        private static void RemoveBit(int position, ref ulong number)
        {
            var length = Convert.ToString((long)number, 2).Length;
            if (position >= length)
            {
                return;
            }

            for (var i = position + 1; i < length; i++)
            {
                number = (number & 1ul << i) >> 1 | (number & ~(1ul << (i - 1)));
            }


            number &= ~(number & 1ul << (length - 1));
        }

        private static void InsertBit(int position, ref ulong number)
        {
            var length = Convert.ToString((long)number, 2).Length;
            /*number |= (number & 1ul << (length - 1)) << 1;*/
            for (var i = length - 1; i >= position; i--)
            {
                number = (number & 1ul << i) << 1 | (number & ~(1ul << (i + 1)));
            }


            number |= 1ul << position;
        }
    }
}
