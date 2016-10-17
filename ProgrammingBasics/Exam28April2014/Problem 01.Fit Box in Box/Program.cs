namespace Problem_01.Fit_Box_in_Box
{
    using System;
    using System.Collections.Generic;

    internal class Program
    {
        private const int CountDimensions = 3;

        private static void Main(string[] args)
        {
            var smallerBoxDimensions = new List<string>();
            var secondBoxDimensions = new int[CountDimensions];
            var firstBoxDimensions = new int[CountDimensions];
            for (var i = 0; i < 3; i++)
            {
                firstBoxDimensions[i] = int.Parse(Console.ReadLine());
            }

            for (var i = 0; i < 3; i++)
            {
                secondBoxDimensions[i] = int.Parse(Console.ReadLine());
            }

            string biggerBoxDimensions =
                $"({secondBoxDimensions[0]}, {secondBoxDimensions[1]}, {secondBoxDimensions[2]})";
            for (var i = 0; i < CountDimensions; i++)
            {
                for (var j = 0; j < CountDimensions; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    for (var k = 0; k < CountDimensions; k++)
                    {
                        if (k == j || k == i)
                        {
                            continue;
                        }

                        if (firstBoxDimensions[i] > secondBoxDimensions[0]
                            && firstBoxDimensions[j] > secondBoxDimensions[1]
                            && firstBoxDimensions[k] > secondBoxDimensions[2])
                        {
                            smallerBoxDimensions.Add($"{biggerBoxDimensions} < ({firstBoxDimensions[i]}, {firstBoxDimensions[j]}, {firstBoxDimensions[k]})");
                        }
                    }
                }
            }

            if (smallerBoxDimensions.Count == 0)
            {
                biggerBoxDimensions =
                $"({firstBoxDimensions[0]}, {firstBoxDimensions[1]}, {firstBoxDimensions[2]})";

                for (var i = 0; i < CountDimensions; i++)
                {
                    for (var j = 0; j < CountDimensions; j++)
                    {
                        if (i == j)
                        {
                            continue;
                        }

                        for (var k = 0; k < CountDimensions; k++)
                        {
                            if (k == j || k == i)
                            {
                                continue;
                            }

                            if (secondBoxDimensions[i] > firstBoxDimensions[0]
                                && secondBoxDimensions[j] > firstBoxDimensions[1]
                                && secondBoxDimensions[k] > firstBoxDimensions[2])
                            {
                                smallerBoxDimensions.Add($"{biggerBoxDimensions} < ({secondBoxDimensions[i]}, {secondBoxDimensions[j]}, {secondBoxDimensions[k]})");
                            }
                        }
                    }
                }
            }

            if (smallerBoxDimensions.Count == 0)
            {
                return;
            }

            Console.WriteLine(string.Join(Environment.NewLine, smallerBoxDimensions));
        }
    }
}
