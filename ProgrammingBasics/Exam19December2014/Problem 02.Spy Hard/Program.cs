namespace Problem_02.Spy_Hard
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var key = byte.Parse(Console.ReadLine());
            var message = Console.ReadLine().ToLower();

            var messageSum = 0;
            foreach (var ch in message)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    messageSum += ch - 'a' + 1;
                    continue;
                }

                messageSum += ch;
            }

            var result = new StringBuilder();
            while (messageSum > 0)
            {
                result.Append(messageSum % key);
                messageSum /= key;
            }

            var length = message.Length;
            while (length > 0)
            {
                result.Append(length % 10);
                length /= 10;
            }
            
            if (key == 10)
            {
                result.Append("01");
            }
            else
            {
                result.Append(key);
            }
            
            var endMessage = result.ToString().Reverse();
            Console.WriteLine(string.Join("",endMessage));
        }
    }
}
