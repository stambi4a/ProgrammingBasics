namespace Problem_04.Encrypted_Matrix
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var length = input.Length;
            var number = string.Empty;
            for(var i = 0; i < length; i++)
            {
                number += input[i] % 10;
            }

            var encrypted = string.Empty;
            for (var i = 0; i < number.Length; i++)
            {
                var numToAppend = number[i] - '0';
                if (number[i] % 2 == 0)
                {
                    numToAppend *= number[i] - '0';
                }
                else
                {
                    if (i < number.Length - 1)
                    {
                        numToAppend += number[i + 1] - '0';
                    }

                    if ( i > 0)
                    {
                        numToAppend += number[i - 1] - '0';
                    }
                }

                encrypted += numToAppend;
            }

            var encryptedLength = encrypted.Length;

            var matrix = new char[encryptedLength][];
            for (var i = 0; i < encryptedLength; i++)
            {
                matrix[i] = Enumerable.Repeat('0', encryptedLength).ToArray();
            }

            var direction = char.Parse(Console.ReadLine());
            if (direction == '/')
            {
                for (var i = 0; i < encryptedLength; i++)
                {
                    matrix[encryptedLength - i - 1][i] = encrypted[i];
                }
            }
            else
            {
                for (var i = 0; i < encryptedLength; i++)
                {
                    matrix[i][i] = encrypted[i];
                }
            }

            for (var i = 0; i < encryptedLength; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
            
        }
    }
}
