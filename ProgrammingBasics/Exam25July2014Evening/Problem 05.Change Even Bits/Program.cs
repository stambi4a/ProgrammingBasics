namespace Problem_05.Change_Even_Bits
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var numberCount = int.Parse(Console.ReadLine());
            var numbers = new List<int>();
            for (var i = 0; i < numberCount; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }


            var numberToChange = ulong.Parse(Console.ReadLine());
            var evenBitsManipulated = 0;
            var changedBits = 0;
            for (var i = 0; i < numberCount; i++)
            {
                var binaryNumber = Convert.ToString(numbers[i], 2);
                var evenBitsToChange = binaryNumber.Length;
               
                for (var j = evenBitsToChange; j > evenBitsManipulated; j--)
                {
                    var bitIndex = 2 * (j - 1);
                    var mask = 1ul << bitIndex;
                    var checkNumber = numberToChange & mask;
                    if (checkNumber == 0)
                    {
                        changedBits++;
                    }

                    numberToChange |= mask;
                }

                evenBitsManipulated = evenBitsToChange;
            }

            Console.WriteLine(numberToChange + Environment.NewLine + changedBits);
        }
    }
}
