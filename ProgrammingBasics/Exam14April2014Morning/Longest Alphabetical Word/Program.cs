namespace Longest_Alphabetical_Word
{
    using System;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int size = int.Parse(Console.ReadLine());
            int stringLength = size * size;
            int wordRepeatCount = stringLength / word.Length + 1;
            StringBuilder strBuilder = new StringBuilder();
            for (int i = 1; i <= wordRepeatCount; i++)
            {
                strBuilder.Append(word);
            }

            string appendedWords = strBuilder.ToString();
            char[][] square = new char[size][];
            for (int i = 0; i < size; i++)
            {
                square[i] = appendedWords.Substring(size * i, size).ToCharArray();
            }

            string longestWord = FindLongestWordInSquare(square);
            Console.WriteLine(longestWord);
        }

        private static string FindLongestWordInSquare(char[][] square)
        {
            string longestWord = string.Empty;
            longestWord = FindLongestWordLeftToRight(square, longestWord);
            longestWord = FindLongestWordRightToLeft(square, longestWord);
            longestWord = FindLongestWordTopToBottom(square, longestWord);
            longestWord = FindLongestWordBottomToTop(square, longestWord);
            return longestWord;
        }

        private static string FindLongestWordLeftToRight(char[][] square, string longestWord)
        {
            longestWord = square[0][0].ToString();
            int size = square.Length;
            for (int i = 0; i < size; i++)
            {
                int j = 1;
                StringBuilder word = new StringBuilder();
                word.Append(square[i][0]);
                while (j < size)
                {
                    while (j < size && square[i][j] > square[i][j - 1])
                    {
                        word.Append(square[i][j]);
                        j++;
                    }

                    string wordString = word.ToString();
                    if (word.Length > longestWord.Length ||
                        word.Length == longestWord.Length && wordString.CompareTo(longestWord) < 0)
                    {
                        longestWord = wordString;
                    }

                    word = new StringBuilder();
                    if (j < size)
                    {
                        word.Append(square[i][j]);
                        j++;
                    }
                }
            }



            return longestWord;
        }

        private static string FindLongestWordRightToLeft(char[][] square, string longestWord)
        {
            int size = square.Length;
            for (int i = 0; i < size; i++)
            {
                int j = size - 2;
                StringBuilder word = new StringBuilder();
                word.Append(square[i][size - 1]);
                while (j >= 0)
                {
                    while (j >= 0 && square[i][j] > square[i][j + 1])
                    {
                        word.Append(square[i][j]);
                        j--;
                    }

                    string wordString = word.ToString();
                    if (word.Length > longestWord.Length ||
                        word.Length == longestWord.Length && wordString.CompareTo(longestWord) < 0)
                    {
                        longestWord = wordString;
                    }

                    word = new StringBuilder();
                    if (j >= 0)
                    {
                        word.Append(square[i][j]);
                        j--;
                    }
                }
            }

            return longestWord;
        }

        private static string FindLongestWordTopToBottom(char[][] square, string longestWord)
        {
            int size = square.Length;
            for (int i = 0; i < size; i++)
            {
                int j = 1;
                StringBuilder word = new StringBuilder();
                word.Append(square[0][i]);
                while (j < size)
                {
                    while (j < size && square[j][i] > square[j - 1][i])
                    {
                        word.Append(square[j][i]);
                        j++;
                    }

                    string wordString = word.ToString();
                    if (word.Length > longestWord.Length ||
                        word.Length == longestWord.Length && wordString.CompareTo(longestWord) < 0)
                    {
                        longestWord = wordString;
                    }

                    word = new StringBuilder();
                    if (j < size)
                    {
                        word.Append(square[j][i]);
                        j++;
                    }
                }
            }

            return longestWord;
        }

        private static string FindLongestWordBottomToTop(char[][] square, string longestWord)
        {
            int size = square.Length;
            for (int i = 0; i < size; i++)
            {
                int j = size - 2;
                StringBuilder word = new StringBuilder();
                word.Append(square[size - 1][i]);
                while (j >= 0)
                {
                    while (j >= 0 && square[j][i] > square[j + 1][i])
                    {
                        word.Append(square[j][i]);
                        j--;
                    }

                    string wordString = word.ToString();
                    if (word.Length > longestWord.Length
                        || word.Length == longestWord.Length && wordString.CompareTo(longestWord) < 0)
                    {
                        longestWord = wordString;
                    }

                    word = new StringBuilder();
                    if (j >= 0)
                    {
                        word.Append(square[j][i]);
                        j--;
                    }
                }
            }

            return longestWord;
        }
    }
}
