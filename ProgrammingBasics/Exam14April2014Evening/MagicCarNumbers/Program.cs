namespace MagicCarNumbers
{
    using System;

    class Program
    {
        private static int[] letterNumericValues;
        private const int NumericValuesCount = 10;
        private const int MinDigitSum = 0;
        private const int MaxDigitSum = 36;
        private const int MinMagicWeight = 20;
        private const int MaxMagicWeight = 516;
        private const int MaxDigit = 9;
        static void Main(string[] args)
        {
            letterNumericValues = new[] { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int countCars = 0;
            int magicCarWeight = int.Parse(Console.ReadLine());
            magicCarWeight -= letterNumericValues[2] + letterNumericValues[0];
            if (magicCarWeight < MinMagicWeight || magicCarWeight > MaxMagicWeight)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < NumericValuesCount; i++)
            {
                if(magicCarWeight - 2 * letterNumericValues[i] < MinDigitSum)
                {
                    break;
                }

                int factor = 1;
                for(int j = i; j < NumericValuesCount; j++)
                {
                    if (i < j)
                    {
                        factor = 2;
                    }

                    int sumBackLetters = letterNumericValues[i] + letterNumericValues[j];

                    int remainder = magicCarWeight - sumBackLetters;
                    if (remainder < MinDigitSum)
                    {
                        break;
                    }

                    if (remainder <= MaxDigitSum)
                    {
                        int k = 0;
                        while (remainder >= k && k <= MaxDigit)
                        {
                            if (4 * k == remainder)
                            {
                                countCars += factor;
                                k++;
                                continue;
                            }

                            if (remainder - k <= 3 * MaxDigit && (remainder - k) % 3 == 0)
                            {
                                countCars += 2 * factor;
                            }

                            if (remainder >= 2 * k && remainder - 2 * k <= 2 * MaxDigit && (remainder - 2 * k) % 2 == 0)
                            {
                                countCars += 3 * factor;
                            }

                            k++;
                        }                 
                    }

                    /*if (remainder <= MaxDigitSum)
                    {
                        if (remainder % 2 == 0)
                        {
                            int sumTwoDigits = remainder / 2;
                            int k = 0;
                            while (k + MaxDigit < sumTwoDigits)
                            {
                                k++;
                            }

                            while (k < sumTwoDigits - k)
                            {
                                countCars += 6 * factor;
                                k++;
                            }
                            if (2 * k == sumTwoDigits)
                            {
                                countCars += factor;
                            }
                            else
                            {
                                countCars += 6 * factor;
                            }
                        }

                        if (remainder % 2 == 0)
                        {

                            int k = 1;
                            while (remainder - k > 3 * MaxDigit)
                            {
                                k += 2;
                            }

                            while (k <= MaxDigit && k <= remainder)
                            {
                                countCars += 2 * factor;
                                k += 6;
                            }
                        }


                        if (remainder % 2 == 1)
                        {
                            int k = 0;
                            while (remainder - k > 3 * MaxDigit)
                            {
                                k++;
                            }

                            while (k <= MaxDigit && k <= remainder && (remainder - k) % 3 != 0)
                            {
                                k++;
                            }

                            while (k <= MaxDigit && k <= remainder && (remainder - k) % 3 == 0)
                            {
                                countCars += 2 * factor;
                                k += 3;
                            }   
                        }
                    }*/

                }               
            }

            Console.WriteLine(countCars);
        }
    }
}
