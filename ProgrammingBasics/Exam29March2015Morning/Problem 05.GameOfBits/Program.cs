namespace Problem_05.GameOfBits
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var number = uint.Parse(Console.ReadLine());
            while (true)
            {
                var command = Console.ReadLine();
                if (command.Equals("Game Over!"))
                {
                    break;
                }

                var binary = Convert.ToString(number, 2);
                var length = binary.Length;

                var newNumber = 0u;
                var start = 0;
                if (command.Equals("Even"))
                {
                    start = 1;
                }

                for (var i = start; i < length; i = i + 2)
                {
                    newNumber |= (number & (1u << i)) >> ((i + 1) / 2);
                }

                number = newNumber;
            }

            var onesCount = Convert.ToString(number, 2).Count(digit => digit == '1');

            Console.WriteLine($"{number} -> {onesCount}");
        }
    }
}
