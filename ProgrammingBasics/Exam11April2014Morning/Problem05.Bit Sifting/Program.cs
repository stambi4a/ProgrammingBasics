namespace Problem05.Bit_Sifting
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int siftsCount = int.Parse(Console.ReadLine());

            for (int i = 1; i <= siftsCount; i++)
            {
                ulong sift = ulong.Parse(Console.ReadLine());
                number = (number ^ sift) & number;
            }

            char[] binaryNumber = Convert.ToString((long)number, 2).ToCharArray();
            var onesCount = binaryNumber.Where(x => x == '1').Count();
            Console.WriteLine(onesCount);
        }
    }
}
