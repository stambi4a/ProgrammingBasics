namespace Arrow
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Program
    {
        private static List<string> lineStrings;
        static void Main(string[] args)
        {
            int baseLength = int.Parse(Console.ReadLine());
            lineStrings = new List<string>();
            DrawArrowBaseLine(baseLength);
            DrawArrowBase(baseLength);
            DrawArrowPointerBaseLine(baseLength);
            DrawArrowPointer(baseLength);
            DrawArrowPointerTip(baseLength);

            Console.WriteLine(string.Join(Environment.NewLine, lineStrings));
        }

        private static void DrawArrowPointerTip(int baseLength)
        {
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 1; i < baseLength; i++)
            {
                strBuilder.Append('.');
            }

            strBuilder.Append('#');

            for (int i = 1; i < baseLength; i++)
            {
                strBuilder.Append('.');
            }

            lineStrings.Add(strBuilder.ToString());

        }

        private static void DrawArrowPointer(int baseLength)
        {
            for (int j = 1; j <= baseLength - 2; j++)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int i = 1; i <= j; i++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('#');

                int distance = 2 * baseLength - 2 * (j + 1) - 1;
                for (int i = 1; i <= distance; i++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('#');

                for (int i = 1; i <= j; i++)
                {
                    strBuilder.Append('.');
                }

                lineStrings.Add(strBuilder.ToString());
            }         
        }

        private static void DrawArrowPointerBaseLine(int baseLength)
        {
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i <= baseLength / 2; i++)
            {
                strBuilder.Append('#');
            }

            for (int i = 1; i <= baseLength - 2; i++)
            {
                strBuilder.Append('.');
            }

            for (int i = 0; i <= baseLength / 2; i++)
            {
                strBuilder.Append('#');
            }

            lineStrings.Add(strBuilder.ToString());
        }

        private static void DrawArrowBaseLine(int baseLength)
        {
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 1; i <= baseLength / 2; i++)
            {
                strBuilder.Append('.');
            }

            for (int i = 1; i <= baseLength; i++)
            {
                strBuilder.Append('#');
            }

            for (int i = 1; i <= baseLength / 2; i++)
            {
                strBuilder.Append('.');
            }

            lineStrings.Add(strBuilder.ToString());
        }

        private static void DrawArrowBase(int baseLength)
        {
            for (int i = 1; i <= baseLength - 2; i++)
            {
                StringBuilder strBuilder = new StringBuilder();
                for (int j = 1; j <= baseLength / 2; j++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('#');

                for (int j = 1; j <= baseLength - 2; j++)
                {
                    strBuilder.Append('.');
                }

                strBuilder.Append('#');

                for (int j = 1; j <= baseLength / 2; j++)
                {
                    strBuilder.Append('.');
                }

                lineStrings.Add(strBuilder.ToString());
            }
        }
    }
}
