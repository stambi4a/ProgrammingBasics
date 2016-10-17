namespace ProgrammerDNA
{
    using System;
    using System.Text;

    internal class Program
    {
        private const string DnaMainSequence = "ABCDEFG";
        private const int ChainCycleLength = 7;

        private static void Main(string[] args)
        {
            int dnaChainLength = int.Parse(Console.ReadLine());
            char startingChar = char.Parse(Console.ReadLine());
            int indexStartingChar = DnaMainSequence.IndexOf(startingChar);
/*            Console.WriteLine((7 - ((7 - 7 + 1) % 7 - 1) * 2 - 1) / 2);*/
            RecursionCreateChain(0, dnaChainLength, indexStartingChar);
        }

        private static void RecursionCreateChain(int index, int chainLength, int indexStartingChar)
        {
            if (index == chainLength)
            {
                return;
            }

            int remainder = index % ChainCycleLength;
            int charStartingIndex = remainder <= ChainCycleLength / 2
                ? (ChainCycleLength - remainder * 2 - 1) / 2
                : (ChainCycleLength - (ChainCycleLength - remainder - 1) * 2 - 1) / 2;
            StringBuilder currentLine = new StringBuilder(7);
            for (int j = 0; j < charStartingIndex; j++)
            {
                currentLine.Append('.');
            }

            for (int j = charStartingIndex; j < ChainCycleLength - charStartingIndex; j++)
            {
                if (indexStartingChar == 7)
                {
                    indexStartingChar = 0;
                }

                currentLine.Append(DnaMainSequence[indexStartingChar++]);
            }

            for (int j = ChainCycleLength - charStartingIndex; j < ChainCycleLength; j++)
            {
                currentLine.Append('.');
            }

            Console.WriteLine(currentLine.ToString());

            RecursionCreateChain(index + 1, chainLength, indexStartingChar);
        }
    }
}
