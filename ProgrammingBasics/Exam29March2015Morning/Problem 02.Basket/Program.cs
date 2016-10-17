namespace Problem_02.Basket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private const int PointLimit = 500;

        private static void Main(string[] args)
        {
            var players = new Dictionary<string, int>()
                              {
                { "Simeon", 0 },
                { "Nakov", 0 }
                              };
            var firstPlayer = Console.ReadLine();
            var secondPlayer = players.Keys.FirstOrDefault(key => !key.Equals(firstPlayer));
            var rounds = int.Parse(Console.ReadLine());
            var currentRound = 1;
            while (currentRound <= rounds)
            {
                var points = int.Parse(Console.ReadLine());
                var result = Console.ReadLine();
                if (result == "success")
                {
                    if (currentRound % 2 == 1)
                    {
                        players[firstPlayer] = players[firstPlayer] + points <= PointLimit
                                                   ? players[firstPlayer] + points
                                                   : players[firstPlayer];
                        if (players[firstPlayer] == 500)
                        {
                            break;
                        }
                    }
                    else
                    {
                        players[secondPlayer] = players[secondPlayer] + points <= PointLimit
                                                   ? players[secondPlayer] + points
                                                   : players[secondPlayer];
                        if (players[secondPlayer] == 500)
                        {
                            break;
                        }
                    }
                    
                }

                points = int.Parse(Console.ReadLine());
                result = Console.ReadLine();
                if (result == "success")
                {
                    if (currentRound % 2 == 0)
                    {
                        players[firstPlayer] = players[firstPlayer] + points <= PointLimit
                                                   ? players[firstPlayer] + points
                                                   : players[firstPlayer];
                        if (players[firstPlayer] == 500)
                        {
                            break;
                        }
                    }
                    else
                    {
                        players[secondPlayer] = players[secondPlayer] + points <= PointLimit
                                                   ? players[secondPlayer] + points
                                                   : players[secondPlayer];
                        if (players[secondPlayer] == 500)
                        {
                            break;
                        }
                    }
                }

                currentRound++;
            }

            if (currentRound == rounds + 1)
            {
                if (players[firstPlayer] == players[secondPlayer])
                {
                    Console.WriteLine("DRAW\n" + players[firstPlayer]);
                }

                if (players[firstPlayer] > players[secondPlayer])
                {
                    Console.WriteLine($"{firstPlayer}\n" + (players[firstPlayer] - players[secondPlayer]));
                }

                if (players[firstPlayer] < players[secondPlayer])
                {
                    Console.WriteLine($"{secondPlayer}\n" + (players[secondPlayer] - players[firstPlayer]));
                }

                return;
            }

            if (players[firstPlayer] == 500)
            {
                Console.WriteLine($"{firstPlayer}\n{currentRound}\n{players[secondPlayer]}");
                return;
            }

            Console.WriteLine($"{secondPlayer}\n{currentRound}\n{players[firstPlayer]}");
        }
    }
}
