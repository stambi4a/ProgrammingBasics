namespace Problem_03.Eclipse
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var frameWidth = num * 2;
            var glassBuilder = new StringBuilder();
            var bridgeWidth = num - 1;
            var glassLine = " " + new string('*', frameWidth - 2) + " ";
            var bridgeSpace = new string(' ', bridgeWidth);
            var bridge = new string('-', bridgeWidth);
            var upperLine = glassLine + bridgeSpace + glassLine;

            glassBuilder.Append(upperLine + Environment.NewLine);//upperLine

            var lensLine = new string('/', frameWidth - 2);
            var middleGlassLine = "*" + lensLine + "*";
            var middleLine = middleGlassLine + bridgeSpace + middleGlassLine;

            glassBuilder.Append(string.Join(Environment.NewLine, Enumerable.Repeat(middleLine, (num - 3) / 2)));//middleLine above bridge

            if (num > 3)
            {
                glassBuilder.Append(Environment.NewLine);
            }

            var bridgeLine = middleGlassLine + bridge + middleGlassLine;

            glassBuilder.Append(bridgeLine + Environment.NewLine);//bridgeLine

            glassBuilder.Append(string.Join(Environment.NewLine, Enumerable.Repeat(middleLine, (num - 3) / 2)));//middleLine below bridge

            if (num > 3)
            {
                glassBuilder.Append(Environment.NewLine);
            }

            glassBuilder.Append(upperLine + Environment.NewLine);//bottomLine

            Console.WriteLine(glassBuilder.ToString());
        }
    }
}
