namespace Problem04.CrossingSequencies
{
    using System;

    internal class Program
    {
        private const int NumberUpperLimit = 1000000;
        private static void Main(string[] args)
        {
            int tribFirst = int.Parse(Console.ReadLine());
            int tribSecond = int.Parse(Console.ReadLine());
            int tribThird = int.Parse(Console.ReadLine());

            int first = Math.Min(tribFirst, Math.Min(tribSecond, tribThird));
            int second = Math.Max(tribFirst, Math.Min(tribSecond, tribThird));
            int third = Math.Max(tribFirst, Math.Max(tribSecond, tribThird));
            int initNumber = int.Parse(Console.ReadLine());
            int firstStep = int.Parse(Console.ReadLine());
            int step = firstStep;

            int stepIndex = 0;
            while (initNumber < first)
            {
                if (stepIndex == 2)
                {
                    stepIndex = 0;
                    step += firstStep;
                }

                initNumber += step;
                stepIndex++;
            }

            if (first == initNumber)
            {
                Console.WriteLine(first);
                return;
            }

            while (initNumber < second)
            {
                if (stepIndex == 2)
                {
                    stepIndex = 0;
                    step += firstStep;
                }

                initNumber += step;
                stepIndex++;
            }

            if (second == initNumber)
            {
                Console.WriteLine(second);
                return;
            }

            while (initNumber < third)
            {
                if (stepIndex == 2)
                {
                    stepIndex = 0;
                    step += firstStep;
                }

                initNumber += step;
                stepIndex++;
            }

            if (initNumber > NumberUpperLimit)
            {
                Console.WriteLine("No");
                return;
            }

            if (third == initNumber)
            {
                Console.WriteLine(third);
                return;
            }

            int smallestCommonNumber = 0;
            int oldThird = tribThird;
            tribThird = tribFirst + tribSecond + tribThird;
            tribFirst = tribSecond;
            tribSecond = oldThird;

            while (true)
            {
                while (initNumber < tribThird)
                {
                    if (stepIndex == 2)
                    {
                        stepIndex = 0;
                        step += firstStep;
                    }

                    initNumber += step;
                    stepIndex++;
                }

                if (initNumber == tribThird)
                {
                    smallestCommonNumber = initNumber;
                    break;
                }

                if (initNumber > NumberUpperLimit)
                {
                    break;
                }

                while (tribThird < initNumber)
                {
                    oldThird = tribThird;
                    tribThird = tribFirst + tribSecond + tribThird;
                    tribFirst = tribSecond;
                    tribSecond = oldThird;
                }

                if (tribThird == initNumber)
                {
                    smallestCommonNumber = tribThird;
                    break;
                }

                if (tribThird > NumberUpperLimit)
                {
                    break;
                }    
            }

            if (smallestCommonNumber > 0)
            {
                Console.WriteLine(smallestCommonNumber);
                return;
            }

            Console.WriteLine("No");
        }
    }
}
