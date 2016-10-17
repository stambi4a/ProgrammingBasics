namespace OddEvenElements
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    internal  class Program
    {
        private static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                    Console.WriteLine("OddSum=No, OddMin=No, OddMax=No, EvenSum=No, EvenMin=No, EvenMax=No");
                    return;
            }
            var numbers = input.Split().Select(decimal.Parse).ToArray();
            var oddNumbers = new List<decimal>();
            for (int i = 0; i < numbers.Length; i = i + 2)
            {
                oddNumbers.Add(numbers[i]);
            }

            var evenNumbers = new List<decimal>();
            for (int i = 1; i < numbers.Length; i = i + 2)
            {
                evenNumbers.Add(numbers[i]);
            }

            bool hasOddNumbers = false;
            decimal sumOdd = 0;
            decimal minOdd = 0;
            decimal maxOdd = 0;
            if (oddNumbers.Count > 0)
            {
                sumOdd = oddNumbers.Sum();
                minOdd = oddNumbers.Min();
                maxOdd = oddNumbers.Max();
                hasOddNumbers = true;
            }


            decimal sumEven = 0;
            decimal minEven = 0;
            decimal maxEven = 0;
            bool hasEvenNumbers = false;
            if (evenNumbers.Count > 0)
            {
                sumEven = evenNumbers.Sum();
                minEven = evenNumbers.Min();
                maxEven = evenNumbers.Max();
                hasEvenNumbers = true;
            }
           
            Console.WriteLine((hasOddNumbers ? $"OddSum={sumOdd:G14}, OddMin={minOdd:G14}, OddMax={maxOdd:G14}," : "OddSum=No, OddMin=No, OddMax=No,")
                              + (hasEvenNumbers ? $" EvenSum={sumEven:G14}, EvenMin={minEven:G14}, EvenMax={maxEven:G14}" : " EvenSum=No, EvenMin=No, EvenMax=No"));
        }
    }
}
