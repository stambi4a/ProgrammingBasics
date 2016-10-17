namespace Problem_04.Text_Bombardment
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var width = int.Parse(Console.ReadLine());
            var length = text.Length;
            var rows = length / width + 1;
            var matrix = new char[rows][];
            for (var i = 0; i < rows - 1; i++)
            {
                matrix[i] = text.Substring(i * width, width).ToCharArray();
            }

            var lastRowTextLength = length - width * (rows - 1);
            matrix[rows - 1] = (text.Substring(width * (rows - 1), lastRowTextLength) + new string(' ', length - lastRowTextLength)).ToCharArray();


            var columns = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var col in columns)
            {
                var index = 0;
                while (index < rows && matrix[index][col] == ' ')
                {
                    index++;
                }

                while (index < rows && matrix[index][col] != ' ')
                {
                    matrix[index][col] = ' ';
                    index++;
                }
            }

            for (var i = 0; i < rows - 1; i++)
            {
                Console.Write(new string(matrix[i]));
            }

            Console.WriteLine(new string(matrix[rows - 1]));
        }
    }
}
